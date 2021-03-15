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
    public partial class FrmMantenimientoNotaCredito : RadForm
    {
        int? codigoNotaCredito;
        dynamic comprobanteRef;
        TipoComprobante? tipoComprobante;

        int? codigoCliente, codigoDistritoCliente;
        string nombrePaisCliente, nombreDepartamentoCliente, nombreProvinciaCliente, nombreDistritoCliente;
        string nroDocumentoIdentidadCliente;
        List<NotaCreditoDetalleBe> listaDetalleInicial = new List<NotaCreditoDetalleBe>();
        List<NotaCreditoDetalleBe> listaDetalle = new List<NotaCreditoDetalleBe>();

        ConfiguracionValorBe configuracionValor = null;

        NotaCreditoBl notaCreditoBl = new NotaCreditoBl();
        FacturaVentaBl facturaVentaBl = new FacturaVentaBl();
        BoletaVentaBl boletaVentaBl = new BoletaVentaBl();
        SerieBl serieBl = new SerieBl();
        MotivoNotaBl motivoNotaBl = new MotivoNotaBl();
        TipoComprobanteBl tipoComprobanteBl = new TipoComprobanteBl();
        TipoDocumentoIdentidadBl tipoDocumentoIdentidadBl = new TipoDocumentoIdentidadBl();
        ClienteBl clienteBl = new ClienteBl();
        ProductoBl productoBl = new ProductoBl();
        ProductoIndividualBl productoIndividualBl = new ProductoIndividualBl();
        UnidadMedidaBl unidadMedidaBl = new UnidadMedidaBl();
        ControlBusquedaBl controlBusquedaBl = new ControlBusquedaBl();
        ConfiguracionValorBl configuracionValorBl = new ConfiguracionValorBl();

        public FrmMantenimientoNotaCredito(int? codigoNotaCredito = null, dynamic comprobanteRef = null, TipoComprobante? tipoComprobante = null)
        {
            InitializeComponent();
            this.codigoNotaCredito = codigoNotaCredito;
            this.comprobanteRef = comprobanteRef;
            this.tipoComprobante = tipoComprobante;
        }

        private void FrmMantenimientoNotaCredito_Load(object sender, EventArgs e)
        {
            configuracionValor = configuracionValorBl.ObtenerConfiguracionValor();
            Text = !codigoNotaCredito.HasValue ? "Nueva Nota de Crédito" + (comprobanteRef == null ? "" : $" - {tipoComprobante.GetAttributeOfType<DescriptionAttribute>().Description} {comprobanteRef.Serie.Serial} - {comprobanteRef.NroComprobante.ToString("00000000")}") : "Modificar Nota de Crédito";
            ListarCombos();
            dgvDetalle.AutoGenerateColumns = false;
            if (codigoNotaCredito.HasValue)
            {
                CargarNotaCredito();
            }
            else
            {
                CalcularTotales();
                CargarComprobanteRef();
            }
            HabilitarModificarYEliminar();
        }

        void CargarNotaCredito()
        {
            NotaCreditoBe item = notaCreditoBl.ObtenerNotaCredito(codigoNotaCredito.Value, true, withUnidadMedida: true);

            dtpFechaHoraEmision.Value = item.FechaHoraEmision;
            cbbCodigoSerie.SelectedValue = item.CodigoSerie;
            txtNroComprobante.Text = item.NroComprobante.ToString("00000000");
            cbbCodigoMoneda.SelectedValue = item.CodigoMoneda.ToString();
            cbbCodigoMotivoNota.SelectedValue = item.CodigoMotivoNota;

            //tipoComprobante = (TipoComprobante)item.CodigoTipoComprobanteRef;
            cbbCodigoTipoComprobante.SelectedValue = item.CodigoTipoComprobanteRef;
            CargarComprobanteRef(item.CodigoComprobanteRef);

            codigoCliente = item.CodigoCliente;
            CargarCliente(codigoCliente);

            listaDetalleInicial = item.ListaNotaCreditoDetalle;
            listaDetalle = item.ListaNotaCreditoDetalle;
            ListarNotaCreditoDetalle();
        }

        void CargarComprobanteRef()
        {
            if (comprobanteRef != null)
            {
                dtpFechaHoraEmision.Value = DateTime.Now;

                cbbCodigoTipoComprobante.Enabled = false;
                cbbCodigoTipoComprobante.SelectedValue = (int)tipoComprobante;
                cbbCodigoSerieRef.SelectedValue = comprobanteRef.CodigoSerie;
                txtNroComprobanteRef.Text = comprobanteRef.NroComprobante.ToString("00000000");
                txtFechaHoraEmisionRef.Text = comprobanteRef.FechaHoraEmision.ToString("dd/MM/yyyy");

                btnBuscarComprobanteRef.Enabled = false;

                codigoCliente = comprobanteRef.CodigoCliente;
                btnBuscarCliente.Enabled = false;
                txtNroDocumentoIdentidadCliente.ReadOnly = true;
                CargarCliente(codigoCliente);

                ReCalcularDetalleComprobanteRef(tipoComprobante, comprobanteRef);
                ListarNotaCreditoDetalle();
            }
        }

        NotaCreditoDetalleBe CargarListaDetalleRef(FacturaVentaDetalleBe item, FacturaVentaBe comprobante)
        {
            NotaCreditoDetalleBe itemNotaCredito = new NotaCreditoDetalleBe();
            itemNotaCredito.CodigoTipoComprobanteRef = (int)TipoComprobante.Factura;
            itemNotaCredito.CodigoComprobanteRef = comprobante.CodigoFacturaVenta;
            itemNotaCredito.CodigoComprobanteDetalleRef = item.CodigoFacturaVentaDetalle;
            itemNotaCredito.CodigoProducto = item.CodigoProducto;
            itemNotaCredito.Producto = productoBl.ObtenerProducto(item.CodigoProducto);
            itemNotaCredito.CodigoProductoIndividual = item.CodigoProductoIndividual;
            itemNotaCredito.ProductoIndividual = productoIndividualBl.ObtenerProductoIndividual(item.CodigoProductoIndividual);
            itemNotaCredito.CodigoUnidadMedida = itemNotaCredito.ProductoIndividual.CodigoUnidadMedida;
            itemNotaCredito.UnidadMedida = unidadMedidaBl.ObtenerUnidadMedida(itemNotaCredito.CodigoUnidadMedida);
            itemNotaCredito.Detalle = item.Detalle;
            itemNotaCredito.Cantidad = item.Cantidad;
            itemNotaCredito.PrecioUnitario = item.PrecioUnitario;
            itemNotaCredito.TipoCalculo = (int)TipoCalculo.PrecioUnitario;
            itemNotaCredito.TipoDescuento = (int)TipoDescuento.Descuento;
            Calculo(itemNotaCredito);

            return itemNotaCredito;
        }

        NotaCreditoDetalleBe CargarListaDetalleRef(BoletaVentaDetalleBe item, BoletaVentaBe comprobante)
        {
            NotaCreditoDetalleBe itemNotaCredito = new NotaCreditoDetalleBe();
            itemNotaCredito.CodigoTipoComprobanteRef = (int)TipoComprobante.Boleta;
            itemNotaCredito.CodigoComprobanteRef = comprobante.CodigoBoletaVenta;
            itemNotaCredito.CodigoComprobanteDetalleRef = item.CodigoBoletaVentaDetalle;
            itemNotaCredito.CodigoProducto = item.CodigoProducto;
            itemNotaCredito.Producto = productoBl.ObtenerProducto(item.CodigoProducto);
            itemNotaCredito.CodigoProductoIndividual = item.CodigoProductoIndividual;
            itemNotaCredito.ProductoIndividual = productoIndividualBl.ObtenerProductoIndividual(item.CodigoProductoIndividual);
            itemNotaCredito.CodigoUnidadMedida = itemNotaCredito.ProductoIndividual.CodigoUnidadMedida;
            itemNotaCredito.UnidadMedida = unidadMedidaBl.ObtenerUnidadMedida(itemNotaCredito.CodigoUnidadMedida);
            itemNotaCredito.Detalle = item.Detalle;
            itemNotaCredito.Cantidad = item.Cantidad;
            itemNotaCredito.PrecioUnitario = item.PrecioUnitario;
            itemNotaCredito.TipoCalculo = (int)TipoCalculo.PrecioUnitario;
            itemNotaCredito.TipoDescuento = (int)TipoDescuento.Descuento;
            Calculo(itemNotaCredito);

            return itemNotaCredito;
        }

        void Calculo(NotaCreditoDetalleBe item)
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

        void ReCalcularDetalleComprobanteRef(TipoComprobante? tipoComprobante, dynamic comprobanteRef)
        {

            if (comprobanteRef != null)
            {
                List<dynamic> lista = tipoComprobante == TipoComprobante.Factura ? ((List<FacturaVentaDetalleBe>)comprobanteRef.ListaFacturaVentaDetalle ?? new List<FacturaVentaDetalleBe>()).Cast<dynamic>().ToList() : tipoComprobante == TipoComprobante.Boleta ? ((List<BoletaVentaDetalleBe>)comprobanteRef.ListaBoletaVentaDetalle ?? new List<BoletaVentaDetalleBe>()).Cast<dynamic>().ToList() : new List<dynamic>();

                foreach (var item in lista)
                {
                    NotaCreditoDetalleBe itemNotaCredito = CargarListaDetalleRef(item, comprobanteRef);

                    listaDetalle.Add(itemNotaCredito);
                }

                listaDetalleInicial = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
            }
        }

        void ListarCombos()
        {
            ListarComboSerie();
            ListarComboMoneda();
            ListarComboMotivoNota();
            ListarComboTipoComprobante();
            ListarComboTipoDocumentoIdentidad();
        }

        void ListarComboSerie()
        {
            List<SerieBe> listaCombo = serieBl.ListarComboSerie((int)TipoComprobante.NotaCredito);
            listaCombo = listaCombo ?? new List<SerieBe>();
            listaCombo.Insert(0, new SerieBe { CodigoSerie = -1, Serial = "[Seleccione...]" });

            cbbCodigoSerie.DataSource = null;
            cbbCodigoSerie.DataSource = listaCombo;
        }

        void ListarComboSerieRef()
        {
            int tipoComprobante = (int)cbbCodigoTipoComprobante.SelectedValue;
            List<SerieBe> listaCombo = serieBl.ListarComboSerie(tipoComprobante);
            listaCombo = listaCombo ?? new List<SerieBe>();
            listaCombo.Insert(0, new SerieBe { CodigoSerie = -1, Serial = "[Seleccione...]" });

            cbbCodigoSerieRef.DataSource = null;
            cbbCodigoSerieRef.DataSource = listaCombo;
        }

        void ListarComboMoneda()
        {
            List<Combo> listaCombo = Enum<Moneda>.GetCollection().ToList();

            listaCombo.Insert(0, new Combo { Value = "-1", Text = "[Seleccione...]" });

            cbbCodigoMoneda.DataSource = null;
            cbbCodigoMoneda.DataSource = listaCombo;
        }

        void ListarComboMotivoNota()
        {
            List<MotivoNotaBe> listaCombo = motivoNotaBl.ListarComboMotivoNota((int)TipoComprobante.NotaCredito);
            listaCombo = listaCombo ?? new List<MotivoNotaBe>();
            listaCombo.Insert(0, new MotivoNotaBe { CodigoMotivoNota = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoMotivoNota.DataSource = null;
            cbbCodigoMotivoNota.DataSource = listaCombo;
        }

        void ListarComboTipoComprobante()
        {
            List<TipoComprobanteBe> listaCombo = tipoComprobanteBl.ListarComboTipoComprobante();
            listaCombo = listaCombo ?? new List<TipoComprobanteBe>();
            listaCombo = listaCombo.Where(x => (new int[] { (int)TipoComprobante.Factura, (int)TipoComprobante.Boleta }).Contains(x.CodigoTipoComprobante)).ToList();
            listaCombo.Insert(0, new TipoComprobanteBe { CodigoTipoComprobante = -1, Nombre = "[Seleccione...]" });

            cbbCodigoTipoComprobante.DataSource = null;
            cbbCodigoTipoComprobante.DataSource = listaCombo;
        }

        void ListarComboTipoDocumentoIdentidad()
        {
            List<TipoDocumentoIdentidadBe> listaCombo = tipoDocumentoIdentidadBl.ListarComboTipoDocumentoIdentidad();
            listaCombo = listaCombo ?? new List<TipoDocumentoIdentidadBe>();
            listaCombo.Insert(0, new TipoDocumentoIdentidadBe { CodigoTipoDocumentoIdentidad = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoTipoDocumentoIdentidadCliente.DataSource = null;
            cbbCodigoTipoDocumentoIdentidadCliente.DataSource = listaCombo;
        }

        private void btnBuscarComprobanteRef_Click(object sender, EventArgs e)
        {
            TipoComprobante? tipoComprobanteRef = cbbCodigoTipoComprobante.SelectedIndex == 0 ? null : (TipoComprobante?)(TipoComprobante)cbbCodigoTipoComprobante.SelectedValue;
            if (tipoComprobanteRef == null)
            {
                MessageBox.Show("Debe seleccionar el tipo de comprobante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string strTipoComprobante = tipoComprobanteRef == TipoComprobante.Factura ? "FacturaVenta" : tipoComprobanteRef == TipoComprobante.Boleta ? "BoletaVenta" : "";

            string formulario = this.GetType().FullName;
            string control = $"{((Control)sender).Name}{strTipoComprobante}";
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, control, true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarComprobanteRef(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                if (tipoComprobanteRef == TipoComprobante.Factura) CargarComprobanteRef(resultado.CodigoFacturaVenta);
                else if (tipoComprobanteRef == TipoComprobante.Boleta) CargarComprobanteRef(resultado.CodigoBoletaVenta);
            }
        }

        void CargarComprobanteRef(int? codigoComprobante)
        {
            TipoComprobante? tipoComprobanteRef = cbbCodigoTipoComprobante.SelectedIndex == 0 ? null : (TipoComprobante?)(TipoComprobante)cbbCodigoTipoComprobante.SelectedValue;
            if (codigoComprobante.HasValue)
            {
                dynamic comprobante = tipoComprobanteRef == TipoComprobante.Factura ? (dynamic)facturaVentaBl.ObtenerFacturaVenta(codigoComprobante.Value, true, withSerie: true, withUnidadMedida: true) : tipoComprobanteRef == TipoComprobante.Boleta ? (dynamic)boletaVentaBl.ObtenerBoletaVenta(codigoComprobante.Value, true, true, withUnidadMedida: true) : null;
                if (comprobante != null)
                {
                    this.comprobanteRef = comprobante;
                    //cbbCodigoTipoComprobante.SelectedValue = (int)tipoComprobanteRef;
                    cbbCodigoSerieRef.SelectedValue = comprobante.CodigoSerie;
                    txtNroComprobanteRef.Text = comprobante.NroComprobante.ToString("00000000");
                    txtFechaHoraEmisionRef.Text = comprobante.FechaHoraEmision.ToString("dd/MM/yyyy");

                    codigoCliente = comprobante.CodigoCliente;
                    CargarCliente(codigoCliente);

                    ReCalcularDetalleComprobanteRef(tipoComprobanteRef, comprobante);
                    ListarNotaCreditoDetalle();
                }
                else
                {
                    this.comprobanteRef = null;
                    cbbCodigoSerieRef.SelectedIndex = 0;
                    txtNroComprobanteRef.Text = "";
                    txtFechaHoraEmisionRef.Text = "";

                    CargarCliente(null);
                }
            }
            else
            {
                this.comprobanteRef = null;
                cbbCodigoSerieRef.SelectedIndex = 0;
                txtNroComprobanteRef.Text = "";
                txtFechaHoraEmisionRef.Text = "";
                CargarCliente(null);

            }
            btnBuscarCliente.Enabled = cbbCodigoTipoComprobante.SelectedIndex == 0;
            txtNroDocumentoIdentidadCliente.ReadOnly = !(cbbCodigoTipoComprobante.SelectedIndex == 0);
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
                if (cbbCodigoTipoDocumentoIdentidadCliente.Items.Count > 0) cbbCodigoTipoDocumentoIdentidadCliente.SelectedIndex = 0;
                txtNroDocumentoIdentidadCliente.Text = "";
                txtNombresCliente.Text = "";
                txtCorreoCliente.Text = "";
                txtDireccionCliente.Text = "";
                txtUbicacionCliente.Text = "";
            }
        }

        void ListarNotaCreditoDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listaDetalle;
            CalcularTotales();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            FrmMantenimientoNotaCreditoDetalle frm = new FrmMantenimientoNotaCreditoDetalle();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                frm.Detalle.CodigoNotaCreditoDetalle = GenerarCodigoNotaCreditoDetalleTemporal(frm.Detalle.CodigoProductoIndividual);
                listaDetalle.Add(frm.Detalle);
                listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarNotaCreditoDetalle();
            }
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (NotaCreditoDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            FrmMantenimientoNotaCreditoDetalle frm = new FrmMantenimientoNotaCreditoDetalle(item);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                listaDetalle[indexData] = frm.Detalle;
                //listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarNotaCreditoDetalle();
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (NotaCreditoDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                listaDetalle.RemoveAt(indexData);
                ListarNotaCreditoDetalle();
            }
        }

        void CalcularTotales()
        {
            listaDetalle = listaDetalle ?? new List<NotaCreditoDetalleBe>();
            txtTotalBaseImponible.Text = listaDetalle.Sum(x => x.BaseImponible).ToString("#,##0.00");
            txtTotalIgv.Text = listaDetalle.Sum(x => x.Igv).ToString("#,##0.00");
            txtTotalImporte.Text = listaDetalle.Sum(x => x.Importe).ToString("#,##0.00");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            tipoComprobante = (TipoComprobante)(int)cbbCodigoTipoComprobante.SelectedValue;

            NotaCreditoBe registro = new NotaCreditoBe();

            if (codigoNotaCredito.HasValue) registro.CodigoNotaCredito = codigoNotaCredito.Value;
            registro.CodigoTipoComprobanteRef = (int)tipoComprobante;
            registro.TipoComprobanteRef = (TipoComprobanteBe)cbbCodigoTipoComprobante.SelectedItem;
            registro.CodigoComprobanteRef = tipoComprobante.Value == TipoComprobante.Boleta ? comprobanteRef.CodigoBoletaVenta : tipoComprobante.Value == TipoComprobante.Factura ? comprobanteRef.CodigoFacturaVenta : 0;
            registro.ComprobanteRef = comprobanteRef;
            registro.FechaHoraEmision = dtpFechaHoraEmision.Value;
            registro.CodigoSerie = (int)cbbCodigoSerie.SelectedValue;
            registro.Serie = (SerieBe)cbbCodigoSerie.SelectedItem;
            registro.NroComprobante = int.Parse(string.IsNullOrEmpty(txtNroComprobante.Text.Trim()) ? "0" : txtNroComprobante.Text.Trim());
            registro.CodigoMoneda = int.Parse(cbbCodigoMoneda.SelectedValue.ToString());
            registro.CodigoMotivoNota = (int)cbbCodigoMotivoNota.SelectedValue;
            registro.MotivoNota = (MotivoNotaBe)cbbCodigoMotivoNota.SelectedItem;
            registro.CodigoCliente = codigoCliente.Value;
            registro.DireccionCliente = txtDireccionCliente.Text.Trim();
            registro.NombrePaisCliente = nombrePaisCliente;
            registro.NombreDepartamentoCliente = nombreDepartamentoCliente;
            registro.NombreProvinciaCliente = nombreProvinciaCliente;
            registro.NombreDistritoCliente = nombreDistritoCliente;
            registro.CodigoDistritoCliente = codigoDistritoCliente.Value;
            registro.Cliente = new ClienteBe();
            registro.Cliente.NroDocumentoIdentidad = txtNroDocumentoIdentidadCliente.Text.Trim();
            registro.Cliente.Nombres = txtNombresCliente.Text.Trim();
            registro.ListaNotaCreditoDetalle = listaDetalle;
            registro.ListaNotaCreditoDetalleEliminar = listaDetalleInicial == null ? null : listaDetalleInicial.Where(x => listaDetalle.Count(y => y.CodigoNotaCreditoDetalle == x.CodigoNotaCreditoDetalle) == 0).Select(x => x.CodigoNotaCreditoDetalle).ToArray();
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
            bool seGuardoRegistro = notaCreditoBl.GuardarNotaCredito(registro, out nroComprobante, out totalEnLetras);

            if (seGuardoRegistro)
            {
                registro.NroComprobante = nroComprobante;
                registro.TotalEnLetras = totalEnLetras;
                if (Emision.ExisteConexaoInternet() == true)
                {
                    string archivoXML = null;
                    //Genera el xml
                    DocumentoNCElectronicos(registro, out archivoXML);
                    if (!string.IsNullOrEmpty(archivoXML))
                    {
                        string CodigoHashRpta, DescripcionRpta, CodigoRpta;

                        // envia a sunat
                        FIRMA_ENVIO_XML(archivoXML, out CodigoHashRpta, out DescripcionRpta, out CodigoRpta);

                        bool flagEmitido = CodigoRpta == "0";

                        registro.FlagEmitido = flagEmitido;
                        registro.Hash = CodigoHashRpta;
                        registro.DescripcionRptaSunat = DescripcionRpta;
                        registro.CodigoRptaSunat = CodigoRpta;

                        seGuardoRegistro = notaCreditoBl.GuardarEmisionNotaCredito(registro);
                    }
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
            lblErrorCodigoMoneda.Text = "";
            lblErrorCodigoMotivoNota.Text = "";
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

            if (cbbCodigoMotivoNota.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoMotivoNota.Text = "Debe seleccionar un motivo";
                SetToolTipError(lblErrorCodigoMotivoNota);
            }

            if (codigoCliente == null)
            {
                estaValidado = false;
                lblErrorCliente.Text = "Debe seleccionar cliente";
                SetToolTipError(lblErrorCliente);
            }

            if ((listaDetalle ?? new List<NotaCreditoDetalleBe>()).Count == 0)
            {
                estaValidado = false;
                lblErrorDetalle.Text = "No tiene registros de detalle";
                SetToolTipError(lblErrorDetalle);
            }

            return estaValidado;
        }

        private void cbbCodigoTipoComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarComboSerieRef();
            txtNroComprobanteRef.Text = "";
            txtFechaHoraEmisionRef.Text = "";

            btnBuscarCliente.Enabled = cbbCodigoTipoComprobante.SelectedIndex == 0;
            txtNroDocumentoIdentidadCliente.ReadOnly = !(cbbCodigoTipoComprobante.SelectedIndex == 0);
            CargarCliente(null);

            listaDetalle = null;

            ListarNotaCreditoDetalle();
        }

        void SetToolTipError(Label label)
        {
            tltNotaCredito.SetToolTip(label, label.Text);
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

        int GenerarCodigoNotaCreditoDetalleTemporal(int codigoProductoIndividual)
        {
            int codigoNotaCreditoDetalle = 0;
            listaDetalleInicial = listaDetalleInicial ?? new List<NotaCreditoDetalleBe>();
            var registro = listaDetalleInicial.FirstOrDefault(x => x.CodigoProductoIndividual == codigoProductoIndividual);
            listaDetalle = listaDetalle ?? new List<NotaCreditoDetalleBe>();
            if (registro == null) codigoNotaCreditoDetalle = listaDetalle.Select(x => x.CodigoNotaCreditoDetalle).DefaultIfEmpty().Min() - 1;
            else codigoNotaCreditoDetalle = registro.CodigoNotaCreditoDetalle;
            return codigoNotaCreditoDetalle;
        }

        void DocumentoNCElectronicos(NotaCreditoBe item, out string archivoXML)
        {
            archivoXML = null;

            string rucEmpresa = AppSettings.Get<string>("empresa.ruc");
            string razonSocialEmpresa = AppSettings.Get<string>("empresa.razonsocial");

            string codigoSunatMoneda = ((Moneda)item.CodigoMoneda).GetAttributeOfType<CategoryAttribute>().Category;
            string codigoSunatTipoComprobante = TipoComprobante.NotaCredito.GetAttributeOfType<CategoryAttribute>().Category;

            string idDoc = "";
            if (item.Cliente.NroDocumentoIdentidad.Length == 11) //ASIGNAR RUC CLIENTE
            {
                idDoc = "6";
            }
            else if (item.Cliente.NroDocumentoIdentidad.Length == 8)
            {
                idDoc = "1";
            };

            CreditNoteType creditNote = new CreditNoteType();

            creditNote.Xmlns = EspacioNombres.xmlnsCreditNote;
            creditNote.Cac = EspacioNombres.cac;
            creditNote.Cbc = EspacioNombres.cbc;
            creditNote.Ccts = EspacioNombres.ccts;
            creditNote.Ds = EspacioNombres.ds;
            creditNote.Ext = EspacioNombres.ext;
            creditNote.Qdt = EspacioNombres.qdt;
            creditNote.Udt = EspacioNombres.udt;
            creditNote.sac = EspacioNombres.sac;
            // creditNote.Xsi = EspacioNombres.xsi;


            XmlDocument xmlDocument = new XmlDocument();
            XmlElement firma = xmlDocument.CreateElement("ext:firma", creditNote.Ext);

            UBLExtensionType[] uBLExtensiones = new UBLExtensionType[2];
            UBLExtensionType uBLExtension = new UBLExtensionType();

            uBLExtension.ExtensionContent = firma;

            uBLExtensiones[0] = uBLExtension;

            creditNote.UBLExtensions = uBLExtensiones;
            creditNote.UBLVersionID = new UBLVersionIDType();
            creditNote.UBLVersionID.Value = "2.1";

            creditNote.CustomizationID = new CustomizationIDType();
            creditNote.CustomizationID.Value = "2.0";


            //numeracion conformado por serie correlativo
            creditNote.ID = new IDType();

            creditNote.ID.Value = item.Serie.Serial + "-" + item.NroComprobante.ToString("00000000");

            //fecha de emision y hora de emision
            creditNote.IssueDate = new IssueDateType();
            creditNote.IssueDate.Value = item.FechaHoraEmision;

            creditNote.IssueTime = new IssueTimeType();
            creditNote.IssueTime.Value = Convert.ToDateTime(String.Format("{0}:{1}:{2}", item.FechaHoraEmision.Hour, item.FechaHoraEmision.Minute, item.FechaHoraEmision.Second));

            NoteType[] Leyendas = new NoteType[1];
            NoteType Leyenda = new NoteType();

            Leyenda.languageLocaleID = "1000";
            Leyenda.Value = item.TotalEnLetras;
            Leyendas[0] = Leyenda;
            creditNote.Note = Leyendas;

            // Tipo de moneda
            DocumentCurrencyCodeType Moneda = new DocumentCurrencyCodeType()
            {
                listAgencyName = "United Nations Economic Commission for Europe",
                listID = "ISO 4217 Alpha",
                listName = "Currency",
                Value = codigoSunatMoneda,
            };

            creditNote.DocumentCurrencyCode = Moneda;

            ResponseType nResponseType = new ResponseType();
            ReferenceIDType nReferenceID = new ReferenceIDType();
            ResponseCodeType nResponseCode = new ResponseCodeType();
            DescriptionType nDescription = new DescriptionType();
            nReferenceID.Value = item.ComprobanteRef.Serie.Serial + "-" + item.ComprobanteRef.NroComprobante.ToString("00000000");
            nResponseCode.Value = item.MotivoNota.CodigoSunat;
            nDescription.Value = item.MotivoNota.Descripcion;


            nResponseType.Description = new DescriptionType[] { nDescription };
            nResponseType.ResponseCode = nResponseCode;
            nResponseType.ReferenceID = nReferenceID;
            creditNote.DiscrepancyResponse = new ResponseType[] { nResponseType };

            //---------------------<!--  Penalidad  -->-----------------------------------'

            BillingReferenceType bill = new BillingReferenceType();

            DocumentReferenceType DocumentR = new DocumentReferenceType();
            IDType CodigoID1 = new IDType();
            DocumentTypeCodeType DocumID1 = new DocumentTypeCodeType();

            CodigoID1.Value = item.ComprobanteRef.Serie.Serial + "-" + item.ComprobanteRef.NroComprobante.ToString("00000000");
            DocumID1.listName = "Tipo de Documento";
            DocumID1.listAgencyName = "PE:SUNAT";
            DocumID1.listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo01";
            DocumID1.Value = item.TipoComprobanteRef.CodigoSunat;//03 boleta // factura 01

            DocumentR.ID = CodigoID1;
            DocumentR.DocumentTypeCode = DocumID1;

            bill.InvoiceDocumentReference = DocumentR;
            creditNote.BillingReference = new BillingReferenceType[] { bill };
            //-------------------------------------------------------------------------------------------

            SignatureType[] Signatur = new SignatureType[2];
            SignatureType Signature = new SignatureType();

            IDType SignatureID = new IDType();

            SignatureID.Value = "SignTINRED";
            Signature.ID = SignatureID;

            PartyType partySign = new PartyType();

            PartyIdentificationType partyIdentification1 = new PartyIdentificationType();
            PartyIdentificationType[] partyIdentifications1 = new PartyIdentificationType[2];

            IDType Ruc_empresa = new IDType();
            Ruc_empresa.Value = rucEmpresa;
            partyIdentification1.ID = Ruc_empresa;
            partyIdentifications1[0] = partyIdentification1;

            partySign.PartyIdentification = partyIdentifications1;

            //NoteType Nota = new NoteType();
            //NoteType[] Notas = new NoteType[2];
            //Nota.Value = "Elaborado por ConsultingDev";
            //Notas[0] = Nota;
            //Signature.Note = Notas;

            PartyNameType partyName = new PartyNameType();
            PartyNameType[] partyNames = new PartyNameType[2];

            NameType1 Razonsocialfirma = new NameType1();
            Razonsocialfirma.Value = razonSocialEmpresa;
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
            creditNote.Signature = Signatur;

            //<----------------------------Datos de la empresa ------------------------------>
            //Nombre Comercial del emisor
            //Apellidos y nombres, denominación o razón social del emisor
            //Tipo y Número de RUC del emisor
            //Código del domicilio fiscal o de local anexo del emisor

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
                Value = rucEmpresa,

            };


            PartyIdentification.ID = idEmpresa;
            PartyIdentifications[0] = PartyIdentification;
            party.PartyIdentification = PartyIdentifications;

            PartyNameType partyname2 = new PartyNameType();
            PartyNameType[] partynames2 = new PartyNameType[2];
            NameType1 nameEmisor = new NameType1();

            nameEmisor.Value = razonSocialEmpresa; //"PRONTO MODA SAC";
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
            creditNote.AccountingSupplierParty = Empresa;


            //'DATOS DEL CLIENTE
            //'Tipo y numero de documento de identidad del adquiriente o usuario
            //'apellidos y nombres, denominacion o razon social


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

            creditNote.AccountingCustomerParty = CustomerPartyCliente;

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

            idtotal.schemeAgencyName = "PE:SUNAT";
            idtotal.schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo05";
            idtotal.schemeName = "Codigo de tributos";

            idtotal.Value = "1000";
            NameType1 uName = new NameType1();
            uName.Value = "IGV";
            TaxTypeCodeType uTaxTypeCode = new TaxTypeCodeType();
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
            creditNote.TaxTotal = taxtotals;

            //< !----------------Inicio Tributos cabecera ----------------------->

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
            //totalvalorventa.ChargeTotalAmount = MtoTotalOtrosCargos;
            // totalvalorventa.PrepaidAmount = MtoCargos;
            totalvalorventa.PayableAmount = importetotalventa;
            creditNote.LegalMonetaryTotal = totalvalorventa;

            //<!-----------------------Fin--Tributos--Cabecera ------------------->


            //Numero de orden del item
            //cantidad y unidad de medida por item
            //valor de venta del item
            //items de factura
            //   DataTable tableDetalle = new DataTable("ParentTable");

            int contador = item.ListaNotaCreditoDetalle.Count + 1;

            CreditNoteLineType[] items = new CreditNoteLineType[contador];

            int iditemnumero = 0;


            foreach (var detalle in item.ListaNotaCreditoDetalle)
            {

                iditemnumero++;

                //ModuloDoc.codigoItems = "NIU";// DetalleRow[0].ToString();// UNIDAD DE MEDIDA 
                //                              //string ClaveUnidadItems = DetalleRow[7].ToString();//CODIGO DEL SUNAT
                //ModuloDoc.DescripcionItems = DetalleRow[4].ToString();//
                //ModuloDoc.CantidadItems = Convert.ToDecimal(string.Format("{0:0.00}", DetalleRow[9]));//CANTIDAD
                //ModuloDoc.PrecioUnitarioItems = Convert.ToDecimal(string.Format("{0:0.00}", DetalleRow[12])); //PRECIO UNITARIO
                //ModuloDoc.DescuentoItems = Convert.ToDecimal(string.Format("{0:0.00}", DetalleRow[17]));// DESCUENTO
                //ModuloDoc.ImporteTotalDetalle = Convert.ToDecimal(string.Format("{0:0.00}", DetalleRow[21]));//IMPORTE
                //ModuloDoc.PrecioIgv = Convert.ToDecimal(string.Format("{0:0.00}", DetalleRow[14]));//IGV


                CreditNoteLineType creditNoteLine = new CreditNoteLineType();

                IDType NumeroItem = new IDType();
                NumeroItem.Value = Convert.ToString(iditemnumero);
                creditNoteLine.ID = NumeroItem;

                CreditedQuantityType cantidad = new CreditedQuantityType();

                cantidad.unitCode = detalle.UnidadMedida.CodigoSunat;
                cantidad.unitCodeListAgencyName = "United Nations Economic Commission for Europe";
                cantidad.unitCodeListAgencyID = "UN/ECE rec 20";
                cantidad.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.Cantidad));
                creditNoteLine.CreditedQuantity = cantidad;

                LineExtensionAmountType valorventa = new LineExtensionAmountType();
                valorventa.currencyID = codigoSunatMoneda; //tipo de moneda
                valorventa.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.PrecioUnitario));
                creditNoteLine.LineExtensionAmount = valorventa;

                //Precio de venta unitario por item y codigo
                PricingReferenceType ValorReferenUnitario = new PricingReferenceType();

                PriceType[] TipoPrecios = new PriceType[2];
                PriceType TipoPrecio = new PriceType();

                PriceAmountType PrecioMonto = new PriceAmountType();
                PrecioMonto.currencyID = codigoSunatMoneda;


                PrecioMonto.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.Importe));

                TipoPrecio.PriceAmount = PrecioMonto;

                PriceTypeCodeType TipoPrecioCode = new PriceTypeCodeType();
                TipoPrecioCode.Value = "01";

                TipoPrecio.PriceTypeCode = TipoPrecioCode;
                TipoPrecios[0] = TipoPrecio;
                ValorReferenUnitario.AlternativeConditionPrice = TipoPrecios;
                creditNoteLine.PricingReference = ValorReferenUnitario;


                //-------------------------------descuento-por-items-------------------------------------------'

                //  AllowanceChargeType Allowancecharge = new AllowanceChargeType();
                //  AllowanceChargeType[] Allowancecharges = new AllowanceChargeType[0];

                //  Allowancecharges[0] = Allowancecharge;
                //  CreditNoteLine.AllowanceCharge = Allowancecharges;

                //  ChargeIndicatorType ChargeIndicator = new ChargeIndicatorType();
                //  ChargeIndicator.Value = false;
                //  Allowancecharge.ChargeIndicator = ChargeIndicator;


                //  AllowanceChargeReasonCodeType AllowanceChargeReasonCode = new AllowanceChargeReasonCodeType();


                //  AllowanceChargeReasonCode.Value = "00"; //
                //  Allowancecharge.AllowanceChargeReasonCode = AllowanceChargeReasonCode;


                //AmountType2 nAmount = new AmountType2();
                //nAmount.currencyID = codigoSunatMoneda;
                //nAmount.Value = Convert.ToDecimal(string.Format("{0:0.00}", 0.00));  // - descuento
                //Allowancecharge.Amount = nAmount;

                //BaseAmountType nBaseAmount = new BaseAmountType();
                //nBaseAmount.currencyID = codigoSunatMoneda;
                //nBaseAmount.Value = Convert.ToDecimal(string.Format("{0:0.00}", 0.00)); // - Precio
                //Allowancecharge.BaseAmount = nBaseAmount;

                //CreditNoteLine.AllowanceCharge = new AllowanceChargeType[] { Allowancecharge };
                //-----------------------------------fin descuanto-por-items---------------------------------'

                // TOTAL IGV

                //<!--  Inicio Tributos  -->

                TaxTotalType[] totales_items = new TaxTotalType[2];
                TaxTotalType totales_item = new TaxTotalType();

                TaxAmountType total_item = new TaxAmountType();
                total_item.currencyID = codigoSunatMoneda;// tipo de Moneda
                total_item.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.Igv));//* 0.18 '
                totales_item.TaxAmount = total_item;

                TaxSubtotalType[] subtotal_items = new TaxSubtotalType[2];
                TaxSubtotalType subtotal_item = new TaxSubtotalType();

                TaxableAmountType taxsubtotal_IGVItem = new TaxableAmountType();
                taxsubtotal_IGVItem.currencyID = codigoSunatMoneda;
                taxsubtotal_IGVItem.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.ValorVenta));//
                subtotal_item.TaxableAmount = taxsubtotal_IGVItem;

                TaxAmountType totaltaxamount_IGVItem = new TaxAmountType();
                totaltaxamount_IGVItem.currencyID = codigoSunatMoneda;
                totaltaxamount_IGVItem.Value = Convert.ToDecimal(string.Format("{0:0.00}", detalle.Igv)); // * 0.18 '
                subtotal_item.TaxAmount = totaltaxamount_IGVItem;

                subtotal_items[0] = subtotal_item;
                totales_item.TaxSubtotal = subtotal_items;

                TaxCategoryType taxCategory_IGVItem = new TaxCategoryType();
                PercentType1 porcentaje = new PercentType1();
                porcentaje.Value = 18.00M;
                taxCategory_IGVItem.Percent = porcentaje;

                subtotal_item.TaxCategory = taxCategory_IGVItem;

                TaxSchemeType taxScheme_IGVItem = new TaxSchemeType();
                IDType id2_IGVItem = new IDType();


                id2_IGVItem.schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo05";
                id2_IGVItem.schemeName = "Codigo de tributos";
                id2_IGVItem.schemeAgencyName = "PE:SUNAT";
                id2_IGVItem.Value = "1000";
                taxScheme_IGVItem.ID = id2_IGVItem;

                NameType1 nombreImpto_IGVItem = new NameType1();
                nombreImpto_IGVItem.Value = "IGV";
                taxScheme_IGVItem.Name = nombreImpto_IGVItem;

                TaxTypeCodeType nombreImpto_IGVIteminter = new TaxTypeCodeType();
                nombreImpto_IGVIteminter.Value = "VAT";
                taxScheme_IGVItem.TaxTypeCode = nombreImpto_IGVIteminter;
                taxScheme_IGVItem.Name = nombreImpto_IGVItem;
                // tipo de impuesto
                TaxExemptionReasonCodeType CodRazon_IGVItem = new TaxExemptionReasonCodeType();
                CodRazon_IGVItem.listName = "Afectacion del IGV";
                CodRazon_IGVItem.listAgencyName = "PE:SUNAT";
                CodRazon_IGVItem.listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo07";
                CodRazon_IGVItem.Value = "10";

                taxCategory_IGVItem.TaxExemptionReasonCode = CodRazon_IGVItem;
                taxCategory_IGVItem.TaxScheme = taxScheme_IGVItem;
                subtotal_item.TaxableAmount = taxsubtotal_IGVItem;

                subtotal_item.TaxCategory = taxCategory_IGVItem;
                subtotal_item.TaxAmount = totaltaxamount_IGVItem;

                subtotal_items[0] = subtotal_item;
                totales_item.TaxSubtotal = subtotal_items;
                totales_items[0] = totales_item;
                creditNoteLine.TaxTotal = totales_items;

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
                iD.Value = "00601";

                itemIdentification.ID = iD;
                itemTipo.SellersItemIdentification = itemIdentification;

                creditNoteLine.Item = itemTipo;
                creditNoteLine.Price = PrecioProducto;


                items[Convert.ToInt32(iditemnumero)] = creditNoteLine;

            }

            creditNote.CreditNoteLine = items;

            archivoXML = GenerarComprobanteNotaCredito(ref creditNote, rucEmpresa, codigoSunatTipoComprobante, item.Serie.Serial, item.NroComprobante.ToString("00000000"));


        }

        public string GenerarComprobanteNotaCredito(ref CreditNoteType FactXML, string EmpresaRuc, string TipoFactura, string Fac_serie, string NumFactura)
        {
            XmlSerializer nXmlSerializer = new XmlSerializer(typeof(CreditNoteType));
            XmlWriter xtWriter;
            XmlWriterSettings setting = new XmlWriterSettings();
            setting.Indent = true;
            setting.IndentChars = "\t";
            string RutaDocumento = Path.Combine(configuracionValor.RutaFacturacionElectronica, "NOTA CREDITO");

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

                string Ruta_descomprimir = @"D:\FACTURA ELECTRONICA\DESCOMPRIMIR\";
                string descomprimir = Ruta_descomprimir + Path.GetFileName(fs.Name).Replace(".zip", "");
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

                //  ModuloDoc.ResultadoQR = ModuloDoc.RucEmpresa + " | " + ModuloDoc.codigoTipoDoc + " | " + ModuloDoc.Serie + "-" + ModuloDoc.numeroFactura + " | " + ModuloDoc.MontPrecTotal * 0.18M + " | " + ModuloDoc.MontPrecTotal + " | " + DateTime.Now.ToString("dd/mm/yyyy") + " | " + "6" + " | " + ModuloDoc.RucCliente + " | " + ModuloDoc.Codigohas + " | ";

                //ACTUALIZAR Codigo hast

                //registro.Hash = ModuloDoc.Codigohas;
                //  NotaCreditoBe.ModificarHast(registro);
                //BuscarNotasDebitoVenta();

                //MessageBox.Show("Resultado: " + ModuloDoc.Descripcion + " " + ModuloDoc.ResponseCode, "Aviso para el usuario");

            }
            catch (System.ServiceModel.FaultException ex)

            {

                MessageBox.Show(ex.Code.Name + " " + ex.Message, "Advertecia", MessageBoxButtons.OK);
            }

        }
    }
}
