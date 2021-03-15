using pm.be;
using pm.bl;
using pm.enums;
using pm.sunat;
using pm.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Telerik.WinControls.UI;
using static pm.enums.Enums;

namespace pm.app
{
    public partial class FrmMantenimientoBoletaVenta : RadForm
    {
        int? codigoBoletaVenta;
        GuiaRemisionBe guiaRemision;

        int? codigoCliente, codigoDistritoCliente;
        string nombrePaisCliente, nombreDepartamentoCliente, nombreProvinciaCliente, nombreDistritoCliente;
        string nroDocumentoIdentidadCliente;
        List<BoletaVentaDetalleBe> listaDetalleInicial = new List<BoletaVentaDetalleBe>();
        List<BoletaVentaDetalleBe> listaDetalle = new List<BoletaVentaDetalleBe>();

        ConfiguracionValorBe configuracionValor = null;

        BoletaVentaBl boletaVentaBl = new BoletaVentaBl();
        SerieBl serieBl = new SerieBl();
        TipoDocumentoIdentidadBl tipoDocumentoIdentidadBl = new TipoDocumentoIdentidadBl();
        ClienteBl clienteBl = new ClienteBl();
        ProductoBl productoBl = new ProductoBl();
        ProductoIndividualBl productoIndividualBl = new ProductoIndividualBl();
        UnidadMedidaBl unidadMedidaBl = new UnidadMedidaBl();
        ControlBusquedaBl controlBusquedaBl = new ControlBusquedaBl();
        ConfiguracionValorBl configuracionValorBl = new ConfiguracionValorBl();

        public FrmMantenimientoBoletaVenta(int? codigoBoletaVenta = null, GuiaRemisionBe guiaRemision = null)
        {
            InitializeComponent();
            this.codigoBoletaVenta = codigoBoletaVenta;
            this.guiaRemision = guiaRemision;
        }

        private void FrmMantenimientoBoletaVenta_Load(object sender, EventArgs e)
        {
            configuracionValor = configuracionValorBl.ObtenerConfiguracionValor();
            Text = !codigoBoletaVenta.HasValue ? "Nueva Boleta de Venta" + (guiaRemision == null ? "" : $" - Guía de Remisión {((TipoComprobante)guiaRemision.CodigoTipoComprobante).GetAttributeOfType<DescriptionAttribute>().Description} {guiaRemision.Serie.Serial} - {guiaRemision.NroComprobante.ToString("00000000")}") : "Modificar Boleta de Venta";
            dtpFechaHoraEmision_ValueChanged(dtpFechaHoraEmision, new EventArgs());
            ListarCombos();
            dgvDetalle.AutoGenerateColumns = false;
            if (codigoBoletaVenta.HasValue)
            {
                CargarBoletaVenta();
            }
            else CalcularTotales();
            CargarGuiaRemision();
            HabilitarModificarYEliminar();
        }

        void CargarBoletaVenta()
        {
            BoletaVentaBe item = boletaVentaBl.ObtenerBoletaVenta(codigoBoletaVenta.Value, true, true, withUnidadMedida: true);

            dtpFechaHoraEmision.Value = item.FechaHoraEmision;
            cbbCodigoSerie.SelectedValue = item.CodigoSerie;
            txtNroComprobante.Text = item.NroComprobante.ToString("00000000");
            dtpFechaHoraVencimiento.MinDate = item.FechaHoraEmision;
            dtpFechaHoraVencimiento.Value = item.FechaHoraVencimiento;
            cbbCodigoMoneda.SelectedValue = item.CodigoMoneda.ToString();

            codigoCliente = item.CodigoCliente;
            CargarCliente(codigoCliente);

            listaDetalleInicial = item.ListaBoletaVentaDetalle;
            listaDetalle = item.ListaBoletaVentaDetalle;
            ListarBoletaVentaDetalle();
        }

        void CargarGuiaRemision()
        {
            if (guiaRemision != null)
            {
                var cotizacion = guiaRemision.Cotizacion;
                if (cotizacion != null)
                {
                    dtpFechaHoraEmision.Value = DateTime.Now;
                    dtpFechaHoraVencimiento.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    dtpFechaHoraVencimiento.Value = dtpFechaHoraEmision.Value;

                    codigoCliente = cotizacion.CodigoCliente;
                    btnBuscarCliente.Enabled = false;
                    txtNroDocumentoIdentidadCliente.ReadOnly = true;
                    CargarCliente(codigoCliente);

                    ReCalcularDetalleGuiaRemision();
                    ListarBoletaVentaDetalle();
                }
            }
        }

        void ReCalcularDetalleGuiaRemision()
        {
            void Calculo(BoletaVentaDetalleBe item)
            {
                decimal cantidad = item.Cantidad, valorUnitario = 0, precioUnitario = item.PrecioUnitario, porcentajeDescuento = 0, valorPorcentajeDescuento = 0, descuento = 0, valorVenta = 0, precioVenta = 0, igv = 0, baseImponible = 0, totalImporte = 0;

                decimal porcentajeIgv = 18M;
                decimal valorPorcentajeIgv = porcentajeIgv / 100;

                valorUnitario = precioUnitario / (1 + valorPorcentajeIgv);
                valorVenta = valorUnitario * cantidad;
                precioVenta = precioUnitario * cantidad;
                totalImporte = precioVenta - descuento;
                baseImponible = totalImporte / (1 + valorPorcentajeIgv);
                igv = totalImporte - baseImponible;

                item.ValorUnitario = valorUnitario;
                item.ValorVenta = valorVenta;
                item.PrecioVenta = precioVenta;
                item.PorcentajeDescuento = porcentajeDescuento;
                item.Descuento = descuento;
                item.Igv = igv;
                item.BaseImponible = baseImponible;
                item.Importe = totalImporte;
            }

            if (guiaRemision != null)
            {
                var cotizacion = guiaRemision.Cotizacion;
                if (cotizacion != null)
                {
                    List<GuiaRemisionDetalleBe> lista = guiaRemision.ListaGuiaRemisionDetalle;
                    lista = lista.Select(x =>
                    {
                        x.CotizacionDetalle = cotizacion.ListaCotizacionDetalle.Where(y => y.CodigoCotizacionDetalle == x.CodigoCotizacionDetalle).FirstOrDefault();
                        return x;
                    }).ToList();
                    foreach (GuiaRemisionDetalleBe item in lista)
                    {
                        BoletaVentaDetalleBe itemBoleta = new BoletaVentaDetalleBe();
                        itemBoleta.CodigoGuiaRemision = item.CodigoGuiaRemision;
                        itemBoleta.CodigoGuiaRemisionDetalle = item.CodigoGuiaRemisionDetalle;
                        itemBoleta.CodigoCotizacion = cotizacion.CodigoCotizacion;
                        itemBoleta.CodigoCotizacionDetalle = item.CodigoCotizacionDetalle;
                        itemBoleta.CodigoProducto = item.CodigoProducto;
                        itemBoleta.Producto = productoBl.ObtenerProducto(item.CodigoProducto);
                        itemBoleta.CodigoProductoIndividual = item.CodigoProductoIndividual;
                        itemBoleta.ProductoIndividual = productoIndividualBl.ObtenerProductoIndividual(item.CodigoProductoIndividual);
                        itemBoleta.CodigoUnidadMedida = itemBoleta.ProductoIndividual.CodigoUnidadMedida;
                        itemBoleta.UnidadMedida = unidadMedidaBl.ObtenerUnidadMedida(itemBoleta.CodigoUnidadMedida);
                        itemBoleta.Detalle = item.Detalle;
                        itemBoleta.Cantidad = item.Cantidad;
                        itemBoleta.PrecioUnitario = item.CotizacionDetalle.PrecioUnitario;
                        itemBoleta.TipoCalculo = (int)TipoCalculo.PrecioUnitario;
                        itemBoleta.TipoDescuento = (int)TipoDescuento.Descuento;
                        Calculo(itemBoleta);

                        listaDetalle.Add(itemBoleta);
                    }

                    listaDetalleInicial = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                    listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                }
            }
        }

