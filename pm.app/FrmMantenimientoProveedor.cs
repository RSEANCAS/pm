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

namespace pm.app
{
    public partial class FrmMantenimientoProveedor : RadForm
    {
        int? codigoProveedor;

        PaisBl paisBl = new PaisBl();
        DepartamentoBl departamentoBl = new DepartamentoBl();
        ProvinciaBl provinciaBl = new ProvinciaBl();
        DistritoBl distritoBl = new DistritoBl();
        TipoDocumentoIdentidadBl tipoDocumentoIdentidadBl = new TipoDocumentoIdentidadBl();
        ProveedorBl proveedorBl = new ProveedorBl();

        List<PaisBe> listaComboPais = null;
        List<DepartamentoBe> listaComboDepartamento = null;
        List<ProvinciaBe> listaComboProvincia = null;
        List<DistritoBe> listaComboDistrito = null;

        public FrmMantenimientoProveedor(int? codigoProveedor = null)
        {
            InitializeComponent();
            this.codigoProveedor = codigoProveedor;
        }

        private void FrmMantenimientoProveedor_Load(object sender, EventArgs e)
        {
            Text = !codigoProveedor.HasValue ? "Nuevo Proveedor" : "Modificar Proveedor";
            ObtenerListaCombo();
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
            registro.CodigoDistrito = (int)cbbCodigoDistrito.SelectedValue;

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
            lblErrorCodigoPais.Text = "";
            lblErrorCodigoDepartamento.Text = "";
            lblErrorCodigoProvincia.Text = "";
            lblErrorCodigoDistrito.Text = "";
            lblErrorCorreoElectronico.Text = "";
            lblErrorTelefono.Text = "";
            lblErrorContacto.Text = "";
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

            if (cbbCodigoPais.SelectedIndex == 0)
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
                lblErrorCodigoPais.Text = "Debe ingresar correo electrónico";
                SetToolTipError(lblErrorCodigoPais);
            }

            if (txtTelefono.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorCorreoElectronico.Text = "Debe ingresar teléfono";
                SetToolTipError(lblErrorCorreoElectronico);
            }

            if (txtContacto.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorTelefono.Text = "Debe ingresar contacto";
                SetToolTipError(lblErrorTelefono);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltProveedor.SetToolTip(label, label.Text);
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
