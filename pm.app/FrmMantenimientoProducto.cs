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
    public partial class FrmMantenimientoProducto : RadForm
    {
        int? codigoProducto;

        UnidadMedidaBl unidadMedidaBl = new UnidadMedidaBl();
        ProductoBl productoBl = new ProductoBl();

        public FrmMantenimientoProducto(int? codigoProducto = null)
        {
            InitializeComponent();
            this.codigoProducto = codigoProducto;
        }

        private void FrmMantenimientoProducto_Load(object sender, EventArgs e)
        {
            Text = !codigoProducto.HasValue ? "Nuevo Producto" : "Modificar Producto";
            ListarCombos();
            if (codigoProducto.HasValue)
            {
                CargarProducto();
            }
        }

        void CargarProducto()
        {
            ProductoBe item = productoBl.ObtenerProducto(codigoProducto.Value);
            txtNombre.Text = item.Nombre;
            cbbCodigoUnidadMedida.SelectedValue = item.CodigoUnidadMedida;
            txtCantidad.Text = item.Cantidad.ToString("0.00");
            txtValorCompra.Text = item.ValorCompra.ToString("0.00");
            txtValorVenta.Text = item.ValorVenta.ToString("0.00");
            txtDescuentoMaximo.Text = item.DescuentoMaximo.ToString("0.00");
            txtColor.Text = item.Color;
            txtMetrajeTotal.Text = item.MetrajeTotal.ToString("0.00");
            cbbEstado.SelectedValue = item.Estado.ToString();
        }

        void ListarCombos()
        {
            ListarComboUnidadMedida();
            ListarComboEstado();
        }

        void ListarComboUnidadMedida()
        {
            List<UnidadMedidaBe> listaCombo = unidadMedidaBl.ListarComboUnidadMedida();
            listaCombo = listaCombo ?? new List<UnidadMedidaBe>();
            listaCombo.Insert(0, new UnidadMedidaBe { CodigoUnidadMedida = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoUnidadMedida.DataSource = null;
            cbbCodigoUnidadMedida.DataSource = listaCombo;
        }

        void ListarComboEstado()
        {
            List<Combo> listaCombo = Enum<EstadoProducto>.GetCollection().ToList();

            listaCombo.Insert(0, new Combo { Value = "-1", Text = "[Seleccione...]" });

            cbbEstado.DataSource = null;
            cbbEstado.DataSource = listaCombo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            ProductoBe registro = new ProductoBe();
            if (codigoProducto.HasValue) registro.CodigoProducto = codigoProducto.Value;
            registro.Nombre = txtNombre.Text.Trim();
            registro.CodigoUnidadMedida = (int)cbbCodigoUnidadMedida.SelectedValue;
            registro.Cantidad = decimal.Parse(txtCantidad.Text.Trim());
            registro.ValorCompra = decimal.Parse(txtValorCompra.Text.Trim());
            registro.ValorVenta = decimal.Parse(txtValorVenta.Text.Trim());
            registro.DescuentoMaximo = decimal.Parse(txtDescuentoMaximo.Text.Trim());
            registro.Color = txtColor.Text.Trim();
            registro.MetrajeTotal = decimal.Parse(txtMetrajeTotal.Text.Trim());
            registro.Estado = int.Parse(cbbEstado.SelectedValue.ToString());

            bool seGuardoRegistro = productoBl.GuardarProducto(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorNombre.Text = "";
            lblErrorCodigoUnidadMedida.Text = "";
            lblErrorCantidad.Text = "";
            lblErrorValorCompra.Text = "";
            lblErrorValorVenta.Text = "";
            lblErrorDescuentoMaximo.Text = "";
            lblErrorColor.Text = "";
            lblErrorMetrajeTotal.Text = "";
            lblErrorEstado.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (txtNombre.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorNombre.Text = "Debe ingresar nombre";
                SetToolTipError(lblErrorNombre);
            }
            else
            {
                bool existeProducto = productoBl.ExisteProducto(txtNombre.Text.Trim(), codigoProducto);

                if (existeProducto)
                {
                    estaValidado = false;
                    lblErrorNombre.Text = $"El nombre ya existe";
                    SetToolTipError(lblErrorNombre);
                }
            }

            if (txtNombre.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorNombre.Text = "Debe ingresar nombre";
                SetToolTipError(lblErrorNombre);
            }

            if (cbbCodigoUnidadMedida.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoUnidadMedida.Text = "Debe seleccionar unidad medida";
                SetToolTipError(lblErrorCodigoUnidadMedida);
            }

            if (txtCantidad.Text.Trim() == "")
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

            if (txtValorCompra.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorValorCompra.Text = "Debe ingresar valor compra";
                SetToolTipError(lblErrorValorCompra);
            }
            else
            {
                decimal valorCompra = 0;

                if (!decimal.TryParse(txtValorCompra.Text.Trim(), out valorCompra))
                {
                    estaValidado = false;
                    lblErrorValorCompra.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorValorCompra);
                }
            }

            if (txtValorVenta.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorValorVenta.Text = "Debe ingresar valor venta";
                SetToolTipError(lblErrorValorVenta);
            }
            else
            {
                decimal valorVenta = 0;

                if (!decimal.TryParse(txtValorVenta.Text.Trim(), out valorVenta))
                {
                    estaValidado = false;
                    lblErrorValorVenta.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorValorVenta);
                }
            }

            if (txtDescuentoMaximo.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorDescuentoMaximo.Text = "Debe ingresar descuento máximo";
                SetToolTipError(lblErrorDescuentoMaximo);
            }
            else
            {
                decimal descuentoMaximo = 0;

                if (!decimal.TryParse(txtDescuentoMaximo.Text.Trim(), out descuentoMaximo))
                {
                    estaValidado = false;
                    lblErrorDescuentoMaximo.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorDescuentoMaximo);
                }
            }

            if (txtColor.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorColor.Text = "Debe ingresar color";
                SetToolTipError(lblErrorColor);
            }

            if (txtMetrajeTotal.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorMetrajeTotal.Text = "Debe ingresar color";
                SetToolTipError(lblErrorMetrajeTotal);
            }
            else
            {
                decimal metrajeTotal = 0;

                if (!decimal.TryParse(txtMetrajeTotal.Text.Trim(), out metrajeTotal))
                {
                    estaValidado = false;
                    lblErrorMetrajeTotal.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorMetrajeTotal);
                }
            }

            if (cbbEstado.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorEstado.Text = "Debe seleccionar estado";
                SetToolTipError(lblErrorEstado);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltProducto.SetToolTip(label, label.Text);
        }
    }
}