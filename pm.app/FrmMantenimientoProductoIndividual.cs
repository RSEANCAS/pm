using log4net.Repository.Hierarchy;
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
    public partial class FrmMantenimientoProductoIndividual : RadForm
    {
        public int? codigoProductoIndividual { get; set; }
        int? codigoProducto;
        int? codigoProductoIndividualInicial;
        string codigoBarraProductoIndividualInicial;
        int? codigoProveedor;
        string nroDocumentoIdentidadProveedor;
        int? codigoPersonalInspeccion;
        string nroDocumentoIdentidadPersonalInspeccion;

        ComprobanteCompraDetalleBe comprobanteCompraDetalle;

        UnidadMedidaBl unidadMedidaBl = new UnidadMedidaBl();
        ProductoIndividualBl productoIndividualBl = new ProductoIndividualBl();
        ProductoBl productoBl = new ProductoBl();
        ProveedorBl proveedorBl = new ProveedorBl();
        PersonalBl personalBl = new PersonalBl();
        ControlBusquedaBl controlBusquedaBl = new ControlBusquedaBl();

        ProductoIndividualBe _ProductoIndividual;
        public ProductoIndividualBe ProductoIndividual { get { return _ProductoIndividual; } }

        public FrmMantenimientoProductoIndividual(int? codigoProductoIndividual = null, ComprobanteCompraDetalleBe comprobanteCompraDetalle = null, ProductoIndividualBe productoIndividual = null)
        {
            InitializeComponent();
            this.codigoProductoIndividual = codigoProductoIndividual;
            this.comprobanteCompraDetalle = comprobanteCompraDetalle;
            _ProductoIndividual = productoIndividual;
        }

        private void FrmMantenimientoProductoIndividual_Load(object sender, EventArgs e)
        {
            Text = !codigoProductoIndividual.HasValue ? "Nuevo Producto Individual" : "Modificar Producto Individual";
            ListarCombos();
            CargarComprobanteCompraDetalle();
            if (codigoProductoIndividual.HasValue)
            {
                CargarProductoIndividual();
            }
        }

        void CargarComprobanteCompraDetalle()
        {
            if(comprobanteCompraDetalle != null)
            {
                txtPrecioCompra.ReadOnly = true;
                txtPrecioCompra.Text = comprobanteCompraDetalle.PrecioUnitario.ToString("0.00");
                txtPrecioVenta.Text = comprobanteCompraDetalle.PrecioUnitario.ToString("0.00");
            }
        }

        void CargarProductoIndividual()
        {
            ProductoIndividualBe item = _ProductoIndividual != null ? _ProductoIndividual : productoIndividualBl.ObtenerProductoIndividual(codigoProductoIndividual.Value);
            txtCodigoBarra.Text = item.CodigoBarra;
            txtNombre.Text = item.Nombre;
            CargarProducto(item.CodigoProducto);
            CargarProductoIndividualInicial(item.CodigoInicial);

            cbbCodigoUnidadMedida.SelectedValue = item.CodigoUnidadMedida;
            txtMetraje.Text = item.Metraje.ToString("0.00");
            cbbCodigoUnidadMedidaPeso.SelectedValue = item.CodigoUnidadMedidaPeso;
            txtPeso.Text = item.Peso.ToString("0.00");
            txtRollo.Text = item.Rollo.ToString("0.00");
            txtBulto.Text = item.Bulto.ToString("0.00");
            txtColor.Text = item.Color;
            dtpFechaEntrada.Value = item.FechaEntrada;
            txtPrecioCompra.ReadOnly = true;
            txtPrecioCompra.Text = !item.PrecioCompra.HasValue ? "0.00" : item.PrecioCompra.Value.ToString("0.00");
            txtPrecioVenta.Text = item.PrecioVenta.ToString("0.00");
            txtCodigoBarraProveedor.Text = item.CodigoBarraProveedor;
            CargarProveedor(item.CodigoProveedor);
            CargarPersonalInspeccion(item.CodigoPersonalInspeccion);
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

        void CargarProductoIndividualInicial(int? codigoProductoIndividualInicial)
        {
            ProductoIndividualBe productoIndividual = codigoProductoIndividualInicial == null ? null : productoIndividualBl.ObtenerProductoIndividual(codigoProductoIndividualInicial.Value);
            if (productoIndividual != null)
            {
                this.codigoProductoIndividualInicial = productoIndividual.CodigoProductoIndividual;
                this.codigoBarraProductoIndividualInicial = productoIndividual.CodigoBarra;
                txtCodigoBarraProductoIndividualInicial.Text = productoIndividual.CodigoBarra;
                txtNombreProductoIndividualInicial.Text = productoIndividual.Nombre;
            }
            else
            {
                this.codigoProductoIndividualInicial = null;
                this.codigoBarraProductoIndividualInicial = null;
                txtCodigoBarraProductoIndividualInicial.Text = "";
                txtNombreProductoIndividualInicial.Text = "";
            }
        }

        void CargarProveedor(int? codigoProveedor)
        {
            ProveedorBe proveedor = codigoProveedor == null ? null : proveedorBl.ObtenerProveedor(codigoProveedor.Value);
            if (proveedor != null)
            {
                this.codigoProveedor = proveedor.CodigoProveedor;
                this.nroDocumentoIdentidadProveedor = proveedor.NroDocumentoIdentidad;
                txtNroDocIdentidadProveedor.Text = proveedor.NroDocumentoIdentidad;
                txtNombresProveedor.Text = proveedor.Nombres;
            }
            else
            {
                this.codigoProveedor = null;
                this.nroDocumentoIdentidadProveedor = null;
                txtNroDocIdentidadProveedor.Text = "";
                txtNombresProveedor.Text = "";
            }
        }

        void CargarPersonalInspeccion(int? codigoPersonalInspeccion)
        {
            PersonalBe personal = codigoPersonalInspeccion == null ? null : personalBl.ObtenerPersonal(codigoPersonalInspeccion.Value);
            if (personal != null)
            {
                this.codigoPersonalInspeccion = personal.CodigoPersonal;
                this.nroDocumentoIdentidadPersonalInspeccion = personal.NroDocumentoIdentidad;
                txtNroDocIdentidadPersonalInspeccion.Text = personal.NroDocumentoIdentidad;
                txtNombresPersonalInspeccion.Text = personal.Nombres;
            }
            else
            {
                this.codigoPersonalInspeccion = null;
                this.nroDocumentoIdentidadPersonalInspeccion = null;
                txtNroDocIdentidadPersonalInspeccion.Text = "";
                txtNombresPersonalInspeccion.Text = "";
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

            cbbCodigoUnidadMedidaPeso.DataSource = null;
            cbbCodigoUnidadMedidaPeso.DataSource = listaCombo.Select(x => x).ToList();
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

        private void btnBuscarProductoInicial_Click(object sender, EventArgs e)
        {
            if ((codigoBarraProductoIndividualInicial ?? "") == txtCodigoBarraProductoIndividualInicial.Text.Trim() && codigoBarraProductoIndividualInicial != null) return;
            if (txtCodigoBarraProductoIndividualInicial.Text.Trim() == "") CargarProductoIndividualInicial(null);
            string formulario = this.GetType().FullName;
            string control = ((Control)sender).Name;
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, control, true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarProductoIndividualInicial(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarProductoIndividualInicial(resultado.CodigoProductoIndividual);
            }
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Count(x => x.Name == "FrmBusquedaSeleccionarRegistro") > 0) return;
            if ((nroDocumentoIdentidadProveedor ?? "") == txtNroDocIdentidadProveedor.Text.Trim() && nroDocumentoIdentidadProveedor != null) return;
            if (txtNroDocIdentidadProveedor.Text.Trim() == "") CargarProveedor(null);
            string formulario = this.GetType().FullName;
            string control = ((Control)sender).Name;
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, control, true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item, txtNroDocIdentidadProveedor.Text.Trim());
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarProveedor(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarProveedor(resultado.CodigoProveedor);
            }
        }

        private void btnBuscarPersonalInspeccion_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Count(x => x.Name == "FrmBusquedaSeleccionarRegistro") > 0) return;
            if ((nroDocumentoIdentidadPersonalInspeccion ?? "") == txtNroDocIdentidadPersonalInspeccion.Text.Trim() && nroDocumentoIdentidadPersonalInspeccion != null) return;
            if (txtNroDocIdentidadPersonalInspeccion.Text.Trim() == "") CargarPersonalInspeccion(null);
            string formulario = this.GetType().FullName;
            string control = ((Control)sender).Name;
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, control, true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item, txtNroDocIdentidadPersonalInspeccion.Text.Trim());
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarPersonalInspeccion(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarPersonalInspeccion(resultado.CodigoPersonal);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            ProductoIndividualBe registro = new ProductoIndividualBe();
            if (this.codigoProductoIndividual.HasValue) registro.CodigoProductoIndividual = this.codigoProductoIndividual.Value;
            registro.CodigoBarra = txtCodigoBarra.Text.Trim();
            registro.Nombre = txtNombre.Text.Trim();
            registro.CodigoProducto = codigoProducto.Value;
            registro.CodigoUnidadMedida = (int)cbbCodigoUnidadMedida.SelectedValue;
            registro.UnidadMedida = new UnidadMedidaBe();
            registro.UnidadMedida.CodigoUnidadMedida = (int)cbbCodigoUnidadMedida.SelectedValue;
            registro.UnidadMedida.Descripcion = cbbCodigoUnidadMedida.Text;
            registro.CodigoInicial = codigoProductoIndividualInicial;
            registro.Metraje = decimal.Parse(txtMetraje.Text.Trim());
            registro.CodigoUnidadMedidaPeso = (int)cbbCodigoUnidadMedidaPeso.SelectedValue;
            registro.UnidadMedidaPeso = new UnidadMedidaBe();
            registro.UnidadMedidaPeso.CodigoUnidadMedida = (int)cbbCodigoUnidadMedidaPeso.SelectedValue;
            registro.UnidadMedidaPeso.Descripcion = cbbCodigoUnidadMedidaPeso.Text;
            registro.Peso = decimal.Parse(txtPeso.Text.Trim());
            registro.Rollo = decimal.Parse(txtRollo.Text.Trim());
            registro.Bulto = decimal.Parse(txtBulto.Text.Trim());
            registro.Color = txtColor.Text.Trim();
            registro.FechaEntrada = dtpFechaEntrada.Value;
            registro.PrecioCompra = decimal.Parse(txtPrecioCompra.Text.Trim());
            registro.PrecioVenta = decimal.Parse(txtPrecioVenta.Text.Trim());
            registro.CodigoBarraProveedor = txtCodigoBarraProveedor.Text.Trim();
            registro.CodigoProveedor = codigoProveedor.Value;
            registro.Proveedor = new ProveedorBe();
            registro.Proveedor.CodigoProveedor = codigoProveedor.Value;
            registro.Proveedor.Nombres = txtNombresProveedor.Text;
            registro.CodigoPersonalInspeccion = codigoPersonalInspeccion.Value;
            registro.PersonalInspeccion = new PersonalBe();
            registro.PersonalInspeccion.CodigoPersonal = codigoPersonalInspeccion.Value;
            registro.PersonalInspeccion.Nombres = txtNombresPersonalInspeccion.Text;
            registro.CodigoComprobanteCompra = comprobanteCompraDetalle == null ? null : (int?)comprobanteCompraDetalle.CodigoComprobanteCompra;
            registro.CodigoComprobanteCompraDetalle = comprobanteCompraDetalle == null ? null : (int?)comprobanteCompraDetalle.CodigoComprobanteCompraDetalle;

            int codigoProductoIndividual = registro.CodigoProductoIndividual;

            bool seGuardoRegistro = false;

            if (comprobanteCompraDetalle == null) seGuardoRegistro = productoIndividualBl.GuardarProductoIndividual(registro, out codigoProductoIndividual);
            else
            {
                _ProductoIndividual = registro;
                seGuardoRegistro = true;
            }

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorCodigoBarra.Text = "";
            lblErrorNombre.Text = "";
            lblErrorProducto.Text = "";
            lblErrorCodigoUnidadMedida.Text = "";
            lblErrorProductoIndividualInicial.Text = "";
            lblErrorMetraje.Text = "";
            lblErrorCodigoUnidadMedidaPeso.Text = "";
            lblErrorPeso.Text = "";
            lblErrorRollo.Text = "";
            lblErrorBulto.Text = "";
            lblErrorColor.Text = "";
            lblErrorPrecioCompra.Text = "";
            lblErrorPrecioVenta.Text = "";
            lblErrorFechaEntrada.Text = "";
            lblErrorCodigoBarraProveedor.Text = "";
            lblErrorProveedor.Text = "";
            lblErrorPersonalInspeccion.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (txtCodigoBarra.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorCodigoBarra.Text = "Debe ingresar codigo barra";
                SetToolTipError(lblErrorCodigoBarra);
            }
            else
            {
                //bool existeCodigoBarra = false, existeNombre = false;

                //bool existeProductoIndividual = productoIndividualBl.ExisteProductoIndividual(txtCodigoBarra.Text.Trim(), txtNombre.Text.Trim(), codigoProductoIndividual, out existeCodigoBarra, out existeNombre);
                bool existeProductoIndividual = productoIndividualBl.ExisteProductoIndividual(txtCodigoBarra.Text.Trim(), txtNombre.Text.Trim(), codigoProductoIndividual);

                if (existeProductoIndividual)
                {
                    estaValidado = false;
                    lblErrorCodigoBarra.Text = $"El código ya existe";
                    SetToolTipError(lblErrorCodigoBarra);
                }
            }

            if (txtNombre.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorNombre.Text = "Debe ingresar nombre";
                SetToolTipError(lblErrorNombre);
            }

            if (codigoProducto == null)
            {
                estaValidado = false;
                lblErrorProducto.Text = "Debe seleccionar producto";
                SetToolTipError(lblErrorProducto);
            }

            if (cbbCodigoUnidadMedida.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoUnidadMedida.Text = "Debe seleccionar unidad medida";
                SetToolTipError(lblErrorCodigoUnidadMedida);
            }

            if (txtCodigoBarraProductoIndividualInicial.Text.Trim() != "")
            {
                if (codigoProductoIndividualInicial == null)
                {
                    estaValidado = false;
                    lblErrorProductoIndividualInicial.Text = "Debe ingresar código inicial";
                    SetToolTipError(lblErrorProductoIndividualInicial);
                }
            }

            if (txtMetraje.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorMetraje.Text = "Debe ingresar metraje";
                SetToolTipError(lblErrorMetraje);
            }
            else
            {
                decimal metraje = 0;

                if (!decimal.TryParse(txtMetraje.Text.Trim(), out metraje))
                {
                    estaValidado = false;
                    lblErrorMetraje.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorMetraje);
                }
            }

            if (cbbCodigoUnidadMedidaPeso.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoUnidadMedidaPeso.Text = "Debe seleccionar unidad medida peso";
                SetToolTipError(lblErrorCodigoUnidadMedidaPeso);
            }

            if (txtPeso.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorPeso.Text = "Debe ingresar peso";
                SetToolTipError(lblErrorPeso);
            }
            else
            {
                decimal peso = 0;

                if (!decimal.TryParse(txtPeso.Text.Trim(), out peso))
                {
                    estaValidado = false;
                    lblErrorPeso.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorPeso);
                }
            }

            if (txtRollo.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorRollo.Text = "Debe ingresar rollo";
                SetToolTipError(lblErrorRollo);
            }
            else
            {
                decimal rollo = 0;

                if (!decimal.TryParse(txtRollo.Text.Trim(), out rollo))
                {
                    estaValidado = false;
                    lblErrorRollo.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorRollo);
                }
            }

            if (txtBulto.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorBulto.Text = "Debe ingresar bulto";
                SetToolTipError(lblErrorBulto);
            }
            else
            {
                decimal bulto = 0;

                if (!decimal.TryParse(txtBulto.Text.Trim(), out bulto))
                {
                    estaValidado = false;
                    lblErrorBulto.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorBulto);
                }
            }

            if (txtColor.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorColor.Text = "Debe ingresar color";
                SetToolTipError(lblErrorColor);
            }

            //if (txtPrecioCompra.Text.Trim() == "")
            //{
            //    estaValidado = false;
            //    lblErrorPrecioCompra.Text = "Debe ingresar precio compra";
            //    SetToolTipError(lblErrorPrecioCompra);
            //}
            //else
            //{
            //    decimal precioCompra = 0;

            //    if (!decimal.TryParse(txtPrecioCompra.Text.Trim(), out precioCompra))
            //    {
            //        estaValidado = false;
            //        lblErrorPrecioCompra.Text = "Debe ingresar un valor numérico";
            //        SetToolTipError(lblErrorPrecioCompra);
            //    }
            //}

            if (txtPrecioVenta.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorPrecioVenta.Text = "Debe ingresar precio venta";
                SetToolTipError(lblErrorPrecioVenta);
            }
            else
            {
                decimal precioVenta = 0;

                if (!decimal.TryParse(txtPrecioVenta.Text.Trim(), out precioVenta))
                {
                    estaValidado = false;
                    lblErrorPrecioVenta.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorPrecioVenta);
                }
            }

            if (txtCodigoBarraProveedor.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorCodigoBarraProveedor.Text = "Debe ingresar código barra proveedor";
                SetToolTipError(lblErrorCodigoBarraProveedor);
            }

            if (codigoProveedor == null)
            {
                estaValidado = false;
                lblErrorProveedor.Text = "Debe seleccionar proveedor";
                SetToolTipError(lblErrorProveedor);
            }

            if (codigoPersonalInspeccion == null)
            {
                estaValidado = false;
                lblErrorPersonalInspeccion.Text = "Debe seleccionar personal inspección";
                SetToolTipError(lblErrorPersonalInspeccion);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltProductoIndividual.SetToolTip(label, label.Text);
        }
    }
}
