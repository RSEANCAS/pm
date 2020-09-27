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
    public partial class FrmMantenimientoPersonal : RadForm
    {
        int? codigoPersonal;

        AreaBl areaBl = new AreaBl();
        TipoDocumentoIdentidadBl tipoDocumentoIdentidadBl = new TipoDocumentoIdentidadBl();
        PersonalBl personalBl = new PersonalBl();

        public FrmMantenimientoPersonal(int? codigoPersonal = null)
        {
            InitializeComponent();
            this.codigoPersonal = codigoPersonal;
        }

        private void FrmMantenimientoPersonal_Load(object sender, EventArgs e)
        {
            Text = !codigoPersonal.HasValue ? "Nuevo Personal" : "Modificar Personal";
            ListarCombos();
            if (codigoPersonal.HasValue)
            {
                CargarPersonal();
            }
        }

        void CargarPersonal()
        {
            PersonalBe item = personalBl.ObtenerPersonal(codigoPersonal.Value);
            cbbCodigoTipoDocumentoIdentidad.SelectedValue = item.CodigoTipoDocumentoIdentidad;
            txtNroDocumentoIdentidad.Text = item.NroDocumentoIdentidad;
            txtNombresCompletos.Text = item.Nombres;
            txtCorreoElectronico.Text = item.Correo;
            cbbCodigoArea.SelectedValue = item.CodigoArea;
            cbbEstado.SelectedValue = item.Estado.ToString();
        }

        void ListarCombos()
        {
            ListarComboTipoDocumentoIdentidad();
            ListarComboArea();
            ListarComboEstado();
        }

        void ListarComboArea()
        {
            List<AreaBe> listaCombo = areaBl.ListarComboArea();
            listaCombo = listaCombo ?? new List<AreaBe>();
            listaCombo.Insert(0, new AreaBe { CodigoArea = -1, Nombre = "[Seleccione...]" });

            cbbCodigoArea.DataSource = null;
            cbbCodigoArea.DataSource = listaCombo;
        }

        void ListarComboTipoDocumentoIdentidad()
        {
            List<TipoDocumentoIdentidadBe> listaCombo = tipoDocumentoIdentidadBl.ListarComboTipoDocumentoIdentidad();
            listaCombo = listaCombo ?? new List<TipoDocumentoIdentidadBe>();
            listaCombo.Insert(0, new TipoDocumentoIdentidadBe { CodigoTipoDocumentoIdentidad = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoTipoDocumentoIdentidad.DataSource = null;
            cbbCodigoTipoDocumentoIdentidad.DataSource = listaCombo;
        }

        void ListarComboEstado()
        {
            List<Combo> listaCombo = Enum<EstadoPersonal>.GetCollection().ToList();

            listaCombo.Insert(0, new Combo { Value = "-1", Text = "[Seleccione...]" });

            cbbEstado.DataSource = null;
            cbbEstado.DataSource = listaCombo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            PersonalBe registro = new PersonalBe();
            if (codigoPersonal.HasValue) registro.CodigoPersonal = codigoPersonal.Value;
            registro.CodigoTipoDocumentoIdentidad = (int)cbbCodigoTipoDocumentoIdentidad.SelectedValue;
            registro.NroDocumentoIdentidad = txtNroDocumentoIdentidad.Text.Trim();
            registro.Nombres = txtNombresCompletos.Text.Trim();
            registro.Correo = txtCorreoElectronico.Text.Trim();
            registro.CodigoArea = (int)cbbCodigoArea.SelectedValue;
            registro.Estado = int.Parse(cbbEstado.SelectedValue.ToString());

            bool seGuardoRegistro = personalBl.GuardarPersonal(registro);

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
            lblErrorCorreoElectronico.Text = "";
            lblErrorCodigoArea.Text = "";
            lblErrorEstado.Text = "";
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

                bool existePersonal = personalBl.ExistePersonal(txtNroDocumentoIdentidad.Text.Trim(), codigoPersonal);

                if (existePersonal)
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

            if (txtCorreoElectronico.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorCorreoElectronico.Text = "Debe ingresar correo electrónico";
                SetToolTipError(lblErrorCorreoElectronico);
            }

            if (cbbCodigoArea.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoArea.Text = "Debe seleccionar un área";
                SetToolTipError(lblErrorCodigoArea);
            }

            if (cbbEstado.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorEstado.Text = "Debe seleccionar un estado";
                SetToolTipError(lblErrorEstado);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltPersonal.SetToolTip(label, label.Text);
        }
    }
}
