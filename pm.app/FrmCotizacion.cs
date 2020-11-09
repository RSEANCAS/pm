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
    public partial class FrmCotizacion : RadForm
    {
        CotizacionBl cotizacionBl = new CotizacionBl();

        public FrmCotizacion()
        {
            InitializeComponent();
        }

        private void FrmCotizacion_Load(object sender, EventArgs e)
        {
            dtpFiltroFechaEmisionDesde.Value = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
            BuscarCotizaciones();
        }

        void BuscarCotizaciones()
        {
            DateTime fechaEmisionDesde = dtpFiltroFechaEmisionDesde.Value;
            DateTime fechaEmisionHasta = dtpFiltroFechaEmisionHasta.Value;
            string nroComprobante = txtFiltroNroComprobante.Text.Trim();
            string nroDocIdentidadCliente = txtFiltroNroDocIdentidadCliente.Text.Trim();
            string nombresCliente = txtFiltroNombresCliente.Text.Trim();
            bool flagActivo = chkActivo.Checked;

            List<CotizacionBe> resultados = cotizacionBl.BuscarCotizacion(fechaEmisionDesde, fechaEmisionHasta, nroComprobante, nroDocIdentidadCliente, nombresCliente, flagActivo);

            List<dynamic> resultadosDynamic = resultados == null ? null : resultados.Select(x => {
                dynamic row = new { x.Fila, x.FechaHoraEmision, FechaEmision = x.FechaHoraEmision.ToString("dd/MM/yyyy"), x.NroPedido, DescripcionTipoDocumentoIdentidadCliente = x.Cliente.TipoDocumentoIdentidad.Descripcion, NroDocumentoIdentidadCliente = x.Cliente.NroDocumentoIdentidad, NombresCliente = x.Cliente.Nombres, DescripcionTipoDocumentoIdentidadVendedor = x.Vendedor.TipoDocumentoIdentidad.Descripcion, NroDocumentoIdentidadVendedor = x.Vendedor.NroDocumentoIdentidad, NombresVendedor = x.Vendedor.Nombres, x.TotalImporte, x.FlagActivo };
                return row;
            }).ToList();

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultados;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCotizaciones();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoCotizacion frm = new FrmMantenimientoCotizacion();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarCotizaciones();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagActivo = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagActivo"].Value;
                //bool flagEmitido = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagEmitido"].Value;
                int codigoCotizacion = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoCotizacion"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoCotizacion;

                MenuItem mitGenerarGuiaRemision = new MenuItem("Generar Guía Remisión", mitGenerarGuiaRemision_Click);
                mitGenerarGuiaRemision.Tag = codigoCotizacion;

                //MenuItem mitToggleActivar = new MenuItem(flagActivo ? "Inactivar" : "Activar", mitToggleActivar_Click);
                //mitToggleActivar.Tag = new { CodigoCliente = codigoCliente, FlagActivo = flagActivo };

                if (flagActivo)
                {
                    m.MenuItems.Add(mitEditar);
                    m.MenuItems.Add(mitGenerarGuiaRemision);
                }
                //m.MenuItems.Add(mitToggleActivar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoCotizacion = (int)mitControl.Tag;

            FrmMantenimientoCotizacion frm = new FrmMantenimientoCotizacion(codigoCotizacion);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarCotizaciones();
        }

        private void mitGenerarGuiaRemision_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoCotizacion = (int)mitControl.Tag;

            CotizacionBe cotizacion = cotizacionBl.ObtenerCotizacion(codigoCotizacion, true);

            FrmMantenimientoGuiaRemision frm = new FrmMantenimientoGuiaRemision(null, cotizacion);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarCotizaciones();
        }
    }
}
