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
using Telerik.WinControls.UI;

namespace pm.app
{
    public partial class FrmMantenimientoCliente : RadForm
    {
        int? codigoCliente;

        ActividadBl actividadBl = new ActividadBl();
        TipoDocumentoIdentidadBl tipoDocumentoIdentidadBl = new TipoDocumentoIdentidadBl();
        PaisBl paisBl = new PaisBl();
        DepartamentoBl departamentoBl = new DepartamentoBl();
        ProvinciaBl provinciaBl = new ProvinciaBl();
        DistritoBl distritoBl = new DistritoBl();
        ClienteBl clienteBl = new ClienteBl();

        List<PaisBe> listaComboPais = null;
        List<DepartamentoBe> listaComboDepartamento = null;
        List<ProvinciaBe> listaComboProvincia = null;
        List<DistritoBe> listaComboDistrito = null;

        public FrmMantenimientoCliente(int? codigoCliente = null)
        {
            InitializeComponent();
            this.codigoCliente = codigoCliente;
        }

        private void FrmMantenimientoCliente_Load(object sender, EventArgs e)   
        {
            Text = !codigoCliente.HasValue ? "Nuevo Cliente" : "Modificar Cliente";
            ObtenerListaCombo();
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
            DistritoBe distrito = listaComboDistrito.Where(x => x.CodigoDistrito == item.CodigoDistrito).FirstOrDefault();
            ProvinciaBe provincia = listaComboProvincia.Where(x => x.CodigoProvincia == distrito.CodigoProvincia).FirstOrDefault();
            DepartamentoBe departamento = listaComboDepartamento.Where(x => x.CodigoDepartamento == provincia.CodigoDepartamento).FirstOrDefault();
            PaisBe pais = listaComboPais.Where(x => x.CodigoPais == departamento.CodigoPais).FirstOrDefault();
            cbbCodigoPais.SelectedValue = pais.CodigoPais;
            cbbCodigoDepartamento.SelectedValue = departamento.CodigoDepartamento;
            cbbCodigoProvincia.SelectedValue = provincia.CodigoProvincia;
            cbbCodigoDistrito.SelectedValue = item.CodigoDistrito;
            txtCorreoElectronico.Text = item.Correo;
            txtTelefono.Text = item.Telefono;
            txtContacto.Text = item.Contacto;
            txtAreaContacto.Text = item.AreaContacto;
            if (item.CodigoActividadPrincipal.HasValue) cbbCodigoActividadPrincipal.SelectedValue = item.CodigoActividadPrincipal;
        }

        void ListarCombos()
        {
            ListarComboTipoDocumentoIdentidad();
            ListarComboPais();
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

        void ObtenerListaCombo()
        {
            ObtenerListaComboPais();
            ObtenerListaComboDepartamento();
            ObtenerListaComboProvincia();
            ObtenerListaComboDistrito();
        }

        void ObtenerListaComboPais() => listaComboPais = paisBl.ListarComboPais();

        void ObtenerListaComboDepartamento() => listaComboDepartamento = departamentoBl.ListarComboDepartamento();

        void ObtenerListaComboProvincia() => listaComboProvincia = provinciaBl.ListarComboProvincia();

        void ObtenerListaComboDistrito() => listaComboDistrito = distritoBl.ListarComboDistrito();

        void ListarComboPais()
        {
            List<PaisBe> listaCombo = listaComboPais ?? new List<PaisBe>();
            listaCombo.Insert(0, new PaisBe { CodigoPais = -1, Nombre = "[Seleccione...]" });

            cbbCodigoPais.DataSource = null;
            cbbCodigoPais.DataSource = listaCombo;
        }

        void ListarComboDepartamento()
        {
            int? codigoPais = (int?)cbbCodigoPais.SelectedValue;
            List<DepartamentoBe> listaCombo = (listaComboDepartamento ?? new List<DepartamentoBe>()).Where(x => x.CodigoPais == codigoPais).ToList();
            listaCombo.Insert(0, new DepartamentoBe { CodigoDepartamento = -1, Nombre = "[Seleccione...]" });

            cbbCodigoDepartamento.DataSource = null;
            cbbCodigoDepartamento.DataSource = listaCombo;
        }

        void ListarComboProvincia()
        {
            int? codigoDepartamento = (int?)cbbCodigoDepartamento.SelectedValue;
            List<ProvinciaBe> listaCombo = (listaComboProvincia ?? new List<ProvinciaBe>()).Where(x => x.CodigoDepartamento == codigoDepartamento).ToList();
            listaCombo.Insert(0, new ProvinciaBe { CodigoProvincia = -1, Nombre = "[Seleccione...]" });

            cbbCodigoProvincia.DataSource = null;
            cbbCodigoProvincia.DataSource = listaCombo;
        }

        void ListarComboDistrito()
        {
            int? codigoProvincia = (int?)cbbCodigoProvincia.SelectedValue;
            List<DistritoBe> listaCombo = (listaComboDistrito ?? new List<DistritoBe>()).Where(x => x.CodigoProvincia == codigoProvincia).ToList();
            listaCombo.Insert(0, new DistritoBe { CodigoDistrito = -1, Nombre = "[Seleccione...]" });

            cbbCodigoDistrito.DataSource = null;
            cbbCodigoDistrito.DataSource = listaCombo;
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
            registro.CodigoDistrito = (int)cbbCodigoDistrito.SelectedValue;
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
            lblErrorCodigoPais.Text = "";
            lblErrorCodigoDepartamento.Text = "";
            lblErrorCodigoProvincia.Text = "";
            lblErrorCodigoDistrito.Text = "";
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

            if(cbbCodigoPais.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoPais.Text = "Debe seleccionar un país";
                SetToolTipError(lblErrorCodigoPais);
            }

            if (cbbCodigoDepartamento.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoDepartamento.Text = "Debe seleccionar un departamento";
                SetToolTipError(lblErrorCodigoDepartamento);
            }

            if (cbbCodigoProvincia.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoProvincia.Text = "Debe seleccionar una provincia";
                SetToolTipError(lblErrorCodigoProvincia);
            }

            if (cbbCodigoDistrito.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoDistrito.Text = "Debe seleccionar un distrito";
                SetToolTipError(lblErrorCodigoDistrito);
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

        private void cbbCodigoPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarComboDepartamento();
        }

        private void cbbCodigoDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarComboProvincia();
        }

        private void cbbCodigoProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarComboDistrito();
        }
    }
}
