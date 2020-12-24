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
    public partial class FrmComprobantePago : RadForm
    {
        ComprobantePagoBl comprobantePagoBl = new ComprobantePagoBl();
        SerieBl serieBl = new SerieBl();

        public FrmComprobantePago()
        {
            InitializeComponent();
        }

        private void FrmComprobantePago_Load(object sender, EventArgs e)
        {
            dtpFiltroFechaPagoDesde.Value = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
            ListarComboSerie();
            BuscarComprobantesPago();
        }

        void ListarComboSerie()
        {
            List<SerieBe> listaCombo = serieBl.ListarComboSerie((int)TipoComprobante.ComprobantePago) ?? new List<SerieBe>();

            listaCombo.Insert(0, new SerieBe { CodigoSerie = -1, Serial = "[Todos...]" });

            cbbFiltroCodigoSerie.DataSource = null;
            cbbFiltroCodigoSerie.DataSource = listaCombo;
        }

        void BuscarComprobantesPago()
        {
            DateTime fechaPagoDesde = dtpFiltroFechaPagoDesde.Value;
            DateTime fechaPagoHasta = dtpFiltroFechaPagoHasta.Value;
            int codigoSerieInt = (int)cbbFiltroCodigoSerie.SelectedValue;
            int? codigoSerie = codigoSerieInt == -1 ? null : (int?)codigoSerieInt;
            string nroComprobante = txtFiltroNroComprobante.Text.Trim();
            string nroDocIdentidadCliente = txtFiltroNroDocIdentidadCliente.Text.Trim();
            string nombresCliente = txtFiltroNombresCliente.Text.Trim();
            bool flagAnulado = chkAnulado.Checked;


            List<ComprobantePagoBe> resultados = comprobantePagoBl.BuscarComprobantePago(fechaPagoDesde, fechaPagoHasta, codigoSerie, nroComprobante, nroDocIdentidadCliente, nombresCliente, flagAnulado);

            List<dynamic> resultadosDynamic = resultados == null ? null : resultados.Select(x => {
                dynamic row = new { x.Fila, x.CodigoComprobantePago, x.FechaHoraPago, SerialSerie = x.Serie.Serial, x.NroComprobante, x.CodigoMoneda, x.StrMoneda, x.CodigoCliente, DescripcionTipoDocumentoIdentidadCliente = x.Cliente.TipoDocumentoIdentidad.Descripcion, NroDocumentoIdentidadCliente = x.Cliente.NroDocumentoIdentidad, NombresCliente = x.Cliente.Nombres, x.Monto, x.FlagAnulado };
                return row;
            }).ToList();

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultadosDynamic;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarComprobantesPago();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoComprobantePago frm = new FrmMantenimientoComprobantePago();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarComprobantesPago();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagAnulado = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagAnulado"].Value;
                int codigoComprobantePago = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoComprobantePago"].Value;

                ContextMenu m = new ContextMenu();

                MenuItem mitAnular = new MenuItem("Anular", mitAnular_Click);
                mitAnular.Tag = new { CodigoComprobantePago = codigoComprobantePago, FlagAnulado = flagAnulado };

                if (!flagAnulado) m.MenuItems.Add(mitAnular);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitAnular_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;
            dynamic data = (object)mitControl.Tag;

            DialogResult dr = MessageBox.Show($"¿Estás seguro que deseas anular el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                ComprobantePagoBe registro = new ComprobantePagoBe();
                registro.CodigoComprobantePago = data.CodigoComprobantePago;
                registro.FlagAnulado = true;
                bool seGuardo = comprobantePagoBl.CambiarFlagAnuladoComprobantePago(registro);
                if (seGuardo)
                {
                    MessageBox.Show($"Se anuló el registro", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarComprobantesPago();
                }
                else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
