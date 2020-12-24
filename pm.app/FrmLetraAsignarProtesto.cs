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
    public partial class FrmLetraAsignarProtesto : Form
    {
        LetraBe letra;

        LetraBl letraBl = new LetraBl();

        public FrmLetraAsignarProtesto(LetraBe letra)
        {
            InitializeComponent();
            this.letra = letra;
        }

        private void FrmLetraAsignarProtesto_Load(object sender, EventArgs e)
        {
            CargarLetra();
        }

        void CargarLetra()
        {
            if (letra != null)
            {
                txtProtesto.Text = letra.Protesto.ToString("0.00");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            LetraBe registro = new LetraBe();
            registro.CodigoLetra = letra.CodigoLetra;
            registro.Protesto = decimal.Parse(txtProtesto.Text.Trim());
            registro.Estado = letra.Estado;

            bool seGuardoRegistro = letraBl.AsignarProtesto(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡Se asignó el mora correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorProtesto.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (txtProtesto.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorProtesto.Text = "Debe ingresar un monto de protesto";
                SetToolTipError(lblErrorProtesto);
            }
            else
            {
                decimal protesto = 0;

                if (!decimal.TryParse(txtProtesto.Text.Trim(), out protesto))
                {
                    estaValidado = false;
                    lblErrorProtesto.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorProtesto);
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
