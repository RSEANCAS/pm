using pm.be;
using pm.bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pm.app
{
    public partial class FrmMantenimientoCliente : Form
    {
        int? codigoCliente;

        ActividadBl actividadBl = new ActividadBl();
        TipoDocumentoIdentidadBl tipoDocumentoIdentidadBl = new TipoDocumentoIdentidadBl();
        ClienteBl clienteBl = new ClienteBl();

        public FrmMantenimientoCliente(int? codigoCliente = null)
        {
            InitializeComponent();
            this.codigoCliente = codigoCliente;
        }

        private void FrmMantenimientoCliente_Load(object sender, EventArgs e)   
        {
            Text = !codigoCliente.HasValue ? "Nuevo Cliente" : "Modificar Cliente";
            ListarCombos();
            if (codigoCliente.HasValue)
            {
                CargarCliente();
            }
        }

        void CargarCliente()
        {
            ClienteBe item = clienteBl.ObtenerCliente(codigoCliente.Value);
            cbbCodigoTipoDocumentoIdentidad.SelectedValue = item.CodigoTipoDocumentoIdentidad;
            txtNroDocumentoIdentidad.Text = item.NroDocumentoIdentidad;
            txtNombresCompletos.Text = item.Nombres;
            txtDireccion.Text = item.Direccion;
            txtCorreoElectronico.Text = item.Correo;
            txtTelefono.Text = item.Telefono;
            txtContacto.Text = item.Contacto;
            txtAreaContacto.Text = item.AreaContacto;
            if (item.CodigoActividadPrincipal.HasValue) cbbCodigoActividadPrincipal.SelectedValue = item.CodigoActividadPrincipal;
        }

        void ListarCombos()
        {
            ListarComboTipoDocumentoIdentidad();
            ListarComboActividad();
        }

        void ListarComboTipoDocumentoIdentidad()
        {
            List<TipoDocumentoIdentidadBe> listaCombo = tipoDocumentoIdentidadBl.ListarComboTipoDocumentoIdentidad();
            listaCombo = listaCombo ?? new List<TipoDocumentoIdentidadBe>();
            listaCombo.Insert(0, new TipoDocumentoIdentidadBe { CodigoTipoDocumentoIdentidad = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoTipoDocumentoIdentidad.DataSource = null;
            cbbCodigoTipoDocumentoIdentidad.DataSource = listaCombo;
        }

        void ListarComboActividad()
        {
            List<ActividadBe> listaCombo = actividadBl.ListarComboActividad();
            listaCombo = listaCombo ?? new List<ActividadBe>();
            listaCombo.Insert(0, new ActividadBe { CodigoActividad = -1, Nombre = "[Seleccione...]" });

            cbbCodigoActividadPrincipal.DataSource = null;
            cbbCodigoActividadPrincipal.DataSource = listaCombo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            ClienteBe registro = new ClienteBe();
            if (codigoCliente.HasValue) registro.CodigoCliente = codigoCliente.Value;
            registro.CodigoTipoDocumentoIdentidad = (int)cbbCodigoTipoDocumentoIdentidad.SelectedValue;
            registro.NroDocumentoIdentidad = txtNroDocumentoIdentidad.Text.Trim();
            registro.Nombres = txtNombresCompletos.Text.Trim();
            registro.Direccion = txtDireccion.Text.Trim();
            registro.Correo = txtCorreoElectronico.Text.Trim();
            registro.Telefono = txtTelefono.Text.Trim();
            registro.Contacto = txtContacto.Text.Trim();
            registro.AreaContacto = txtAreaContacto.Text.Trim();
            if (cbbCodigoActividadPrincipal.SelectedIndex != 0) registro.CodigoActividadPrincipal = (int)cbbCodigoActividadPrincipal.SelectedValue;

            bool seGuardoRegistro = clienteBl.GuardarCliente(registro);

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

                bool existeCliente = clienteBl.ExisteCliente(txtNroDocumentoIdentidad.Text.Trim(), codigoCliente);

                if (existeCliente)
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

            if (txtAreaContacto.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorAreaContacto.Text = "Debe ingresar área de contacto";
                SetToolTipError(lblErrorAreaContacto);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltCliente.SetToolTip(label, label.Text);
        }
    }
}
