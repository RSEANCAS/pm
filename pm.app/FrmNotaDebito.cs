using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Microsoft.Reporting.WinForms;
using pm.be;
using pm.bl;
using pm.enums;
using pm.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using static pm.enums.Enums;

namespace pm.app
{
    public partial class FrmNotaDebito : RadForm
    {
        NotaDebitoBl notaDebitoBl = new NotaDebitoBl();
        SerieBl serieBl = new SerieBl();
        FormatoBl formatoBl = new FormatoBl();

        public FrmNotaDebito()
        {
            InitializeComponent();
        }

        private void FrmNotaDebito_Load(object sender, EventArgs e)
        {
            dtpFiltroFechaEmisionDesde.Value = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
            ListarComboSerie();
            BuscarNotasDebitoVenta();
        }

        void ListarComboSerie()
        {
            List<SerieBe> listaCombo = serieBl.ListarComboSerie((int)TipoComprobante.NotaDebito) ?? new List<SerieBe>();

            listaCombo.Insert(0, new SerieBe { CodigoSerie = -1, Serial = "[Todos...]" });

            cbbFiltroCodigoSerie.DataSource = null;
            cbbFiltroCodigoSerie.DataSource = listaCombo;
        }

        void BuscarNotasDebitoVenta()
        {
            DateTime fechaEmisionDesde = dtpFiltroFechaEmisionDesde.Value;
            DateTime fechaEmisionHasta = dtpFiltroFechaEmisionHasta.Value;
            int codigoSerieInt = (int)cbbFiltroCodigoSerie.SelectedValue;
            int? codigoSerie = codigoSerieInt == -1 ? null : (int?)codigoSerieInt;
            string nroComprobante = txtFiltroNroComprobante.Text.Trim();
            string nroDocIdentidadCliente = txtFiltroNroDocIdentidadCliente.Text.Trim();
            string nombresCliente = txtFiltroNombresCliente.Text.Trim();
            bool flagActivo = chkActivo.Checked;

            List<NotaDebitoBe> resultados = notaDebitoBl.BuscarNotaDebito(fechaEmisionDesde, fechaEmisionHasta, codigoSerie, nroComprobante, nroDocIdentidadCliente, nombresCliente, flagActivo);

            List<dynamic> resultadosDynamic = resultados == null ? null : resultados.Select(x => {
                dynamic row = new { x.Fila, x.CodigoNotaDebito, x.CodigoTipoComprobanteRef, x.CodigoComprobanteRef, x.Serie, x.NroComprobante, x.FechaHoraEmision, FechaEmision = x.FechaHoraEmision.ToString("dd/MM/yyyy"), DescripcionTipoDocumentoIdentidadCliente = x.Cliente.TipoDocumentoIdentidad.Descripcion, NroDocumentoIdentidadCliente = x.Cliente.NroDocumentoIdentidad, NombresCliente = x.Cliente.Nombres, x.Cliente, x.CodigoMoneda, x.StrMoneda, DescripcionMotivoNota = x.MotivoNota.Descripcion, x.TotalImporte, NombreTipoComprobanteRef = x.TipoComprobanteRef == null ? null : x.TipoComprobanteRef.Nombre, SerialSerieComprobanteRef = x.ComprobanteRef == null ? null : x.ComprobanteRef.Serie.Serial, NroComprobanteComprobanteRef = x.ComprobanteRef == null ? null : (int?)x.ComprobanteRef.NroComprobante, FechaHoraEmisionComprobanteRef = x.ComprobanteRef == null ? null : (DateTime?)x.ComprobanteRef.FechaHoraEmision, x.FlagEmitido, x.FlagActivo };
                return row;
            }).ToList();

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultadosDynamic;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarNotasDebitoVenta();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoNotaDebito frm = new FrmMantenimientoNotaDebito();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarNotasDebitoVenta();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagActivo = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagActivo"].Value;
                bool flagEmitido = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagEmitido"].Value;
                int codigoNotaDebito = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoNotaDebito"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoNotaDebito;

                if (flagActivo && !flagEmitido) m.MenuItems.Add(mitEditar);
                else if (flagActivo && flagEmitido)
                {
                    MenuItem mitVerFormato = new MenuItem("Ver Formato", mitVerFormato_Click);
                    mitVerFormato.Tag = codigoNotaDebito;
                    m.MenuItems.Add(mitVerFormato);
                }

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoNotaDebito = (int)mitControl.Tag;

            FrmMantenimientoNotaDebito frm = new FrmMantenimientoNotaDebito(codigoNotaDebito);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarNotasDebitoVenta();
        }

        private void mitVerFormato_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoNotaDebito = (int)mitControl.Tag;

            FormatoBe.NotaDebito dsCabecera = formatoBl.ObtenerFormatoNotaDebito(codigoNotaDebito);
            dsCabecera.QR = ObtenerQR(dsCabecera);
            List<ReportDataSource> rpd = new List<ReportDataSource>();
            rpd.Add(new ReportDataSource("dsCabecera", new List<FormatoBe.NotaDebito>() { dsCabecera }));
            rpd.Add(new ReportDataSource("dsDetalle", dsCabecera.ListaDetalle));

            string nombreArchivo = dsCabecera.Serie + " - " + dsCabecera.Correlativo.ToString("00000000");

            FrmFormatoCompartido frm = new FrmFormatoCompartido(rpd.ToArray(), "rptFormatoNotaDebito", nombreArchivo);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ShowDialog();
            //DialogResult dr = frm.ShowDialog();
            //if (dr == DialogResult.OK) BuscarLetras();
        }

        byte[] ObtenerQR(FormatoBe.NotaDebito item)
        {
            byte[] imagen = null;

            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();

            string rucEmpresa = AppSettings.Get<string>("empresa.ruc");
            string codigoSunatTipoComprobante = TipoComprobante.Factura.GetAttributeOfType<CategoryAttribute>().Category;
            string codigoSunatTipoDocumentoIdentidad = ((TipoDocumentoIdentidad)item.CodigoTipoDocumentoIdentidadCliente).GetAttributeOfType<CategoryAttribute>().Category;

            qrEncoder.TryEncode($"{rucEmpresa}|{codigoSunatTipoComprobante}|{item.Serie}-{item.Correlativo.ToString("00000000")}|{item.TotalIGV}|{item.TotalImporte}|{item.FechaEmision.ToString("dd/MM/yyyy")}|{codigoSunatTipoDocumentoIdentidad}|{item.NroDocumentoIdentidadCliente}|{item.Hash}", out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

            MemoryStream ms = new MemoryStream();

            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);

            imagen = ms.ToArray();

            return imagen;
        }
    }
}