        void ListarCombos()
        {
            ListarComboSerie();
            ListarComboMoneda();
            ListarComboTipoDocumentoIdentidad();
        }

        void ListarComboSerie()
        {
            List<SerieBe> listaCombo = serieBl.ListarComboSerie((int)TipoComprobante.Boleta);
            listaCombo = listaCombo ?? new List<SerieBe>();
            listaCombo.Insert(0, new SerieBe { CodigoSerie = -1, Serial = "[Seleccione...]" });

            cbbCodigoSerie.DataSource = null;
            cbbCodigoSerie.DataSource = listaCombo;
        }

        void ListarComboMoneda()
        {
            List<Combo> listaCombo = Enum<Moneda>.GetCollection().ToList();

            listaCombo.Insert(0, new Combo { Value = "-1", Text = "[Seleccione...]" });

            cbbCodigoMoneda.DataSource = null;
            cbbCodigoMoneda.DataSource = listaCombo;
        }

        void ListarComboTipoDocumentoIdentidad()
        {
            List<TipoDocumentoIdentidadBe> listaCombo = tipoDocumentoIdentidadBl.ListarComboTipoDocumentoIdentidad();
            listaCombo = listaCombo ?? new List<TipoDocumentoIdentidadBe>();
            listaCombo = listaCombo.Where(x => x.CodigoTipoDocumentoIdentidad != (int)TipoDocumentoIdentidad.RUC).ToList();
            listaCombo.Insert(0, new TipoDocumentoIdentidadBe { CodigoTipoDocumentoIdentidad = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoTipoDocumentoIdentidadCliente.DataSource = null;
            cbbCodigoTipoDocumentoIdentidadCliente.DataSource = listaCombo;
        }

        private void dtpFechaHoraEmision_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaHoraVencimiento.MinDate = dtpFechaHoraEmision.Value;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (nroDocumentoIdentidadCliente == txtNroDocumentoIdentidadCliente.Text.Trim()) return;
            if (txtNroDocumentoIdentidadCliente.Text.Trim() == "") CargarCliente(null);
            string formulario = this.GetType().FullName;
            string control = ((Control)sender).Name;
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, control, true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item, txtNroDocumentoIdentidadCliente.Text.Trim());
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarCliente(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarCliente(resultado.CodigoCliente);
            }
        }

        void CargarCliente(int? codigoCliente)
        {
            ClienteBe cliente = codigoCliente == null ? null : clienteBl.ObtenerCliente(codigoCliente.Value);
            if (cliente != null)
            {
                this.codigoCliente = cliente.CodigoCliente;
                this.nroDocumentoIdentidadCliente = cliente.NroDocumentoIdentidad;
                cbbCodigoTipoDocumentoIdentidadCliente.SelectedValue = cliente.CodigoTipoDocumentoIdentidad;
                txtNroDocumentoIdentidadCliente.Text = cliente.NroDocumentoIdentidad;
                txtNombresCliente.Text = cliente.Nombres;
                txtCorreoCliente.Text = cliente.Correo;
                txtDireccionCliente.Text = cliente.Direccion;
                if (cliente.Distrito != null)
                {
                    codigoDistritoCliente = cliente.CodigoDistrito;
                    nombrePaisCliente = cliente.Distrito.Provincia.Departamento.Pais.ToString();
                    nombreDepartamentoCliente = cliente.Distrito.Provincia.Departamento.ToString();
                    nombreProvinciaCliente = cliente.Distrito.Provincia.ToString();
                    nombreDistritoCliente = cliente.Distrito.ToString();
                    txtUbicacionCliente.Text = $"{cliente.Distrito.Provincia.Departamento.Pais} - {cliente.Distrito.Provincia.Departamento} - {cliente.Distrito.Provincia} - {cliente.Distrito}";
                }
            }
            else
            {
                this.codigoCliente = null;
                this.nroDocumentoIdentidadCliente = null;
                txtNroDocumentoIdentidadCliente.Text = "";
                txtNombresCliente.Text = "";
            }
        }

        void ListarBoletaVentaDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listaDetalle;
            CalcularTotales();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            FrmMantenimientoBoletaVentaDetalle frm = new FrmMantenimientoBoletaVentaDetalle();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                frm.Detalle.CodigoBoletaVentaDetalle = GenerarCodigoBoletaVentaDetalleTemporal(frm.Detalle.CodigoProductoIndividual);
                listaDetalle.Add(frm.Detalle);
                listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarBoletaVentaDetalle();
            }
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (BoletaVentaDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            FrmMantenimientoBoletaVentaDetalle frm = new FrmMantenimientoBoletaVentaDetalle(item);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                listaDetalle[indexData] = frm.Detalle;
                //listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarBoletaVentaDetalle();
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (BoletaVentaDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                listaDetalle.RemoveAt(indexData);
                ListarBoletaVentaDetalle();
            }
        }

