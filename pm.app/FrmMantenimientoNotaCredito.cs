using pm.be;
using pm.bl;
using pm.enums;
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

        public FrmMantenimientoNotaCredito(int? codigoNotaCredito = null, dynamic comprobanteRef = null, TipoComprobante? tipoComprobante = null)
        {
            InitializeComponent();
            this.codigoNotaCredito = codigoNotaCredito;
            this.comprobanteRef = comprobanteRef;
            this.tipoComprobante = tipoComprobante;
        }

        private void FrmMantenimientoNotaCredito_Load(object sender, EventArgs e)
        {
            Text = !codigoNotaCredito.HasValue ? "Nueva Nota de Crédito" + (comprobanteRef == null ? "" : $" - {tipoComprobante.GetAttributeOfType<DescriptionAttribute>().Description} {comprobanteRef.Serie.Serial} - {comprobanteRef.NroComprobante.ToString("00000000")}") : "Modificar Nota de Crédito";
            ListarCombos();
            dgvDetalle.AutoGenerateColumns = false;
            if (codigoNotaCredito.HasValue)
            {
                CargarNotaCredito();
            }
            else CalcularTotales();
            CargarComprobanteRef();
            HabilitarModificarYEliminar();
        }

        void CargarNotaCredito()
        {
            NotaCreditoBe item = notaCreditoBl.ObtenerNotaCredito(codigoNotaCredito.Value, true);

            dtpFechaHoraEmision.Value = item.FechaHoraEmision;
            cbbCodigoSerie.SelectedValue = item.CodigoSerie;
            txtNroComprobante.Text = item.NroComprobante.ToString("00000000");
            cbbCodigoMoneda.SelectedValue = item.CodigoMoneda.ToString();

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
                dynamic comprobante = tipoComprobanteRef == TipoComprobante.Factura ? (dynamic)facturaVentaBl.ObtenerFacturaVenta(codigoComprobante.Value, true) : tipoComprobanteRef == TipoComprobante.Boleta ? (dynamic)boletaVentaBl.ObtenerBoletaVenta(codigoComprobante.Value, true) : null;
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
            registro.CodigoComprobanteRef = tipoComprobante.Value == TipoComprobante.Boleta ? comprobanteRef.CodigoBoletaVenta : tipoComprobante.Value == TipoComprobante.Factura ? comprobanteRef.CodigoFacturaVenta : 0;
            registro.FechaHoraEmision = dtpFechaHoraEmision.Value;
            registro.CodigoSerie = (int)cbbCodigoSerie.SelectedValue;
            registro.NroComprobante = int.Parse(string.IsNullOrEmpty(txtNroComprobante.Text.Trim()) ? "0" : txtNroComprobante.Text.Trim());
            registro.CodigoMoneda = int.Parse(cbbCodigoMoneda.SelectedValue.ToString());
            registro.CodigoMotivoNota = (int)cbbCodigoMotivoNota.SelectedValue;
            registro.CodigoCliente = codigoCliente.Value;
            registro.DireccionCliente = txtDireccionCliente.Text.Trim();
            registro.NombrePaisCliente = nombrePaisCliente;
            registro.NombreDepartamentoCliente = nombreDepartamentoCliente;
            registro.NombreProvinciaCliente = nombreProvinciaCliente;
            registro.NombreDistritoCliente = nombreDistritoCliente;
            registro.CodigoDistritoCliente = codigoDistritoCliente.Value;
            registro.ListaNotaCreditoDetalle = listaDetalle;
            registro.ListaNotaCreditoDetalleEliminar = listaDetalleInicial == null ? null : listaDetalleInicial.Where(x => listaDetalle.Count(y => y.CodigoNotaCreditoDetalle == x.CodigoNotaCreditoDetalle) == 0).Select(x => x.CodigoNotaCreditoDetalle).ToArray();
            registro.TotalValorVenta = listaDetalle.Sum(x => x.ValorVenta);
            registro.TotalPrecioVenta = listaDetalle.Sum(x => x.PrecioVenta);
            registro.TotalPorcentajeDescuentoGlobal = 0;
            registro.TotalDescuentoGlobal = 0;
            registro.TotalDescuentoDetallado = listaDetalle.Sum(x => x.Descuento);
            registro.TotalIgv = listaDetalle.Sum(x => x.Igv);
            registro.TotalBaseImponible = listaDetalle.Sum(x => x.BaseImponible);
            registro.TotalImporte = listaDetalle.Sum(x => x.Importe);

            bool seGuardoRegistro = notaCreditoBl.GuardarNotaCredito(registro);

            if (seGuardoRegistro)
            {
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
    }
}
