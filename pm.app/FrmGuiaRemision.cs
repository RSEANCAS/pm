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
    public partial class FrmGuiaRemision : RadForm
    {
        GuiaRemisionBl guiaRemisionBl = new GuiaRemisionBl();
        SerieBl serieBl = new SerieBl();
        CotizacionBl cotizacionBl = new CotizacionBl();

        public FrmGuiaRemision()
        {
            InitializeComponent();
        }

        private void FrmGuiaRemision_Load(object sender, EventArgs e)
        {
            dtpFiltroFechaEmisionDesde.Value = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
            ListarComboSerie();
            BuscarGuiasRemision();
        }

        void ListarComboSerie()
        {
            List<SerieBe> listaComboGuiaRemitente = serieBl.ListarComboSerie((int)TipoComprobante.GuiaRemisionRemitente) ?? new List<SerieBe>();
            List<SerieBe> listaComboGuiaTransportista = serieBl.ListarComboSerie((int)TipoComprobante.GuiaRemisionTransportista) ?? new List<SerieBe>();

            List<SerieBe> listaCombo = (listaComboGuiaRemitente ?? new List<SerieBe>());
            listaCombo.AddRange((listaComboGuiaTransportista ?? new List<SerieBe>()));

            listaCombo.Insert(0, new SerieBe { CodigoSerie = -1, Serial = "[Todos...]" });

            cbbFiltroCodigoSerie.DataSource = null;
            cbbFiltroCodigoSerie.DataSource = listaCombo;
        }

        void BuscarGuiasRemision()
        {
            DateTime fechaEmisionDesde = dtpFiltroFechaEmisionDesde.Value;
            DateTime fechaEmisionHasta = dtpFiltroFechaEmisionHasta.Value;
            int codigoSerieInt = (int)cbbFiltroCodigoSerie.SelectedValue;
            int? codigoSerie = codigoSerieInt == -1 ? null : (int?)codigoSerieInt;
            string nroComprobante = txtFiltroNroComprobante.Text.Trim();
            string nroDocIdentidadCliente = txtFiltroNroDocIdentidadCliente.Text.Trim();
            string nombresCliente = txtFiltroNombresCliente.Text.Trim();
            bool flagActivo = chkActivo.Checked;

            List<GuiaRemisionBe> resultados = guiaRemisionBl.BuscarGuiaRemision(fechaEmisionDesde, fechaEmisionHasta, codigoSerie, nroComprobante, nroDocIdentidadCliente, nombresCliente, flagActivo);

            List<dynamic> resultadosDynamic = resultados == null ? null : resultados.Select(x => {
                dynamic row = new { x.Fila, x.CodigoGuiaRemision, x.CodigoCotizacion, NroComprobanteCotizacion = x.Cotizacion == null ? null : (int?)x.Cotizacion.NroComprobante, NroPedidoCotizacion = x.Cotizacion == null ? null : x.Cotizacion.NroPedido, FechaHoraEmisionCotizacion = x.Cotizacion == null ? null : (DateTime?)x.Cotizacion.FechaHoraEmision, x.TipoComprobante, x.Serie, x.NroComprobante, x.FechaHoraEmision, FechaEmision = x.FechaHoraEmision.ToString("dd/MM/yyyy"), x.FechaHoraTraslado, FechaVencimiento = x.FechaHoraTraslado.ToString("dd/MM/yyyy"), DescripcionTipoDocumentoIdentidadCliente = x.Cliente.TipoDocumentoIdentidad.Descripcion, NroDocumentoIdentidadCliente = x.Cliente.NroDocumentoIdentidad, NombresCliente = x.Cliente.Nombres, x.Cliente, DescripcionTipoDocumentoIdentidadTransportista = x.Transportista.TipoDocumentoIdentidad.Descripcion, NroDocumentoIdentidadTransportista = x.Transportista.NroDocumentoIdentidad, NombresTransportista = x.Transportista.Nombres, x.Transportista, x.MotivoTraslado, x.FlagEmitido, x.FlagActivo };
                return row;
            }).ToList();

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultadosDynamic;

            lblResultados.Text = (resultadosDynamic == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarGuiasRemision();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoGuiaRemision frm = new FrmMantenimientoGuiaRemision();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarGuiasRemision();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagActivo = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagActivo"].Value;
                bool flagEmitido = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagEmitido"].Value;
                int codigoGuiaRemision = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoGuiaRemision"].Value;
                int? codigoCotizacion = (int?)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoCotizacion"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoGuiaRemision;

                MenuItem mitGenerarComprobanteVenta = new MenuItem("Generar Comprobante de Venta");
                //MenuItem mitToggleActivar = new MenuItem(flagActivo ? "Inactivar" : "Activar", mitToggleActivar_Click);
                //mitToggleActivar.Tag = new { CodigoCliente = codigoCliente, FlagActivo = flagActivo };

                if (flagActivo && !flagEmitido)
                {
                    MenuItem mitGenerarComprobanteFacturaVenta = new MenuItem("Factura Venta", mitGenerarComprobanteFacturaVenta_Click);
                    mitGenerarComprobanteFacturaVenta.Tag = codigoGuiaRemision;

                    MenuItem mitGenerarComprobanteBoletaVenta = new MenuItem("Boleta Venta", mitGenerarComprobanteBoletaVenta_Click);
                    mitGenerarComprobanteBoletaVenta.Tag = codigoGuiaRemision;

                    mitGenerarComprobanteVenta.MenuItems.Add(mitGenerarComprobanteBoletaVenta);
                    mitGenerarComprobanteVenta.MenuItems.Add(mitGenerarComprobanteFacturaVenta);


                    m.MenuItems.Add(mitEditar);
                    if (codigoCotizacion.HasValue) m.MenuItems.Add(mitGenerarComprobanteVenta);
                }
                //m.MenuItems.Add(mitToggleActivar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoGuiaRemision = (int)mitControl.Tag;

            FrmMantenimientoGuiaRemision frm = new FrmMantenimientoGuiaRemision(codigoGuiaRemision);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarGuiasRemision();
        }

        private void mitGenerarComprobanteBoletaVenta_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoGuiaRemision = (int)mitControl.Tag;

            GuiaRemisionBe guiaRemision = guiaRemisionBl.ObtenerGuiaRemision(codigoGuiaRemision, true, true);
            if (guiaRemision.CodigoCotizacion.HasValue) guiaRemision.Cotizacion = cotizacionBl.ObtenerCotizacion(guiaRemision.CodigoCotizacion.Value, true);

            FrmMantenimientoBoletaVenta frm = new FrmMantenimientoBoletaVenta(null, guiaRemision);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarGuiasRemision();
        }

        private void mitGenerarComprobanteFacturaVenta_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoGuiaRemision = (int)mitControl.Tag;

            GuiaRemisionBe guiaRemision = guiaRemisionBl.ObtenerGuiaRemision(codigoGuiaRemision, true, true);
            if (guiaRemision.CodigoCotizacion.HasValue) guiaRemision.Cotizacion = cotizacionBl.ObtenerCotizacion(guiaRemision.CodigoCotizacion.Value, true);

            FrmMantenimientoFacturaVenta frm = new FrmMantenimientoFacturaVenta(null, guiaRemision);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarGuiasRemision();
        }
    }
}
