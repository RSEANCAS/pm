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
    public partial class FrmMantenimientoComprobanteCompraDetalle : RadForm
    {
        public List<ComprobanteCompraDetalleBe> ListaDetalleInicial { get; set; }
        public List<ComprobanteCompraDetalleBe> ListaDetalleActual { get; set; }
        ComprobanteCompraDetalleBe _Detalle;
        public ComprobanteCompraDetalleBe Detalle { get { return _Detalle; } }
        int? codigoProducto;

        int? cantidadUnidadesRegistradas;

        UnidadMedidaBl unidadMedidaBl = new UnidadMedidaBl();

        ProductoBl productoBl = new ProductoBl();
        ProductoIndividualBl productoIndividualBl = new ProductoIndividualBl();
        ControlBusquedaBl controlBusquedaBl = new ControlBusquedaBl();

        public FrmMantenimientoComprobanteCompraDetalle(ComprobanteCompraDetalleBe item = null, int? cantidadUnidadesRegistradas = null)
        {
            InitializeComponent();
            _Detalle = item;
            this.cantidadUnidadesRegistradas = cantidadUnidadesRegistradas;
        }

        private void FrmMantenimientoComprobanteCompraDetalle_Load(object sender, EventArgs e)
        {
            Text = Detalle == null ? "Agregar Registro" : "Modificar Registro";
            if (Detalle != null)
            {
                CargarComprobanteCompraDetalle();
            }
        }

        void CargarComprobanteCompraDetalle()
        {
            CargarProducto(Detalle.CodigoProducto);
            txtCantidad.Text = Detalle.Cantidad.ToString();
            txtPrecioUnitario.Text = Detalle.PrecioUnitario.ToString("0.00");
            txtImporteTotal.Text = Detalle.ImporteTotal.ToString("0.00");
        }

        void CargarProducto(int? codigoProducto)
        {
            ProductoBe producto = codigoProducto == null ? null : productoBl.ObtenerProducto(codigoProducto.Value);
            if (producto != null)
            {
                this.codigoProducto = producto.CodigoProducto;
                txtNombreProducto.Text = producto.Nombre;
            }
            else
            {
                this.codigoProducto = null;
                txtNombreProducto.Text = "";
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string formulario = this.GetType().FullName;
            string control = ((Control)sender).Name;
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, control, true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarProducto(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarProducto(resultado.CodigoProducto);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            _Detalle = _Detalle ?? new ComprobanteCompraDetalleBe();

            //_Detalle.CodigoComprobanteCompraDetalle = 0;
            _Detalle.CodigoProducto = !codigoProducto.HasValue ? 0 : codigoProducto.Value;
            _Detalle.Detalle = txtNombreProducto.Text.Trim();
            _Detalle.Cantidad = int.Parse(txtCantidad.Text.Trim());
            _Detalle.PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text.Trim());
            _Detalle.ImporteTotal = decimal.Parse(txtImporteTotal.Text.Trim());

            DialogResult = DialogResult.OK;
            Close();
        }

        void LimpiarErrores()
        {
            lblErrorProducto.Text = "";
            lblErrorCantidad.Text = "";
            lblErrorPrecioUnitario.Text = "";
            lblErrorImporteTotal.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (!codigoProducto.HasValue)
            {
                estaValidado = false;
                lblErrorProducto.Text = "Debe seleccionar producto";
                SetToolTipError(lblErrorProducto);
            }
            else
            {
                bool existeProducto = ListaDetalleActual.Exists(x => x.CodigoProducto == codigoProducto && (x.CodigoComprobanteCompraDetalle != (_Detalle ?? new ComprobanteCompraDetalleBe()).CodigoComprobanteCompraDetalle));

                if (existeProducto)
                {
                    estaValidado = false;
                    lblErrorProducto.Text = $"El producto seleccionado ya existe";
                    SetToolTipError(lblErrorProducto);
                }
            }

            if (string.IsNullOrEmpty(txtCantidad.Text.Trim()))
            {
                estaValidado = false;
                lblErrorCantidad.Text = "Debe ingresar cantidad";
                SetToolTipError(lblErrorCantidad);
            }
            else
            {
                int cantidad = 0;

                if (!int.TryParse(txtCantidad.Text.Trim(), out cantidad))
                {
                    estaValidado = false;
                    lblErrorCantidad.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorCantidad);
                }
                else
                {
                    if (cantidadUnidadesRegistradas.HasValue)
                    {
                        if (cantidadUnidadesRegistradas > 0 && cantidad > cantidadUnidadesRegistradas)
                        {
                            estaValidado = false;
                            lblErrorCantidad.Text = $"Ya existen {cantidadUnidadesRegistradas} unidades registradas";
                            SetToolTipError(lblErrorCantidad);
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(txtPrecioUnitario.Text.Trim()))
            {
                estaValidado = false;
                lblErrorPrecioUnitario.Text = "Debe ingresar precio unitario";
                SetToolTipError(lblErrorPrecioUnitario);
            }
            else
            {
                decimal precioUnitario = 0;

                if (!decimal.TryParse(txtPrecioUnitario.Text.Trim(), out precioUnitario))
                {
                    estaValidado = false;
                    lblErrorPrecioUnitario.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorPrecioUnitario);
                }
            }

            if (string.IsNullOrEmpty(txtImporteTotal.Text.Trim()))
            {
                estaValidado = false;
                lblErrorImporteTotal.Text = "Debe ingresar importe total";
                SetToolTipError(lblErrorImporteTotal);
            }
            else
            {
                decimal importeTotal = 0;

                if (!decimal.TryParse(txtImporteTotal.Text.Trim(), out importeTotal))
                {
                    estaValidado = false;
                    lblErrorImporteTotal.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorImporteTotal);
                }
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltComprobanteCompraDetalle.SetToolTip(label, label.Text);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularImporteTotal();
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            CalcularImporteTotal();
        }

        bool ValidarCamposCalculoImporteTotal()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (string.IsNullOrEmpty(txtCantidad.Text.Trim()))
            {
                estaValidado = false;
                lblErrorCantidad.Text = "Debe ingresar cantidad";
                SetToolTipError(lblErrorCantidad);
            }
            else
            {
                int cantidad = 0;

                if (!int.TryParse(txtCantidad.Text.Trim(), out cantidad))
                {
                    estaValidado = false;
                    lblErrorCantidad.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorCantidad);
                }
            }

            if (string.IsNullOrEmpty(txtPrecioUnitario.Text.Trim()))
            {
                estaValidado = false;
                lblErrorPrecioUnitario.Text = "Debe ingresar precio unitario";
                SetToolTipError(lblErrorPrecioUnitario);
            }
            else
            {
                decimal precioUnitario = 0;

                if (!decimal.TryParse(txtPrecioUnitario.Text.Trim(), out precioUnitario))
                {
                    estaValidado = false;
                    lblErrorPrecioUnitario.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorPrecioUnitario);
                }
            }

            return estaValidado;
        }

        void CalcularImporteTotal()
        {
            bool estaValidado = ValidarCamposCalculoImporteTotal();

            if (!estaValidado) return;

            int cantidad = int.Parse(txtCantidad.Text.Trim());
            decimal precioUnitario = decimal.Parse(txtPrecioUnitario.Text.Trim());
            decimal importeTotal = cantidad * precioUnitario;

            txtImporteTotal.Text = importeTotal.ToString("0.00");
        }
    }
}