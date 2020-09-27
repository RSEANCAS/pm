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
    public partial class FrmMantenimientoArea : RadForm
    {
        int? codigoArea;

        AreaBl areaBl = new AreaBl();

        public FrmMantenimientoArea(int? codigoArea = null)
        {
            InitializeComponent();
            this.codigoArea = codigoArea;
        }

        private void FrmMantenimientoArea_Load(object sender, EventArgs e)
        {
            Text = !codigoArea.HasValue ? "Nuevo Área" : "Modificar Área";
            if (codigoArea.HasValue)
            {
                CargarArea();
            }
        }

        void CargarArea()
        {
            AreaBe item = areaBl.ObtenerArea(codigoArea.Value);
            txtNombre.Text = item.Nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            AreaBe registro = new AreaBe();
            if (codigoArea.HasValue) registro.CodigoArea = codigoArea.Value;
            registro.Nombre = txtNombre.Text.Trim();

            bool seGuardoRegistro = areaBl.GuardarArea(registro);

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
                bool existeArea = areaBl.ExisteArea(txtNombre.Text.Trim(), codigoArea);

                if (existeArea)
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
            tltArea.SetToolTip(label, label.Text);
        }
    }
}
