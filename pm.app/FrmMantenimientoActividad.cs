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
    public partial class FrmMantenimientoActividad : Form
    {
        int? codigoActividad;

        ActividadBl actividadBl = new ActividadBl();

        public FrmMantenimientoActividad(int? codigoActividad = null)
        {
            InitializeComponent();
            this.codigoActividad = codigoActividad;
        }

        private void FrmMantenimientoActividad_Load(object sender, EventArgs e)
        {
            Text = !codigoActividad.HasValue ? "Nuevo Actividad" : "Modificar Actividad";
            if (codigoActividad.HasValue)
            {
                CargarActividad();
            }
        }

        void CargarActividad()
        {
            ActividadBe item = actividadBl.ObtenerActividad(codigoActividad.Value);
            txtNombre.Text = item.Nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            ActividadBe registro = new ActividadBe();
            if (codigoActividad.HasValue) registro.CodigoActividad = codigoActividad.Value;
            registro.Nombre = txtNombre.Text.Trim();

            bool seGuardoRegistro = actividadBl.GuardarActividad(registro);

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
                bool existeActividad = actividadBl.ExisteActividad(txtNombre.Text.Trim(), codigoActividad);

                if (existeActividad)
                {
                    estaValidado = false;
                    lblErrorNombre.Text = $"El nombre ya existe";
                    SetToolTipError(lblErrorNombre);
                }
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltActividad.SetToolTip(label, label.Text);
        }
    }
}