        void CalcularTotales()
        {
            listaDetalle = listaDetalle ?? new List<BoletaVentaDetalleBe>();
            txtTotalBaseImponible.Text = listaDetalle.Sum(x => x.BaseImponible).ToString("#,##0.00");
            txtTotalIgv.Text = listaDetalle.Sum(x => x.Igv).ToString("#,##0.00");
            txtTotalImporte.Text = listaDetalle.Sum(x => x.Importe).ToString("#,##0.00");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            BoletaVentaBe registro = new BoletaVentaBe();

            if (codigoBoletaVenta.HasValue) registro.CodigoBoletaVenta = codigoBoletaVenta.Value;
            if (guiaRemision != null)
            {
                registro.CodigoGuiaRemision = guiaRemision.CodigoGuiaRemision;
                registro.CodigoCotizacion = guiaRemision.CodigoCotizacion;
            }
            registro.FechaHoraEmision = dtpFechaHoraEmision.Value;
            registro.CodigoSerie = (int)cbbCodigoSerie.SelectedValue;
            registro.Serie = (SerieBe)cbbCodigoSerie.SelectedItem;
            registro.NroComprobante = int.Parse(string.IsNullOrEmpty(txtNroComprobante.Text.Trim()) ? "0" : txtNroComprobante.Text.Trim());
            registro.FechaHoraVencimiento = dtpFechaHoraVencimiento.Value;
            registro.CodigoMoneda = int.Parse(cbbCodigoMoneda.SelectedValue.ToString());
            registro.CodigoCliente = codigoCliente.Value;
            registro.DireccionCliente = txtDireccionCliente.Text.Trim();
            registro.NombrePaisCliente = nombrePaisCliente;
            registro.NombreDepartamentoCliente = nombreDepartamentoCliente;
            registro.NombreProvinciaCliente = nombreProvinciaCliente;
            registro.NombreDistritoCliente = nombreDistritoCliente;
            registro.CodigoDistritoCliente = codigoDistritoCliente.Value;
            registro.Cliente = new ClienteBe();
            registro.Cliente.NroDocumentoIdentidad = txtNroDocumentoIdentidadCliente.Text;
            registro.Cliente.Nombres = txtNombresCliente.Text;
            registro.ListaBoletaVentaDetalle = listaDetalle;
            registro.ListaBoletaVentaDetalleEliminar = listaDetalleInicial == null ? null : listaDetalleInicial.Where(x => listaDetalle.Count(y => y.CodigoBoletaVentaDetalle == x.CodigoBoletaVentaDetalle) == 0).Select(x => x.CodigoBoletaVentaDetalle).ToArray();
            registro.TotalOperacionGravada = listaDetalle.Sum(x => x.ValorVenta);
            registro.TotalValorVenta = listaDetalle.Sum(x => x.ValorVenta);
            registro.TotalPrecioVenta = listaDetalle.Sum(x => x.PrecioVenta);
            registro.TotalPorcentajeDescuentoGlobal = 0;
            registro.TotalDescuentoGlobal = 0;
            registro.TotalDescuentoDetallado = listaDetalle.Sum(x => x.Descuento);
            registro.TotalIgv = listaDetalle.Sum(x => x.Igv);
            registro.TotalBaseImponible = listaDetalle.Sum(x => x.BaseImponible);
            registro.TotalImporte = listaDetalle.Sum(x => x.Importe);

            int nroComprobante = 0;
            string totalEnLetras = null;
            bool seGuardoRegistro = boletaVentaBl.GuardarBoletaVenta(registro, out nroComprobante, out totalEnLetras);

            if (seGuardoRegistro)
            {
                registro.NroComprobante = nroComprobante;
                registro.TotalEnLetras = totalEnLetras;
                if (Emision.ExisteConexaoInternet() == true)
                {
                    string archivoXML = null;
                    //Genera el xml
                    DocumentoBolElectronicos(registro, out archivoXML);
                    if (!string.IsNullOrEmpty(archivoXML))
                    {
                        string CodigoHashRpta, DescripcionRpta, CodigoRpta;

                        FIRMA_ENVIO_XML(archivoXML, out CodigoHashRpta, out DescripcionRpta, out CodigoRpta);

                        bool flagEmitido = CodigoRpta == "0";

                        registro.FlagEmitido = flagEmitido;
                        registro.Hash = CodigoHashRpta;
                        registro.DescripcionRptaSunat = DescripcionRpta;
                        registro.CodigoRptaSunat = CodigoRpta;

                        seGuardoRegistro = boletaVentaBl.GuardarEmisionBoletaVenta(registro);
                    }
                    // envia a sunat
                }
                else
                {
                    MessageBox.Show("Error de conexion de internet ", "Aviso para el usuario");
                };

                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardarEmitir_Click(object sender, EventArgs e)
        {

        }

        void LimpiarErrores()
        {
            lblErrorFechaHoraEmision.Text = "";
            lblErrorCodigoSerie.Text = "";
            lblErrorNroComprobante.Text = "";
            lblErrorFechaHoraVencimiento.Text = "";
            lblErrorCodigoMoneda.Text = "";
            lblErrorCliente.Text = "";
            lblErrorDetalle.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();


            if (cbbCodigoSerie.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoSerie.Text = "Debe seleccionar una serie";
                SetToolTipError(lblErrorCodigoSerie);
            }

            if (cbbCodigoMoneda.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoMoneda.Text = "Debe seleccionar una moneda";
                SetToolTipError(lblErrorCodigoMoneda);
            }

            if (codigoCliente == null)
            {
                estaValidado = false;
                lblErrorCliente.Text = "Debe seleccionar cliente";
                SetToolTipError(lblErrorCliente);
            }

            if ((listaDetalle ?? new List<BoletaVentaDetalleBe>()).Count == 0)
            {
                estaValidado = false;
                lblErrorDetalle.Text = "No tiene registros de detalle";
                SetToolTipError(lblErrorDetalle);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltBoletaVenta.SetToolTip(label, label.Text);
        }

        private void dgvDetalle_SelectionChanged(object sender, EventArgs e)
        {
            HabilitarModificarYEliminar();
        }

        void HabilitarModificarYEliminar()
        {
            bool habilitarEditarYEliminar = dgvDetalle.CurrentRow == null ? false : dgvDetalle.CurrentRow.Index != 1;

            btnModificarDetalle.Enabled = habilitarEditarYEliminar;
            btnEliminarDetalle.Enabled = habilitarEditarYEliminar;
        }

        int GenerarCodigoBoletaVentaDetalleTemporal(int codigoProductoIndividual)
        {
            int codigoBoletaVentaDetalle = 0;
            listaDetalleInicial = listaDetalleInicial ?? new List<BoletaVentaDetalleBe>();
            var registro = listaDetalleInicial.FirstOrDefault(x => x.CodigoProductoIndividual == codigoProductoIndividual);
            listaDetalle = listaDetalle ?? new List<BoletaVentaDetalleBe>();
            if (registro == null) codigoBoletaVentaDetalle = listaDetalle.Select(x => x.CodigoBoletaVentaDetalle).DefaultIfEmpty().Min() - 1;
            else codigoBoletaVentaDetalle = registro.CodigoBoletaVentaDetalle;
            return codigoBoletaVentaDetalle;
        }

        void DocumentoBolElectronicos(BoletaVentaBe item, out string archivoXML)
        {
            archivoXML = null;

            string rucEmpresa = AppSettings.Get<string>("empresa.ruc");
            string razonSocialEmpresa = AppSettings.Get<string>("empresa.razonsocial");

            string codigoSunatMoneda = ((Moneda)item.CodigoMoneda).GetAttributeOfType<CategoryAttribute>().Category;
            string codigoSunatTipoComprobante = TipoComprobante.Boleta.GetAttributeOfType<CategoryAttribute>().Category;

            string idDoc = "";
            if (item.Cliente.NroDocumentoIdentidad.Length == 11) //ASIGNAR RUC CLIENTE
            {
                idDoc = "6";
            }
            else if (item.Cliente.NroDocumentoIdentidad.Length == 8)
            {
                idDoc = "1";
            };
            #region GENERACION

            InvoiceType Fact_XML = new InvoiceType();
            Fact_XML.Xmlns = EspacioNombres.xmlnsInvoice;
            Fact_XML.Cac = EspacioNombres.cac;
            Fact_XML.Cbc = EspacioNombres.cbc;
            Fact_XML.Ccts = EspacioNombres.ccts;
            Fact_XML.Ds = EspacioNombres.ds;
            Fact_XML.Ext = EspacioNombres.ext;
            Fact_XML.Qdt = EspacioNombres.qdt;
            Fact_XML.Udt = EspacioNombres.udt;

            XmlDocument xmlDocument = new XmlDocument();
            XmlElement firma = xmlDocument.CreateElement("ext:firma", Fact_XML.Ext);

            UBLExtensionType[] uBLExtensiones = new UBLExtensionType[2];
            UBLExtensionType uBLExtension = new UBLExtensionType();

            uBLExtension.ExtensionContent = firma;

            uBLExtensiones[0] = uBLExtension;

            Fact_XML.UBLExtensions = uBLExtensiones;
            Fact_XML.UBLVersionID = new UBLVersionIDType();
            Fact_XML.UBLVersionID.Value = "2.1";

            Fact_XML.CustomizationID = new CustomizationIDType();
            Fact_XML.CustomizationID.schemeAgencyName = "PE:SUNAT";
            Fact_XML.CustomizationID.Value = "2.0";

            ////codigo de tipo de operacion
            Fact_XML.ProfileID = new ProfileIDType();
            //Fact_XML.ProfileID.schemeAgencyName = "PE:SUNAT";
            //Fact_XML.ProfileID.schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo51";
            //Fact_XML.ProfileID.schemeName = "Tipo de Operación";
            Fact_XML.ProfileID.Value = "0101";

            //numeracion conformado por serie correlativo
            Fact_XML.ID = new IDType();

            Fact_XML.ID.Value = item.Serie.Serial + "-" + item.NroComprobante.ToString("00000000");

            //fecha de emision y hora de emision
            Fact_XML.IssueDate = new IssueDateType();
            Fact_XML.IssueDate.Value = item.FechaHoraEmision;

            Fact_XML.IssueTime = new IssueTimeType();
            Fact_XML.IssueTime.Value = Convert.ToDateTime(String.Format("{0}:{1}:{2}", item.FechaHoraEmision.Hour, item.FechaHoraEmision.Minute, item.FechaHoraEmision.Second));

            //fecha de vencimiento
            Fact_XML.DueDate = new DueDateType();
            Fact_XML.DueDate.Value = item.FechaHoraVencimiento;

            //tipo de documento factura
            InvoiceTypeCodeType TipoDoc = new InvoiceTypeCodeType()
            {
                listAgencyName = "PE:SUNAT",
                listID = "0101",
                listName = "Tipo de Documento",
                listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo01",
                listSchemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo51",
                name = "Tipo de Operacion",

                Value = codigoSunatTipoComprobante, // tipo de comprobante

            };

            Fact_XML.InvoiceTypeCode = TipoDoc;
            //Importe total en letras
            NoteType[] Leyendas = new NoteType[1];
            NoteType Leyenda = new NoteType();

            Leyenda.languageLocaleID = "1000";
            Leyenda.Value = item.TotalEnLetras;
            Leyendas[0] = Leyenda;
            Fact_XML.Note = Leyendas;

            // Tipo de moneda
            DocumentCurrencyCodeType Moneda = new DocumentCurrencyCodeType()
            {
                listAgencyName = "United Nations Economic Commission for Europe",
                listID = "ISO 4217 Alpha",
                listName = "Currency",
                Value = codigoSunatMoneda,
            };


            Fact_XML.DocumentCurrencyCode = Moneda;
            //---------------------------------------------------------------------------------------------------------------------------
            //nombre comercial 

            SignatureType[] Signatur = new SignatureType[2];
            SignatureType Signature = new SignatureType();

            IDType SignatureID = new IDType();

            SignatureID.Value = "SignTINRED";
            Signature.ID = SignatureID;

            PartyType partySign = new PartyType();

            PartyIdentificationType partyIdentification1 = new PartyIdentificationType();
            PartyIdentificationType[] partyIdentifications1 = new PartyIdentificationType[2];

            IDType Ruc_empresa = new IDType();
            Ruc_empresa.Value = rucEmpresa; // "20508457961";
            partyIdentification1.ID = Ruc_empresa;
            partyIdentifications1[0] = partyIdentification1;

            partySign.PartyIdentification = partyIdentifications1;

            NoteType Nota = new NoteType();
            NoteType[] Notas = new NoteType[2];
            Nota.Value = "Elaborado por ConsultingDev";
            Notas[0] = Nota;
            Signature.Note = Notas;

            PartyNameType partyName = new PartyNameType();
            PartyNameType[] partyNames = new PartyNameType[2];

            NameType1 Razonsocialfirma = new NameType1();
            Razonsocialfirma.Value = razonSocialEmpresa; //"PRONTO MODA SAC";
            partyName.Name = Razonsocialfirma;
            partyNames[0] = partyName;
            partySign.PartyName = partyNames;

            Signature.SignatoryParty = partySign;

            AttachmentType attachType = new AttachmentType();
            ExternalReferenceType externalReference = new ExternalReferenceType();
            URIType uri = new URIType();
            uri.Value = "#SignTINRED";
            externalReference.URI = uri;
            Signature.DigitalSignatureAttachment = attachType;
            attachType.ExternalReference = externalReference;
            Signature.DigitalSignatureAttachment = attachType;
            Signatur[0] = Signature;
            Fact_XML.Signature = Signatur;

            //<----------------------------Datos de la empresa ------------------------------>

            SupplierPartyType Empresa = new SupplierPartyType();
            PartyType party = new PartyType();

            PartyIdentificationType[] PartyIdentifications = new PartyIdentificationType[2];
            PartyIdentificationType PartyIdentification = new PartyIdentificationType();

            IDType idEmpresa = new IDType()
            {

                schemeAgencyID = "PE:SUNAT",
                schemeID = "6",
                schemeName = "Documento de Identidad",
                schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06",
                Value = rucEmpresa, //"20508457961",

            };

            PartyIdentification.ID = idEmpresa;

            PartyIdentifications[0] = PartyIdentification;
            party.PartyIdentification = PartyIdentifications;

            PartyNameType partyname2 = new PartyNameType();
            PartyNameType[] partynames2 = new PartyNameType[2];
            NameType1 nameEmisor = new NameType1();

            nameEmisor.Value = razonSocialEmpresa; //"PRONTO MODA SAC"; // empresa
            partyname2.Name = nameEmisor;
            partynames2[0] = partyname2;
            party.PartyName = partynames2;

            PartyLegalEntityType partyLegalEntity = new PartyLegalEntityType();
            PartyLegalEntityType[] parteLegalEntitys = new PartyLegalEntityType[2];

            RegistrationNameType registerNameEmisor = new RegistrationNameType();

            registerNameEmisor.Value = razonSocialEmpresa; //"PRONTO MODA SAC";
            partyLegalEntity.RegistrationName = registerNameEmisor;

            AddressTypeCodeType addressTypeCode = new AddressTypeCodeType();
            addressTypeCode.Value = "0000";

            CitySubdivisionNameType Subdivisionname = new CitySubdivisionNameType();
            Subdivisionname.Value = "-"; //EmpresaDireccion

            CityNameType provincia = new CityNameType();
            provincia.Value = "Lima";

            CountrySubentityType Departamento = new CountrySubentityType();
            Departamento.Value = "Lima";

            CountrySubentityCodeType codigodistrito = new CountrySubentityCodeType();
            codigodistrito.Value = "150141";

            DistrictType distrito = new DistrictType();
            distrito.Value = "Surquillo";

            AddressLineType[] Direccion = new AddressLineType[2];
            AddressLineType Direccions = new AddressLineType();

            Direccion[0] = Direccions;

            LineType nombrecalle = new LineType();
            nombrecalle.Value = "CAL.LAS TIENDAS NRO. 225 URB. LIMATAMBO (CDRA 8 Y 9 AV. ANDRES ARAMBURU) LIMA - LIMA - SURQUILLO";
            Direccions.Line = nombrecalle;

            AddressType RegistrationAddress = new AddressType()
            {
                AddressTypeCode = addressTypeCode,
                CitySubdivisionName = Subdivisionname,
                CityName = provincia,
                CountrySubentity = Departamento,
                CountrySubentityCode = codigodistrito,
                District = distrito,
                AddressLine = Direccion,
            };

            CountryType pais = new CountryType();
            IdentificationCodeType codigopais = new IdentificationCodeType();
            codigopais.Value = "PE";
            pais.IdentificationCode = codigopais;

            RegistrationAddress.Country = pais;

            partyLegalEntity.RegistrationAddress = RegistrationAddress;
            parteLegalEntitys[0] = partyLegalEntity;
            party.PartyLegalEntity = parteLegalEntitys;

            party.PartyName = partynames2;
            Empresa.Party = party;
            Fact_XML.AccountingSupplierParty = Empresa;

            //---------------datos-del--cliente--adquiriente-----------------------
            CustomerPartyType CustomerPartyCliente = new CustomerPartyType();

            PartyType Party2 = new PartyType();

            PartyIdentificationType[] partyIdentificions2 = new PartyIdentificationType[2];
            PartyIdentificationType partyIdentificion2 = new PartyIdentificationType();

            IDType Datoscliente = new IDType()
            {
                schemeAgencyID = "PE:SUNAT",
                schemeID = idDoc,
                schemeName = "Documento de Identidad",
                schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06",
                Value = item.Cliente.NroDocumentoIdentidad,
            };

            partyIdentificions2[0] = partyIdentificion2;
            partyIdentificion2.ID = Datoscliente;

            Party2.PartyIdentification = partyIdentificions2;

            PartyLegalEntityType[] parteLegalEntitys2 = new PartyLegalEntityType[2];
            PartyLegalEntityType partyLegalEntity2 = new PartyLegalEntityType();

            RegistrationNameType RegistroNombre = new RegistrationNameType()
            {
                Value = item.Cliente.Nombres,
            };

            parteLegalEntitys2[0] = partyLegalEntity2;
            partyLegalEntity2.RegistrationName = RegistroNombre;

            Party2.PartyIdentification = partyIdentificions2;
            Party2.PartyLegalEntity = parteLegalEntitys2;

            CustomerPartyCliente.Party = Party2;

            Fact_XML.AccountingCustomerParty = CustomerPartyCliente;

            //--------------------<!--  Inicio Tributos cabecera -->---------------------------------------

            // MontPrecTotal = MontPrecTotal - descuentogeneral.ToString("##,##0.00")
            //  Monto total de impuestos
            //  Monto las operaciones gravadas
            //  Monto las operaciones exoneradas
            //  Monto las operaciones inafectas del impuesto(Ver ejemplo en la pagina 47)
            //  Monto las operaciones gratuitas (Ver ejemplo en la pagina 48)
            //  Sumatoria de IGV
            //  Sumatoria de ISC (Ver ejemplo en la pagina 51)
            //  Sumatoria de otros tributos(Ver ejemplo en la pagina 52)
            //  Monto Total de Impuestos

            TaxTotalType TotalImptos = new TaxTotalType();
            TaxAmountType taxAmountImpto = new TaxAmountType();
            taxAmountImpto.currencyID = codigoSunatMoneda; //Comprovate igv
            taxAmountImpto.Value = Convert.ToDecimal(string.Format("{0:0.00}", item.TotalIgv));//igv
            TotalImptos.TaxAmount = taxAmountImpto;

            TaxSubtotalType[] subtotales = new TaxSubtotalType[2];
            TaxSubtotalType subtotal = new TaxSubtotalType();

            TaxableAmountType taxsubtotal = new TaxableAmountType();
            taxsubtotal.currencyID = codigoSunatMoneda;

            taxsubtotal.Value = Convert.ToDecimal(string.Format("{0:0.00}", item.TotalValorVenta));// DESCUENTO DE IMPUESTO
            subtotal.TaxableAmount = taxsubtotal;
            //total igv
            TaxAmountType TotalTaxAmountTotal = new TaxAmountType();
            TotalTaxAmountTotal.currencyID = codigoSunatMoneda;//tipo de moneda
            TotalTaxAmountTotal.Value = Convert.ToDecimal(string.Format("{0:0.00}", item.TotalIgv));//igv
            subtotal.TaxAmount = TotalTaxAmountTotal;

            subtotales[0] = subtotal;
            TotalImptos.TaxSubtotal = subtotales;

            TaxCategoryType taxCategoryTotal = new TaxCategoryType();
            TaxSchemeType taxScheme = new TaxSchemeType();

            IDType idtotal = new IDType();
            NameType1 uName = new NameType1();
            TaxTypeCodeType uTaxTypeCode = new TaxTypeCodeType();

            idtotal.schemeAgencyName = "PE:SUNAT";
            idtotal.schemeID = "UN/ECE 5153";
            idtotal.schemeName = "Codigo de tributos";

            idtotal.Value = "1000";
            uName.Value = "IGV";
            uTaxTypeCode.Value = "VAT";

            taxScheme.ID = idtotal;
            taxScheme.Name = uName;
            taxScheme.TaxTypeCode = uTaxTypeCode;
            taxCategoryTotal.TaxScheme = taxScheme;
            subtotal.TaxCategory = taxCategoryTotal;

            TaxSubtotalType[] taxSubtotals = new TaxSubtotalType[2];
            taxSubtotals[0] = subtotal;
            TotalImptos.TaxSubtotal = taxSubtotals;

            TaxTotalType[] taxtotals = new TaxTotalType[2];
            taxtotals[0] = TotalImptos;
            Fact_XML.TaxTotal = taxtotals;
            //   < !--Fin Tributos Cabecera -->

            MonetaryTotalType totalvalorventa = new MonetaryTotalType();
            LineExtensionAmountType TValorventa = new LineExtensionAmountType();
            //Total Valor de Venta
            TValorventa.currencyID = codigoSunatMoneda;// comprobante


            TValorventa.Value = Convert.ToDecimal(string.Format("{0:0.00}", item.TotalValorVenta));//valor venta
            totalvalorventa.LineExtensionAmount = TValorventa;

            //importe total

            TaxInclusiveAmountType Totalprecioventa = new TaxInclusiveAmountType();
            Totalprecioventa.currencyID = codigoSunatMoneda;
            Totalprecioventa.Value = Convert.ToDecimal(string.Format("{0:0.00}", item.TotalImporte));
            totalvalorventa.TaxInclusiveAmount = Totalprecioventa;

            //------------------------------------Descuento x items----------------------------------------------

            AllowanceTotalAmountType MtoTotalDsctos = new AllowanceTotalAmountType();
            MtoTotalDsctos.currencyID = codigoSunatMoneda;
            MtoTotalDsctos.Value = Convert.ToDecimal(string.Format("{0:0.00}", item.TotalDescuentoDetallado));
            totalvalorventa.AllowanceTotalAmount = MtoTotalDsctos;


            //ChargeTotalAmountType MtoTotalOtrosCargos = new ChargeTotalAmountType();
            //MtoTotalOtrosCargos.currencyID = codigoSunatMoneda;
            //MtoTotalOtrosCargos.Value = Convert.ToDecimal(string.Format("{0:0.00}", 0));
            //totalvalorventa.ChargeTotalAmount = MtoTotalOtrosCargos;

            //PrepaidAmountType MtoCargos = new PrepaidAmountType();
            //MtoCargos.currencyID = codigoSunatMoneda;
            //MtoCargos.Value = Convert.ToDecimal(string.Format("{0:0.00}", 0));//tributos
            //totalvalorventa.PrepaidAmount = MtoCargos;

            PayableAmountType importetotalventa = new PayableAmountType();
            importetotalventa.currencyID = codigoSunatMoneda;
            importetotalventa.Value = Convert.ToDecimal(string.Format("{0:0.00}", item.TotalImporte));

            totalvalorventa.LineExtensionAmount = TValorventa;
            totalvalorventa.TaxInclusiveAmount = Totalprecioventa;
            totalvalorventa.AllowanceTotalAmount = MtoTotalDsctos;
            // totalvalorventa.ChargeTotalAmount = MtoTotalOtrosCargos;
            // totalvalorventa.PrepaidAmount = MtoCargos;
            totalvalorventa.PayableAmount = importetotalventa;
            Fact_XML.LegalMonetaryTotal = totalvalorventa;

            //detalle ----------------------------------

            //DataTable tableDetalle = new DataTable("ParentTable");

            //'-----------------------------detallle---------------------------------------------------'
            int contador = item.ListaBoletaVentaDetalle.Count + 1;

            InvoiceLineType[] items = new InvoiceLineType[contador];
            int iditemnumero = 0;

            foreach (var detalle in item.ListaBoletaVentaDetalle)
            {

                iditemnumero++;

                //ModuloDoc.codigoItems = "NIU";// DetalleRow[0].ToString();// UNIDAD DE MEDIDA 
                //string ClaveUnidadItems = DetalleRow[7].ToString();//CODIGO DEL SUNAT
                //ModuloDoc.DescripcionItems = DetalleRow[4].ToString();//
                //ModuloDoc.CantidadItems = Convert.ToDecimal(string.Format("{0:0.00}", DetalleRow[9]));//CANTIDAD
                //ModuloDoc.PrecioUnitarioItems = Convert.ToDecimal(string.Format("{0:0.00}", DetalleRow[12])); //PRECIO UNITARIO
                //ModuloDoc.DescuentoItems = Convert.ToDecimal(string.Format("{0:0.00}", DetalleRow[17]));// DESCUENTO
                //ModuloDoc.ImporteTotalDetalle = Convert.ToDecimal(string.Format("{0:0.00}", DetalleRow[21]));//IMPORTE
                //ModuloDoc.PrecioIgv = Convert.ToDecimal(string.Format("{0:0.00}", DetalleRow[14]));//IGV

                //decimal ICBPER = Convert.ToDecimal(string.Format("{0:0.00}", DetalleRow[6]));

                InvoiceLineType InvoiceLine = new InvoiceLineType();

                IDType numeroItem = new IDType();
                //Número de orden del Ítem.
                numeroItem.Value = Convert.ToString(iditemnumero);

                InvoiceLine.ID = numeroItem;
                //Cantidad y Unidad de Medida por ítem.
                InvoicedQuantityType cantidad = new InvoicedQuantityType();
                cantidad.unitCode = detalle.UnidadMedida.CodigoSunat;
                cantidad.unitCodeListAgencyName = "United Nations Economic Commission for Europe";
                cantidad.unitCodeListAgencyID = "UN/ECE rec 20";
                cantidad.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.Cantidad));// cantidad

                InvoiceLine.InvoicedQuantity = cantidad;

                LineExtensionAmountType valorventa = new LineExtensionAmountType();
                valorventa.currencyID = codigoSunatMoneda;
                valorventa.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.PrecioUnitario));
                InvoiceLine.LineExtensionAmount = valorventa;

                //PRECIO DE VENTA UNITARIO POR ITEM Y CODIGO
                PricingReferenceType ValorReferenUnitario = new PricingReferenceType();
                PriceType[] TipoPrecios = new PriceType[2];
                PriceType TipoPrecio = new PriceType();

                PriceAmountType PriceAmountotal = new PriceAmountType();
                PriceAmountotal.currencyID = codigoSunatMoneda;
                PriceAmountotal.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.Importe));
                TipoPrecio.PriceAmount = PriceAmountotal;

                PriceTypeCodeType PriceTypeCode = new PriceTypeCodeType();
                PriceTypeCode.listAgencyName = "PE:SUNAT";
                PriceTypeCode.listName = "Tipo de Precio";
                PriceTypeCode.listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo16";
                PriceTypeCode.Value = "01";

                TipoPrecio.PriceTypeCode = PriceTypeCode;
                TipoPrecios[0] = TipoPrecio;
                ValorReferenUnitario.AlternativeConditionPrice = TipoPrecios;
                InvoiceLine.PricingReference = ValorReferenUnitario;

                //---------------------------- - Descuento por items---------------------------------

                // 
                decimal numero = 0;

                if (detalle.Descuento > numero)
                {

                    AllowanceChargeType Allowancecharges = new AllowanceChargeType();

                    ChargeIndicatorType chargeIndicator = new ChargeIndicatorType();
                    chargeIndicator.Value = false;
                    Allowancecharges.ChargeIndicator = chargeIndicator;

                    AllowanceChargeReasonCodeType allowanceChargeReasonCode = new AllowanceChargeReasonCodeType();
                    allowanceChargeReasonCode.Value = "00";//codigo por defecto
                    Allowancecharges.AllowanceChargeReasonCode = allowanceChargeReasonCode;

                    AmountType2 amount = new AmountType2();
                    amount.currencyID = codigoSunatMoneda;
                    amount.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.Descuento));// descuento
                    Allowancecharges.Amount = amount;

                    BaseAmountType baseAmount = new BaseAmountType();

                    baseAmount.currencyID = codigoSunatMoneda;
                    baseAmount.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.PrecioUnitario));
                    Allowancecharges.BaseAmount = baseAmount;

                    InvoiceLine.AllowanceCharge = new AllowanceChargeType[] { Allowancecharges };

                };


                //-------------------------------Inicio Tributos---------------------------->

                //TOTAL IGV
                TaxTotalType[] taxTotalTypes = new TaxTotalType[2];
                TaxTotalType taxTotalType = new TaxTotalType();

                TaxAmountType taxAmount1 = new TaxAmountType();
                taxAmount1.currencyID = codigoSunatMoneda;
                taxAmount1.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.Igv));//igv
                taxTotalType.TaxAmount = taxAmount1;
                taxTotalTypes[0] = taxTotalType;
                //  TaxSubtotal

                TaxSubtotalType[] TaxSubtotals = new TaxSubtotalType[2];
                TaxSubtotalType TaxSubtotal = new TaxSubtotalType();

                // TaxableAmount
                TaxableAmountType TaxableAmount = new TaxableAmountType();
                TaxableAmount.currencyID = codigoSunatMoneda;
                TaxableAmount.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.ValorVenta));
                TaxSubtotal.TaxableAmount = TaxableAmount;

                // TaxAmount
                TaxAmountType TaxAmount2 = new TaxAmountType();
                TaxAmount2.currencyID = codigoSunatMoneda;
                TaxAmount2.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.Igv));//igv
                TaxSubtotal.TaxAmount = TaxAmount2;

                TaxSubtotals[0] = TaxSubtotal;
                taxTotalType.TaxSubtotal = TaxSubtotals;

                TaxCategoryType TaxCategory = new TaxCategoryType();

                PercentType1 porcentaje = new PercentType1();
                porcentaje.Value = 18;
                TaxCategory.Percent = porcentaje;
                TaxSubtotal.TaxCategory = TaxCategory;

                TaxSchemeType TaxScheme = new TaxSchemeType();
                IDType id2_IGVItem = new IDType();

                id2_IGVItem.schemeName = "Codigo de tributos";
                id2_IGVItem.schemeAgencyName = "PE:SUNAT";
                id2_IGVItem.schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo05";

                NameType1 NameType = new NameType1();
                TaxTypeCodeType TaxTypeCode = new TaxTypeCodeType();

                id2_IGVItem.Value = "1000";
                NameType.Value = "IGV";
                TaxTypeCode.Value = "VAT";

                TaxScheme.ID = id2_IGVItem;
                TaxScheme.Name = NameType;
                TaxScheme.TaxTypeCode = TaxTypeCode;

                TaxExemptionReasonCodeType TaxExemption = new TaxExemptionReasonCodeType();

                TaxExemption.listAgencyName = "PE:SUNAT";
                TaxExemption.listName = "Afectacion del IGV";
                TaxExemption.listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo07";
                // tipo de impuesto
                TaxExemption.Value = "10";

                TaxCategory.TaxExemptionReasonCode = TaxExemption;
                TaxCategory.TaxScheme = TaxScheme;
                TaxSubtotal.TaxCategory = TaxCategory;
                InvoiceLine.TaxTotal = taxTotalTypes;

                DescriptionType[] Descriptions = new DescriptionType[2];
                DescriptionType Description = new DescriptionType();
                Description.Value = detalle.Detalle;//descripcion de producto

                PriceType PrecioProducto = new PriceType();

                PriceAmountType PrecioMontoTipo = new PriceAmountType();
                PrecioMontoTipo.currencyID = codigoSunatMoneda;
                PrecioMontoTipo.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.PrecioUnitario));// PRECIO UNITARIO

                PrecioProducto.PriceAmount = PrecioMontoTipo;

                ItemType itemTipo = new ItemType();
                Descriptions[0] = Description;
                itemTipo.Description = Descriptions;

                //CommodityClassificationType[] CommodityClassification = new CommodityClassificationType[2];
                //CommodityClassificationType CommoClassification = new CommodityClassificationType();
                //CommodityClassification[0] = CommoClassification;
                //ItemClassificationCodeType ItemClassification = new ItemClassificationCodeType();
                //ItemClassification.listID = "UNSPSC";
                //ItemClassification.listAgencyName = "GS1 US";
                //ItemClassification.listName = "Item Classification";
                //ItemClassification.Value = ClaveUnidadItems;

                //CommoClassification.ItemClassificationCode = ItemClassification;
                //itemTipo.CommodityClassification = new CommodityClassificationType[] { CommoClassification };

                ItemIdentificationType itemIdentification = new ItemIdentificationType();
                IDType iD = new IDType();
                iD.Value = "00612";

                itemIdentification.ID = iD;
                itemTipo.SellersItemIdentification = itemIdentification;

                InvoiceLine.Item = itemTipo;
                InvoiceLine.Price = PrecioProducto;

                items[Convert.ToInt32(iditemnumero)] = InvoiceLine;

            }

            Fact_XML.InvoiceLine = items;
            #endregion
            archivoXML = GenerarComprobanteFactura(ref Fact_XML, rucEmpresa, codigoSunatTipoComprobante, item.Serie.Serial, item.NroComprobante.ToString("00000000"));
        }

        string GenerarComprobanteFactura(ref InvoiceType FactXML, string EmpresaRuc, string TipoFactura, string Fac_serie, string NumFactura)
        {
            XmlSerializer nXmlSerializer = new XmlSerializer(typeof(InvoiceType));
            XmlWriter xtWriter;
            XmlWriterSettings setting = new XmlWriterSettings();
            setting.Indent = true;
            setting.IndentChars = "\t";
            string RutaDocumento = Path.Combine(configuracionValor.RutaFacturacionElectronica, "BOLETAS");

            string ArchivoXML = EmpresaRuc + "-" + TipoFactura + "-" + Fac_serie + "-" + NumFactura;
            string file = Path.Combine(RutaDocumento, string.Format(@"{0}.xml", ArchivoXML));
            xtWriter = XmlWriter.Create(file, setting);
            xtWriter.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"ISO-8859-1\" standalone=\"no\"");
            nXmlSerializer.Serialize(xtWriter, FactXML);
            xtWriter.Close();

            string text = File.ReadAllText(file);

            File.WriteAllText(file, text);
            File.WriteAllText(file, text, System.Text.Encoding.GetEncoding("ISO-8859-1"));
            return file;

        }

        private void FIRMA_ENVIO_XML(string ArchXML, out string CodigoHashRpta, out string DescripcionRpta, out string CodigoRpta)
        {
            CodigoHashRpta = null;
            DescripcionRpta = null;
            CodigoRpta = null;
            //Ruta de cetificado y clave
            string rutaCertificadoDigital = configuracionValor.RutaCertificado;//@"D:\FACTURA ELECTRONICA\CERTIFICADO\certificado.p12";
            string passwordCertificado = configuracionValor.ContraseñaCertificado;//"Chamo9832";
            // var byteArray_archivo = File.ReadAllBytes(ArchXML);
            var tramaFirmado = Emision.FirmarDocumentoXML(ArchXML, rutaCertificadoDigital, passwordCertificado);

            byte[] textoxml = Convert.FromBase64String(tramaFirmado);
            File.WriteAllBytes(ArchXML, textoxml);

            string Ruta_Envios = Path.Combine(configuracionValor.RutaFacturacionElectronica, "ENVIOS");// @"D:\FACTURA ELECTRONICA\ENVIOS\";
            string strEnvio = Path.Combine(Ruta_Envios, Path.GetFileName(ArchXML).Replace(".xml", ".zip"));

            Emision.ComprimirDocumentoZip(ArchXML, strEnvio);

            if (Emision.ExisteConexaoInternet() == true)
            {
                EnviarDocumento(strEnvio, ArchXML, out CodigoHashRpta, out DescripcionRpta, out CodigoRpta);
            }
            else
            {
                MessageBox.Show("Error de conexion de internet ", "Aviso para el usuario");
            };
        }

        public void EnviarDocumento(string FileArchivo, string ArchXML, out string CodigoHashRpta, out string DescripcionRpta, out string CodigoRpta)
        {
            CodigoHashRpta = null;
            DescripcionRpta = null;
            CodigoRpta = null;
            try
            {
                System.Net.ServicePointManager.UseNagleAlgorithm = true;
                System.Net.ServicePointManager.Expect100Continue = false;
                System.Net.ServicePointManager.CheckCertificateRevocationList = true;

                BasicHttpBinding Binding = new BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential);
                Binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
                Binding.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.None;
                Binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
                Binding.Security.Message.AlgorithmSuite = System.ServiceModel.Security.SecurityAlgorithmSuite.Default;

                //CERTIFICACIÓN - HOMOLOGACIÓN
                //string sURL = "https://www.sunat.gob.pe:443/ol-ti-itcpgem-sqa/billService"; // - CERTIFICACIÓN - HOMOLOGACIÓN

                //PRODUCCIÓN
                // string sURL = "https://e-factura.sunat.gob.pe:443/ol-ti-itcpfegem/billService"; // - PRODUCCIÓN

                //PRUEBAS

                string sURL = "https://e-beta.sunat.gob.pe:443/ol-ti-itcpfegem-beta/billService";  // - PRUEBAS

                EndpointAddress remoteAddress;
                remoteAddress = new EndpointAddress(sURL);
                SWFacturaElectronica.billServiceClient ws;
                ws = new SWFacturaElectronica.billServiceClient(Binding, remoteAddress);
                ws.ClientCredentials.UserName.UserName = configuracionValor.UsuarioSOL;// "10096164144MODDATOS";//  '"20895626281PELM202" '- 'RUC + USUARIO
                ws.ClientCredentials.UserName.Password = configuracionValor.ContraseñaSOL;// "moddatos"; // ' - Contraseña
                var elements = ws.Endpoint.Binding.CreateBindingElements();
                elements.Find<SecurityBindingElement>().EnableUnsecuredResponse = true;
                ws.Endpoint.Binding = new CustomBinding(elements);

                string FileZip = FileArchivo;
                string FilePath = FileZip;
                byte[] byteArray = File.ReadAllBytes(FilePath);

                FileZip = Path.GetFileName(FileZip);
                string Ruta_CDRS = Path.Combine(configuracionValor.RutaFacturacionElectronica, "CDR");// @"D:\FACTURA ELECTRONICA\CDR\";
                FileStream fs = new FileStream(Path.Combine(Ruta_CDRS, "R-" + FileZip), FileMode.Create);
                byte[] oRespuestaXML;

                oRespuestaXML = ws.sendBill(Path.GetFileName(FileZip), byteArray, "");
                Console.WriteLine(System.Text.Encoding.UTF8.GetString(oRespuestaXML));
                fs.Write(oRespuestaXML, 0, oRespuestaXML.Length);
                fs.Close();

                XmlDocument documento = new XmlDocument();
                // Dim nodo As XmlNode
                documento.Load(ArchXML);

                XmlNodeList elemList = documento.GetElementsByTagName("DigestValue");

                for (int i = 0; i < elemList.Count; i++)
                {
                    CodigoHashRpta = (elemList[i].InnerXml);
                }

                string Ruta_descomprimir = Path.Combine(configuracionValor.RutaFacturacionElectronica, "DESCOMPRIMIR");// @"D:\FACTURA ELECTRONICA\DESCOMPRIMIR\";
                string descomprimir = Path.Combine(Ruta_descomprimir, Path.GetFileName(fs.Name).Replace(".zip", ""));
                Emision.DescromprimirZip(fs.Name, descomprimir);
                FileZip = "R-" + Path.GetFileName(FileZip).Replace(".zip", ".xml");


                var descomprimirxml = descomprimir + @"\" + FileZip;

                XmlDocument documentos = new XmlDocument();
                documentos.Load(descomprimirxml);

                XmlNodeList elemList1 = documentos.GetElementsByTagName("cbc:Description");

                for (int i = 0; i < elemList1.Count; i++)
                {
                    DescripcionRpta = (elemList1[i].InnerXml);
                }

                XmlNodeList elemList2 = documentos.GetElementsByTagName("cbc:ResponseCode");

                for (int i = 0; i < elemList2.Count; i++)
                {
                    CodigoRpta = (elemList2[i].InnerXml);
                }

                //ModuloDoc.ResultadoQR = ModuloDoc.RucEmpresa + " | " + ModuloDoc.codigoTipoDoc + " | " + ModuloDoc.Serie + "-" + ModuloDoc.numeroFactura + " | " + ModuloDoc.MontPrecTotal * 0.18M + " | " + ModuloDoc.MontPrecTotal + " | " + DateTime.Now.ToString("dd/mm/yyyy") + " | " + "6" + " | " + ModuloDoc.RucCliente + " | " + ModuloDoc.Codigohas + " | ";

                //ACTUALIZAR Codigo hast

                //registro.Hash = ModuloDoc.Codigohas;
                //boletaVentaBl.ModificarHast(registro);
                //BuscarBoletasVenta();

                //MessageBox.Show("Resultado: " + ModuloDoc.Descripcion + " " + ModuloDoc.ResponseCode, "Aviso para el usuario");

            }
            catch (System.ServiceModel.FaultException ex)

            {

                MessageBox.Show(ex.Code.Name + " " + ex.Message, "Advertecia", MessageBoxButtons.OK);
            }

        }
    }
}
