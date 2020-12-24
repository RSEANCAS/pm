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
    public partial class FrmMantenimientoFacturaVenta : RadForm
    {
        int? codigoFacturaVenta;
        GuiaRemisionBe guiaRemision;

        int? codigoCliente, codigoDistritoCliente;
        string nombrePaisCliente, nombreDepartamentoCliente, nombreProvinciaCliente, nombreDistritoCliente;
        string nroDocumentoIdentidadCliente;
        MetodoPago metodoPago = MetodoPago.Contado;
        int codigoMetodoPago = (int)MetodoPago.Contado;
        List<FacturaVentaDetalleBe> listaDetalleInicial = new List<FacturaVentaDetalleBe>();
        List<FacturaVentaDetalleBe> listaDetalle = new List<FacturaVentaDetalleBe>();
        List<LetraBe> listaLetra = new List<LetraBe>();

        FacturaVentaBl facturaVentaBl = new FacturaVentaBl();
        SerieBl serieBl = new SerieBl();
        TipoDocumentoIdentidadBl tipoDocumentoIdentidadBl = new TipoDocumentoIdentidadBl();
        ClienteBl clienteBl = new ClienteBl();
        ProductoBl productoBl = new ProductoBl();
        ProductoIndividualBl productoIndividualBl = new ProductoIndividualBl();
        UnidadMedidaBl unidadMedidaBl = new UnidadMedidaBl();
        ControlBusquedaBl controlBusquedaBl = new ControlBusquedaBl();

        public FrmMantenimientoFacturaVenta(int? codigoFacturaVenta = null, GuiaRemisionBe guiaRemision = null)
        {
            InitializeComponent();
            this.codigoFacturaVenta = codigoFacturaVenta;
            this.guiaRemision = guiaRemision;
        }

        private void FrmMantenimientoFacturaVenta_Load(object sender, EventArgs e)
        {
            Text = !codigoFacturaVenta.HasValue ? "Nueva Factura de Venta" + (guiaRemision == null ? "" : $" - Guía de Remisión {((TipoComprobante)guiaRemision.CodigoTipoComprobante).GetAttributeOfType<DescriptionAttribute>().Description} {guiaRemision.Serie.Serial} - {guiaRemision.NroComprobante.ToString("00000000")}") : "Modificar Factura de Venta";
            dtpFechaHoraEmision_ValueChanged(dtpFechaHoraEmision, new EventArgs());
            ListarCombos();
            dgvDetalle.AutoGenerateColumns = false;
            if (codigoFacturaVenta.HasValue)
            {
                CargarFacturaVenta();
            }
            else CalcularTotales();
            CargarGuiaRemision();
            HabilitarModificarYEliminar();
        }

        void CargarFacturaVenta()
        {
            FacturaVentaBe item = facturaVentaBl.ObtenerFacturaVenta(codigoFacturaVenta.Value, true, true);

            dtpFechaHoraEmision.Value = item.FechaHoraEmision;
            cbbCodigoSerie.SelectedValue = item.CodigoSerie;
            txtNroComprobante.Text = item.NroComprobante.ToString("00000000");
            dtpFechaHoraVencimiento.MinDate = new DateTime(item.FechaHoraEmision.Year, item.FechaHoraEmision.Month, item.FechaHoraEmision.Day);
            dtpFechaHoraVencimiento.Value = item.FechaHoraVencimiento;
            cbbCodigoMoneda.SelectedValue = item.CodigoMoneda.ToString();
            if (item.CodigoMetodoPago == (int)MetodoPago.Contado) rdbContado.Checked = true;
            else if (item.CodigoMetodoPago == (int)MetodoPago.Credito)
            {
                rdbCredito.Checked = true;
                txtCantidadLetrasCredito.Text = item.CantidadLetrasCredito.ToString();
            }

            codigoCliente = item.CodigoCliente;
            CargarCliente(codigoCliente);

            listaDetalleInicial = item.ListaFacturaVentaDetalle;
            listaDetalle = item.ListaFacturaVentaDetalle;
            listaLetra = item.ListaLetra;
            ListarFacturaVentaDetalle();
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
                    ListarFacturaVentaDetalle();
                }
            }
        }

        void ReCalcularDetalleGuiaRemision()
        {
            void Calculo(FacturaVentaDetalleBe item)
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
                        FacturaVentaDetalleBe itemFactura = new FacturaVentaDetalleBe();
                        itemFactura.CodigoGuiaRemision = item.CodigoGuiaRemision;
                        itemFactura.CodigoGuiaRemisionDetalle = item.CodigoGuiaRemisionDetalle;
                        itemFactura.CodigoCotizacion = cotizacion.CodigoCotizacion;
                        itemFactura.CodigoCotizacionDetalle = item.CodigoCotizacionDetalle;
                        itemFactura.CodigoProducto = item.CodigoProducto;
                        itemFactura.Producto = productoBl.ObtenerProducto(item.CodigoProducto);
                        itemFactura.CodigoProductoIndividual = item.CodigoProductoIndividual;
                        itemFactura.ProductoIndividual = productoIndividualBl.ObtenerProductoIndividual(item.CodigoProductoIndividual);
                        itemFactura.CodigoUnidadMedida = itemFactura.ProductoIndividual.CodigoUnidadMedida;
                        itemFactura.UnidadMedida = unidadMedidaBl.ObtenerUnidadMedida(itemFactura.CodigoUnidadMedida);
                        itemFactura.Detalle = item.Detalle;
                        itemFactura.Cantidad = item.Cantidad;
                        itemFactura.PrecioUnitario = item.CotizacionDetalle.PrecioUnitario;
                        itemFactura.TipoCalculo = (int)TipoCalculo.PrecioUnitario;
                        itemFactura.TipoDescuento = (int)TipoDescuento.Descuento;
                        Calculo(itemFactura);

                        listaDetalle.Add(itemFactura);
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
            List<SerieBe> listaCombo = serieBl.ListarComboSerie((int)TipoComprobante.Factura);
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
            listaCombo = listaCombo.Where(x => x.CodigoTipoDocumentoIdentidad != (int)TipoDocumentoIdentidad.DNI).ToList();
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

        void ListarFacturaVentaDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listaDetalle;
            CalcularTotales();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            FrmMantenimientoFacturaVentaDetalle frm = new FrmMantenimientoFacturaVentaDetalle();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                frm.Detalle.CodigoFacturaVentaDetalle = GenerarCodigoFacturaVentaDetalleTemporal(frm.Detalle.CodigoProductoIndividual);
                listaDetalle.Add(frm.Detalle);
                listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarFacturaVentaDetalle();
            }
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (FacturaVentaDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            FrmMantenimientoFacturaVentaDetalle frm = new FrmMantenimientoFacturaVentaDetalle(item);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                listaDetalle[indexData] = frm.Detalle;
                //listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarFacturaVentaDetalle();
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (FacturaVentaDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                listaDetalle.RemoveAt(indexData);
                ListarFacturaVentaDetalle();
            }
        }

        void CalcularTotales()
        {
            listaDetalle = listaDetalle ?? new List<FacturaVentaDetalleBe>();
            txtTotalBaseImponible.Text = listaDetalle.Sum(x => x.BaseImponible).ToString("#,##0.00");
            txtTotalIgv.Text = listaDetalle.Sum(x => x.Igv).ToString("#,##0.00");
            txtTotalImporte.Text = listaDetalle.Sum(x => x.Importe).ToString("#,##0.00");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            int cantidadLetrasCredito = 0;
            List<LetraBe> listaLetra = null;

            if (metodoPago == MetodoPago.Credito)
            {
                DateTime fechaHoraEmision = dtpFechaHoraEmision.Value;
                cantidadLetrasCredito = int.Parse(txtCantidadLetrasCredito.Text.Trim());
                decimal totalImporte = decimal.Parse(txtTotalImporte.Text.Trim());

                FrmCalculoCronogramaPago frm = new FrmCalculoCronogramaPago(fechaHoraEmision, cantidadLetrasCredito, totalImporte, listaLetra);
                frm.ShowInTaskbar = false;
                frm.BringToFront();
                DialogResult dr = frm.ShowDialog();

                if (dr != DialogResult.Yes) return;

                listaLetra = frm.Lista;
            }

            FacturaVentaBe registro = new FacturaVentaBe();

            if (codigoFacturaVenta.HasValue) registro.CodigoFacturaVenta = codigoFacturaVenta.Value;
            if (guiaRemision != null)
            {
                registro.CodigoGuiaRemision = guiaRemision.CodigoGuiaRemision;
                registro.CodigoCotizacion = guiaRemision.CodigoCotizacion;
            }
            registro.FechaHoraEmision = dtpFechaHoraEmision.Value;
            registro.CodigoSerie = (int)cbbCodigoSerie.SelectedValue;
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
            registro.CodigoMetodoPago = codigoMetodoPago;
            registro.CantidadLetrasCredito = cantidadLetrasCredito;
            registro.ListaFacturaVentaDetalle = listaDetalle;
            registro.ListaFacturaVentaDetalleEliminar = listaDetalleInicial == null ? null : listaDetalleInicial.Where(x => listaDetalle.Count(y => y.CodigoFacturaVentaDetalle == x.CodigoFacturaVentaDetalle) == 0).Select(x => x.CodigoFacturaVentaDetalle).ToArray();
            registro.TotalValorVenta = listaDetalle.Sum(x => x.ValorVenta);
            registro.TotalPrecioVenta = listaDetalle.Sum(x => x.PrecioVenta);
            registro.TotalPorcentajeDescuentoGlobal = 0;
            registro.TotalDescuentoGlobal = 0;
            registro.TotalDescuentoDetallado = listaDetalle.Sum(x => x.Descuento);
            registro.TotalIgv = listaDetalle.Sum(x => x.Igv);
            registro.TotalBaseImponible = listaDetalle.Sum(x => x.BaseImponible);
            registro.TotalImporte = listaDetalle.Sum(x => x.Importe);
            registro.ListaLetra = listaLetra;

            bool seGuardoRegistro = facturaVentaBl.GuardarFacturaVenta(registro);

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

            if ((listaDetalle ?? new List<FacturaVentaDetalleBe>()).Count == 0)
            {
                estaValidado = false;
                lblErrorDetalle.Text = "No tiene registros de detalle";
                SetToolTipError(lblErrorDetalle);
            }

            return estaValidado;
        }

        private void rdbContado_CheckedChanged(object sender, EventArgs e)
        {
            metodoPago = MetodoPago.Contado;
            codigoMetodoPago = (int)MetodoPago.Contado;
            txtCantidadLetrasCredito.ReadOnly = true;
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            metodoPago = MetodoPago.Credito;
            codigoMetodoPago = (int)MetodoPago.Credito;
            txtCantidadLetrasCredito.ReadOnly = false;
        }

        void SetToolTipError(Label label)
        {
            tltFacturaVenta.SetToolTip(label, label.Text);
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

        int GenerarCodigoFacturaVentaDetalleTemporal(int codigoProductoIndividual)
        {
            int codigoFacturaVentaDetalle = 0;
            listaDetalleInicial = listaDetalleInicial ?? new List<FacturaVentaDetalleBe>();
            var registro = listaDetalleInicial.FirstOrDefault(x => x.CodigoProductoIndividual == codigoProductoIndividual);
            listaDetalle = listaDetalle ?? new List<FacturaVentaDetalleBe>();
            if (registro == null) codigoFacturaVentaDetalle = listaDetalle.Select(x => x.CodigoFacturaVentaDetalle).DefaultIfEmpty().Min() - 1;
            else codigoFacturaVentaDetalle = registro.CodigoFacturaVentaDetalle;
            return codigoFacturaVentaDetalle;
        }
    }
}
