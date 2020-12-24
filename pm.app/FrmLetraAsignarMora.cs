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
    public partial class FrmLetraAsignarMora : Form
    {
        LetraBe letra;

        LetraBl letraBl = new LetraBl();

        public FrmLetraAsignarMora(LetraBe letra)
        {
            InitializeComponent();
            this.letra = letra;
        }

        private void FrmLetraAsignarMora_Load(object sender, EventArgs e)
        {
            CargarLetra();
        }

        void CargarLetra()
        {
            if (letra != null)
            {
                txtMora.Text = letra.Mora.ToString("0.00");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            LetraBe registro = new LetraBe();
            registro.CodigoLetra = letra.CodigoLetra;
            registro.Mora = decimal.Parse(txtMora.Text.Trim());
            registro.Estado = letra.Estado;

            bool seGuardoRegistro = letraBl.AsignarMora(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡Se asignó el mora correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorMora.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (txtMora.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorMora.Text = "Debe ingresar un monto por morosidad";
                SetToolTipError(lblErrorMora);
            }
            else
            {
                decimal mora = 0;

                if (!decimal.TryParse(txtMora.Text.Trim(), out mora))
                {
                    estaValidado = false;
                    lblErrorMora.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorMora);
                }
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltLetra.SetToolTip(label, label.Text);
        }
    }
}
