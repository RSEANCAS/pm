using pm.be;
using pm.bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using static pm.enums.Enums;

namespace pm.app
{
    public partial class FrmNotaCredito : RadForm
    {
        NotaCreditoBl notaCreditoBl = new NotaCreditoBl();
        SerieBl serieBl = new SerieBl();

        public FrmNotaCredito()
        {
            InitializeComponent();
        }

        private void FrmNotaCredito_Load(object sender, EventArgs e)
        {
            dtpFiltroFechaEmisionDesde.Value = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
            ListarComboSerie();
            BuscarNotasCreditoVenta();
        }

        void ListarComboSerie()
        {
            List<SerieBe> listaCombo = serieBl.ListarComboSerie((int)TipoComprobante.NotaCredito) ?? new List<SerieBe>();

            listaCombo.Insert(0, new SerieBe { CodigoSerie = -1, Serial = "[Todos...]" });

            cbbFiltroCodigoSerie.DataSource = null;
            cbbFiltroCodigoSerie.DataSource = listaCombo;
        }

        void BuscarNotasCreditoVenta()
        {
            DateTime fechaEmisionDesde = dtpFiltroFechaEmisionDesde.Value;
            DateTime fechaEmisionHasta = dtpFiltroFechaEmisionHasta.Value;
            int codigoSerieInt = (int)cbbFiltroCodigoSerie.SelectedValue;
            int? codigoSerie = codigoSerieInt == -1 ? null : (int?)codigoSerieInt;
            string nroComprobante = txtFiltroNroComprobante.Text.Trim();
            string nroDocIdentidadCliente = txtFiltroNroDocIdentidadCliente.Text.Trim();
            string nombresCliente = txtFiltroNombresCliente.Text.Trim();
            bool flagActivo = chkActivo.Checked;

            List<NotaCreditoBe> resultados = notaCreditoBl.BuscarNotaCredito(fechaEmisionDesde, fechaEmisionHasta, codigoSerie, nroComprobante, nroDocIdentidadCliente, nombresCliente, flagActivo);

            List<dynamic> resultadosDynamic = resultados == null ? null : resultados.Select(x => {
                dynamic row = new { x.Fila, x.CodigoNotaCredito, x.CodigoTipoComprobanteRef, x.CodigoComprobanteRef, x.Serie, x.NroComprobante, x.FechaHoraEmision, FechaEmision = x.FechaHoraEmision.ToString("dd/MM/yyyy"), DescripcionTipoDocumentoIdentidadCliente = x.Cliente.TipoDocumentoIdentidad.Descripcion, NroDocumentoIdentidadCliente = x.Cliente.NroDocumentoIdentidad, NombresCliente = x.Cliente.Nombres, x.Cliente, x.CodigoMoneda, x.StrMoneda, DescripcionMotivoNota = x.MotivoNota.Descripcion, x.TotalImporte, NombreTipoComprobanteRef = x.TipoComprobanteRef == null ? null : x.TipoComprobanteRef.Nombre, SerialSerieComprobanteRef = x.ComprobanteRef == null ? null : x.ComprobanteRef.Serie.Serial, NroComprobanteComprobanteRef = x.ComprobanteRef == null ? null : (int?)x.ComprobanteRef.NroComprobante, FechaHoraEmisionComprobanteRef = x.ComprobanteRef == null ? null : (DateTime?)x.ComprobanteRef.FechaHoraEmision, x.FlagEmitido, x.FlagActivo };
                return row;
            }).ToList();

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultadosDynamic;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarNotasCreditoVenta();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoNotaCredito frm = new FrmMantenimientoNotaCredito();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarNotasCreditoVenta();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagActivo = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagActivo"].Value;
                bool flagEmitido = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagEmitido"].Value;
                int codigoNotaCredito = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoNotaCredito"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoNotaCredito;

                //MenuItem mitToggleActivar = new MenuItem(flagActivo ? "Inactivar" : "Activar", mitToggleActivar_Click);
                //mitToggleActivar.Tag = new { CodigoCliente = codigoCliente, FlagActivo = flagActivo };

                if (flagActivo && !flagEmitido) m.MenuItems.Add(mitEditar);
                //m.MenuItems.Add(mitToggleActivar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoNotaCredito = (int)mitControl.Tag;

            FrmMantenimientoNotaCredito frm = new FrmMantenimientoNotaCredito(codigoNotaCredito);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarNotasCreditoVenta();
        }
    }
}
