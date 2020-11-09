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

namespace pm.app
{
    public partial class FrmComprobanteCompra : RadForm
    {
        ComprobanteCompraBl guiaRemisionBl = new ComprobanteCompraBl();
        SerieBl serieBl = new SerieBl();

        public FrmComprobanteCompra()
        {
            InitializeComponent();
        }

        private void FrmComprobanteCompra_Load(object sender, EventArgs e)
        {
            dtpFiltroFechaEmisionDesde.Value = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
            BuscarFacturasVenta();
        }

        void BuscarFacturasVenta()
        {
            DateTime fechaEmisionDesde = dtpFiltroFechaEmisionDesde.Value;
            DateTime fechaEmisionHasta = dtpFiltroFechaEmisionHasta.Value;
            string serie = txtFiltroSerie.Text.Trim();
            string nroComprobante = txtFiltroNumero.Text.Trim();
            string nroDocIdentidadCliente = txtFiltroNroDocIdentidadProveedor.Text.Trim();
            string nombresCliente = txtFiltroNombresProveedor.Text.Trim();
            bool flagActivo = chkActivo.Checked;

            List<ComprobanteCompraBe> resultados = guiaRemisionBl.BuscarComprobanteCompra(fechaEmisionDesde, fechaEmisionHasta, serie, nroComprobante, nroDocIdentidadCliente, nombresCliente, flagActivo);

            List<dynamic> resultadosDynamic = resultados == null ? null : resultados.Select(x => {
                dynamic row = new { x.Fila, x.Serie, x.FechaHoraRegistro, FechaEmision = x.FechaHoraRegistro.ToString("dd/MM/yyyy"), FechaCompra = x.FechaCompra.ToString("dd/MM/yyyy"), DescripcionTipoDocumentoIdentidadProveedor = x.Proveedor.TipoDocumentoIdentidad.Descripcion, NroDocumentoIdentidadProveedor = x.Proveedor.NroDocumentoIdentidad, NombresProveedor = x.Proveedor.Nombres, x.FlagActivo };
                return row;
            }).ToList();

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultados;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarFacturasVenta();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoComprobanteCompra frm = new FrmMantenimientoComprobanteCompra();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarFacturasVenta();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagActivo = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagActivo"].Value;
                //bool flagEmitido = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagEmitido"].Value;
                int codigoComprobanteCompra = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoComprobanteCompra"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoComprobanteCompra;

                //MenuItem mitToggleActivar = new MenuItem(flagActivo ? "Inactivar" : "Activar", mitToggleActivar_Click);
                //mitToggleActivar.Tag = new { CodigoCliente = codigoCliente, FlagActivo = flagActivo };

                if (flagActivo) m.MenuItems.Add(mitEditar);
                //m.MenuItems.Add(mitToggleActivar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoComprobanteCompra = (int)mitControl.Tag;

            FrmMantenimientoComprobanteCompra frm = new FrmMantenimientoComprobanteCompra(codigoComprobanteCompra);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarFacturasVenta();
        }
    }
}
