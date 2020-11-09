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
    public partial class FrmMantenimientoCotizacionDetalle : RadForm
    {
        public List<CotizacionDetalleBe> ListaDetalleInicial { get; set; }
        public List<CotizacionDetalleBe> ListaDetalleActual { get; set; }
        CotizacionDetalleBe _Detalle;
        public CotizacionDetalleBe Detalle { get { return _Detalle; } }
        int? codigoProducto, codigoProductoIndividual;
        string codigoBarraProductoIndividual;

        UnidadMedidaBl unidadMedidaBl = new UnidadMedidaBl();
        ProductoBl productoBl = new ProductoBl();
        ProductoIndividualBl productoIndividualBl = new ProductoIndividualBl();
        ControlBusquedaBl controlBusquedaBl = new ControlBusquedaBl();

        public FrmMantenimientoCotizacionDetalle(CotizacionDetalleBe item = null)
        {
            InitializeComponent();
            _Detalle = item;
        }

        private void FrmMantenimientoCotizacionDetalle_Load(object sender, EventArgs e)
        {
            Text = Detalle == null ? "Agregar Registro" : "Modificar Registro";
            ListarCombos();
            if (Detalle != null)
            {
                CargarCotizacionDetalle();
            }
        }

        void CargarCotizacionDetalle()
        {
            CargarProducto(Detalle.CodigoProducto);
            CargarProductoIndividual(Detalle.CodigoProductoIndividual);
            cbbCodigoUnidadMedida.SelectedValue = Detalle.CodigoUnidadMedida;
            txtCantidad.Text = Detalle.Cantidad.ToString("0.00");

            txtPrecioUnitario.Text = Detalle.PrecioUnitario.ToString("0.00");

            txtImporteTotal.Text = Detalle.Importe.ToString("0.00");
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

        void CargarProductoIndividual(int? codigoProductoIndividual)
        {
            ProductoIndividualBe productoIndividual = codigoProductoIndividual == null ? null : productoIndividualBl.ObtenerProductoIndividual(codigoProductoIndividual.Value);
            if (productoIndividual != null)
            {
                if (productoIndividual.CodigoProducto != codigoProducto) CargarProducto(productoIndividual.CodigoProducto);
                this.codigoProductoIndividual = productoIndividual.CodigoProductoIndividual;
                this.codigoBarraProductoIndividual = productoIndividual.CodigoBarra;
                txtCodigoBarraProductoIndividual.Text = productoIndividual.CodigoBarra;
                txtNombreProductoIndividual.Text = productoIndividual.Nombre;
                cbbCodigoUnidadMedida.SelectedValue = productoIndividual.CodigoUnidadMedida;
                txtCantidad.Text = productoIndividual.Metraje.ToString("0.00");
                txtPrecioUnitario.Text = (productoIndividual.PrecioVenta / productoIndividual.Metraje).ToString("0.00");
                Calculo();
            }
            else
            {
                this.codigoProductoIndividual = null;
                txtCodigoBarraProductoIndividual.Text = "";
                txtNombreProductoIndividual.Text = "";
                txtCantidad.Text = "0.00";
            }
        }

        void ListarCombos()
        {
            ListarComboUnidadMedida();
        }

        void ListarComboUnidadMedida()
        {
            List<UnidadMedidaBe> listaCombo = unidadMedidaBl.ListarComboUnidadMedida();
            listaCombo = listaCombo ?? new List<UnidadMedidaBe>();
            listaCombo.Insert(0, new UnidadMedidaBe { CodigoUnidadMedida = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoUnidadMedida.DataSource = null;
            cbbCodigoUnidadMedida.DataSource = listaCombo.Select(x => x).ToList();
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

        private void btnBuscarProductoIndividual_Click(object sender, EventArgs e)
        {
            if ((codigoBarraProductoIndividual ?? "") == txtCodigoBarraProductoIndividual.Text.Trim() && codigoBarraProductoIndividual != null) return;
            if (txtCodigoBarraProductoIndividual.Text.Trim() == "") CargarProductoIndividual(null);
            string formulario = this.GetType().FullName;
            string control = ((Control)sender).Name;
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, control, true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarProductoIndividual(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarProductoIndividual(resultado.CodigoProductoIndividual);
            }
        }

        void Calculo()
        {
            decimal cantidad = 0, precioUnitario = 0, totalImporte = 0;

            decimal.TryParse(txtCantidad.Text.Trim(), out cantidad);
            decimal.TryParse(txtPrecioUnitario.Text.Trim(), out precioUnitario);
            totalImporte = precioUnitario * cantidad;

            txtCantidad.Text = cantidad.ToString("0.00");
            txtPrecioUnitario.Text = precioUnitario.ToString("0.00");
            txtImporteTotal.Text = totalImporte.ToString("0.00");
        }

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            Calculo();
        }

        private void txtPrecioUnitario_Validated(object sender, EventArgs e)
        {
            Calculo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            _Detalle = _Detalle ?? new CotizacionDetalleBe();

            //_Detalle.CodigoCotizacionDetalle = 0;
            _Detalle.Detalle = codigoProductoIndividual.HasValue ? txtNombreProductoIndividual.Text.Trim() : txtNombreProducto.Text.Trim();
            _Detalle.CodigoProducto = codigoProducto.Value;
            _Detalle.Producto = new ProductoBe { Nombre = txtNombreProducto.Text.Trim() };
            _Detalle.CodigoProductoIndividual = codigoProductoIndividual.Value;
            _Detalle.ProductoIndividual = new ProductoIndividualBe { Nombre = txtNombreProductoIndividual.Text.Trim() };
            _Detalle.CodigoUnidadMedida = (int)cbbCodigoUnidadMedida.SelectedValue;
            _Detalle.Cantidad = decimal.Parse(txtCantidad.Text.Trim());
            _Detalle.PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text.Trim());
            _Detalle.Importe = decimal.Parse(txtImporteTotal.Text.Trim());

            DialogResult = DialogResult.OK;
            Close();
        }

        void LimpiarErrores()
        {
            lblErrorProducto.Text = "";
            lblErrorProductoIndividual.Text = "";
            lblErrorCantidad.Text = "";
            lblErrorPrecioUnitario.Text = "";
            lblErrorImporteTotal.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (codigoProducto == null)
            {
                estaValidado = false;
                lblErrorProducto.Text = "Debe seleccionar producto";
                SetToolTipError(lblErrorProducto);
            }

            if (codigoProductoIndividual == null)
            {
                estaValidado = false;
                lblErrorProductoIndividual.Text = "Debe seleccionar producto individual";
                SetToolTipError(lblErrorProductoIndividual);
            }
            else
            {
                ListaDetalleActual = ListaDetalleActual ?? new List<CotizacionDetalleBe>();

                int? codigoCotizacionDetalle = Detalle == null ? null : (int?)Detalle.CodigoCotizacionDetalle;

                bool existeProductoIndividual = ListaDetalleActual.Count(x => x.CodigoProductoIndividual == codigoProductoIndividual && x.CodigoCotizacionDetalle != codigoCotizacionDetalle) > 0;

                if (existeProductoIndividual)
                {
                    estaValidado = false;
                    lblErrorProductoIndividual.Text = $"El producto individual seleccionado ya existe";
                    SetToolTipError(lblErrorProductoIndividual);
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
                decimal cantidad = 0;

                if (!decimal.TryParse(txtCantidad.Text.Trim(), out cantidad))
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

        void SetToolTipError(Label label)
        {
            tltCotizacionDetalle.SetToolTip(label, label.Text);
        }
    }
}
