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

namespace pm.app
{
    public partial class FrmMantenimientoProveedor : Form
    {
        int? codigoProveedor;

        PaisBl paisBl = new PaisBl();
        TipoDocumentoIdentidadBl tipoDocumentoIdentidadBl = new TipoDocumentoIdentidadBl();
        ProveedorBl proveedorBl = new ProveedorBl();

        public FrmMantenimientoProveedor(int? codigoProveedor = null)
        {
            InitializeComponent();
            this.codigoProveedor = codigoProveedor;
        }

        private void FrmMantenimientoProveedor_Load(object sender, EventArgs e)
        {
            Text = !codigoProveedor.HasValue ? "Nuevo Proveedor" : "Modificar Proveedor";
            ListarCombos();
            if (codigoProveedor.HasValue)
            {
                CargarProveedor();
            }
        }

        void CargarProveedor()
        {
            ProveedorBe item = proveedorBl.ObtenerProveedor(codigoProveedor.Value);
            cbbCodigoTipoDocumentoIdentidad.SelectedValue = item.CodigoTipoDocumentoIdentidad;
            txtNroDocumentoIdentidad.Text = item.NroDocumentoIdentidad;
            txtNombresCompletos.Text = item.Nombres;
            txtDireccion.Text = item.Direccion;
            cbbPais.SelectedValue = item.CodigoPais;
            txtCorreoElectronico.Text = item.Correo;
            txtTelefono.Text = item.Telefono;
            txtContacto.Text = item.Contacto;
        }

        void ListarCombos()
        {
            ListarComboTipoDocumentoIdentidad();
            ListarComboPais();
        }

        void ListarComboTipoDocumentoIdentidad()
        {
            List<TipoDocumentoIdentidadBe> listaCombo = tipoDocumentoIdentidadBl.ListarComboTipoDocumentoIdentidad();
            listaCombo = listaCombo ?? new List<TipoDocumentoIdentidadBe>();
            listaCombo.Insert(0, new TipoDocumentoIdentidadBe { CodigoTipoDocumentoIdentidad = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoTipoDocumentoIdentidad.DataSource = null;
            cbbCodigoTipoDocumentoIdentidad.DataSource = listaCombo;
        }

        void ListarComboPais()
        {
            List<PaisBe> listaCombo = paisBl.ListarComboPais();
            listaCombo = listaCombo ?? new List<PaisBe>();
            listaCombo.Insert(0, new PaisBe { CodigoPais = -1, Nombre = "[Seleccione...]" });

            cbbPais.DataSource = null;
            cbbPais.DataSource = listaCombo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            ProveedorBe registro = new ProveedorBe();
            if (codigoProveedor.HasValue) registro.CodigoProveedor = codigoProveedor.Value;
            registro.CodigoTipoDocumentoIdentidad = (int)cbbCodigoTipoDocumentoIdentidad.SelectedValue;
            registro.NroDocumentoIdentidad = txtNroDocumentoIdentidad.Text.Trim();
            registro.Nombres = txtNombresCompletos.Text.Trim();
            registro.Direccion = txtDireccion.Text.Trim();
            registro.Correo = txtCorreoElectronico.Text.Trim();
            registro.Telefono = txtTelefono.Text.Trim();
            registro.Contacto = txtContacto.Text.Trim();
            registro.CodigoPais = (int)cbbPais.SelectedValue;

            bool seGuardoRegistro = proveedorBl.GuardarProveedor(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorCodigoTipoDocumentoIdentidad.Text = "";
            lblErrorNroDocumentoIdentidad.Text = "";
            lblErrorNombresCompletos.Text = "";
            lblErrorDireccion.Text = "";
            lblErrorCorreoElectronico.Text = "";
            lblErrorTelefono.Text = "";
            lblErrorContacto.Text = "";
            lblErrorAreaContacto.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (cbbCodigoTipoDocumentoIdentidad.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoTipoDocumentoIdentidad.Text = "Debe seleccionar un documento identidad";
                SetToolTipError(lblErrorCodigoTipoDocumentoIdentidad);
            }

            if (txtNroDocumentoIdentidad.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorNroDocumentoIdentidad.Text = "Debe ingresar N° documento identidad";
                SetToolTipError(lblErrorNroDocumentoIdentidad);
            }
            else
            {
                TipoDocumentoIdentidadBe tipoDocumentoIdentidad = (TipoDocumentoIdentidadBe)cbbCodigoTipoDocumentoIdentidad.SelectedItem;
                if (tipoDocumentoIdentidad.CodigoTipoDocumentoIdentidad != -1)
                {
                    if (txtNroDocumentoIdentidad.Text.Trim().Length != tipoDocumentoIdentidad.CantidadCaracteres)
                    {
                        estaValidado = false;
                        lblErrorNroDocumentoIdentidad.Text = $"Debe tener {tipoDocumentoIdentidad.CantidadCaracteres} caracteres";
                        SetToolTipError(lblErrorNroDocumentoIdentidad);
                    }
                }

                bool existeProveedor = proveedorBl.ExisteProveedor(txtNroDocumentoIdentidad.Text.Trim(), codigoProveedor);

                if (existeProveedor)
                {
                    estaValidado = false;
                    lblErrorNroDocumentoIdentidad.Text = $"El N° documento identidad ya existe";
                    SetToolTipError(lblErrorNroDocumentoIdentidad);
                }
            }

            if (txtNombresCompletos.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorNombresCompletos.Text = "Debe ingresar nombres completos";
                SetToolTipError(lblErrorNombresCompletos);
            }

            if (txtDireccion.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorDireccion.Text = "Debe ingresar dirección";
                SetToolTipError(lblErrorDireccion);
            }

            if (cbbPais.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorAreaContacto.Text = "Debe seleccionar un país";
                SetToolTipError(lblErrorAreaContacto);
            }

            if (txtCorreoElectronico.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorCorreoElectronico.Text = "Debe ingresar correo electrónico";
                SetToolTipError(lblErrorCorreoElectronico);
            }

            if (txtTelefono.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorTelefono.Text = "Debe ingresar teléfono";
                SetToolTipError(lblErrorTelefono);
            }

            if (txtContacto.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorContacto.Text = "Debe ingresar contacto";
                SetToolTipError(lblErrorContacto);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltProveedor.SetToolTip(label, label.Text);
        }
    }
}
