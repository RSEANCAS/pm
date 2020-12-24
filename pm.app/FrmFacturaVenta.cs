using Microsoft.Reporting.WinForms;
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
    public partial class FrmFacturaVenta : RadForm
    {
        FacturaVentaBl facturaVentaBl = new FacturaVentaBl();
        SerieBl serieBl = new SerieBl();
        FormatoBl formatoBl = new FormatoBl();

        public FrmFacturaVenta()
        {
            InitializeComponent();
        }

        private void FrmFacturaVenta_Load(object sender, EventArgs e)
        {
            dtpFiltroFechaEmisionDesde.Value = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
            ListarComboSerie();
            BuscarFacturasVenta();
        }

        void ListarComboSerie()
        {
            List<SerieBe> listaCombo = serieBl.ListarComboSerie((int)TipoComprobante.Factura) ?? new List<SerieBe>();

            listaCombo.Insert(0, new SerieBe { CodigoSerie = -1, Serial = "[Todos...]" });

            cbbFiltroCodigoSerie.DataSource = null;
            cbbFiltroCodigoSerie.DataSource = listaCombo;
        }

        void BuscarFacturasVenta()
        {
            DateTime fechaEmisionDesde = dtpFiltroFechaEmisionDesde.Value;
            DateTime fechaEmisionHasta = dtpFiltroFechaEmisionHasta.Value;
            int codigoSerieInt = (int)cbbFiltroCodigoSerie.SelectedValue;
            int? codigoSerie = codigoSerieInt == -1 ? null : (int?)codigoSerieInt;
            string nroComprobante = txtFiltroNroComprobante.Text.Trim();
            string nroDocIdentidadCliente = txtFiltroNroDocIdentidadCliente.Text.Trim();
            string nombresCliente = txtFiltroNombresCliente.Text.Trim();
            bool flagActivo = chkActivo.Checked;

            List<FacturaVentaBe> resultados = facturaVentaBl.BuscarFacturaVenta(fechaEmisionDesde, fechaEmisionHasta, codigoSerie, nroComprobante, nroDocIdentidadCliente, nombresCliente, flagActivo);

            List<dynamic> resultadosDynamic = resultados == null ? null : resultados.Select(x => {
                dynamic row = new { x.Fila, x.CodigoFacturaVenta, x.CodigoGuiaRemision, x.CodigoCotizacion, x.Serie, x.NroComprobante, x.FechaHoraEmision, FechaEmision = x.FechaHoraEmision.ToString("dd/MM/yyyy"), x.FechaHoraVencimiento, FechaVencimiento = x.FechaHoraVencimiento.ToString("dd/MM/yyyy"), DescripcionTipoDocumentoIdentidadCliente = x.Cliente.TipoDocumentoIdentidad.Descripcion, NroDocumentoIdentidadCliente = x.Cliente.NroDocumentoIdentidad, NombresCliente = x.Cliente.Nombres, x.Cliente, x.CodigoMoneda, x.StrMoneda, x.TotalImporte, NombreTipoComprobanteGuiaRemision = x.GuiaRemision == null ? null : x.GuiaRemision.TipoComprobante.Nombre, SerialSerieGuiaRemision = x.GuiaRemision == null ? null : x.GuiaRemision.Serie.Serial, NroComprobanteGuiaRemision = x.GuiaRemision == null ? null : (int?)x.GuiaRemision.NroComprobante, FechaHoraEmisionGuiaRemision = x.GuiaRemision == null ? null : (DateTime?)x.GuiaRemision.FechaHoraEmision, x.FlagEmitido, x.FlagActivo };
                return row;
            }).ToList();

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultadosDynamic;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarFacturasVenta();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoFacturaVenta frm = new FrmMantenimientoFacturaVenta();
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
                bool flagEmitido = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagEmitido"].Value;
                int codigoFacturaVenta = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoFacturaVenta"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoFacturaVenta;

                //MenuItem mitToggleActivar = new MenuItem(flagActivo ? "Inactivar" : "Activar", mitToggleActivar_Click);
                //mitToggleActivar.Tag = new { CodigoCliente = codigoCliente, FlagActivo = flagActivo };

                if (flagActivo && !flagEmitido)
                {
                    m.MenuItems.Add(mitEditar);

                    MenuItem mitGenerarNota = new MenuItem("Generar Nota");

                    MenuItem mitGenerarNotaCredito = new MenuItem("Nota de Crédito", mitGenerarNotaCredito_Click);
                    mitGenerarNotaCredito.Tag = codigoFacturaVenta;

                    MenuItem mitGenerarNotaDebito = new MenuItem("Nota de Débito", mitGenerarNotaDebito_Click);
                    mitGenerarNotaDebito.Tag = codigoFacturaVenta;

                    mitGenerarNota.MenuItems.Add(mitGenerarNotaCredito);
                    mitGenerarNota.MenuItems.Add(mitGenerarNotaDebito);
                    m.MenuItems.Add(mitGenerarNota);
                }
                MenuItem mitVerFormato = new MenuItem("Ver Formato", mitVerFormato_Click);
                mitVerFormato.Tag = codigoFacturaVenta;
                m.MenuItems.Add(mitVerFormato);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoFacturaVenta = (int)mitControl.Tag;

            FrmMantenimientoFacturaVenta frm = new FrmMantenimientoFacturaVenta(codigoFacturaVenta);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarFacturasVenta();
        }

        private void mitGenerarNotaCredito_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoGuiaRemision = (int)mitControl.Tag;

            FacturaVentaBe facturaVenta = facturaVentaBl.ObtenerFacturaVenta(codigoGuiaRemision, true, withSerie: true);

            FrmMantenimientoNotaCredito frm = new FrmMantenimientoNotaCredito(null, facturaVenta, TipoComprobante.Factura);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarFacturasVenta();
        }

        private void mitGenerarNotaDebito_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoGuiaRemision = (int)mitControl.Tag;

            FacturaVentaBe facturaVenta = facturaVentaBl.ObtenerFacturaVenta(codigoGuiaRemision, true, withSerie: true);

            FrmMantenimientoNotaDebito frm = new FrmMantenimientoNotaDebito(null, facturaVenta, TipoComprobante.Factura);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarFacturasVenta();
        }

        private void mitVerFormato_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoFacturaVenta = (int)mitControl.Tag;

            FormatoBe.Factura dsCabecera = formatoBl.ObtenerFormatoFacturaVenta(codigoFacturaVenta);
            List<ReportDataSource> rpd = new List<ReportDataSource>();
            rpd.Add(new ReportDataSource("dsCabecera", new List<FormatoBe.Factura>() { dsCabecera}));
            rpd.Add(new ReportDataSource("dsDetalle", dsCabecera.ListaDetalle));

            FrmFormatoCompartido frm = new FrmFormatoCompartido(rpd.ToArray(), "rptFormatoFactura");
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ShowDialog();
            //DialogResult dr = frm.ShowDialog();
            //if (dr == DialogResult.OK) BuscarLetras();
        }
    }
}
