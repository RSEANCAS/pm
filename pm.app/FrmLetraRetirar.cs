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
    public partial class FrmLetraRetirar : Form
    {
        LetraBe letra;

        LetraBl letraBl = new LetraBl();

        public FrmLetraRetirar(LetraBe letra)
        {
            InitializeComponent();
            this.letra = letra;
        }

        private void FrmLetraRetirar_Load(object sender, EventArgs e)
        {
            dtpFechaVencimiento.MinDate = letra.FechaVencimiento;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            bool seRegenera = chkRegenerar.Checked;
            LetraBe registro = seRegenera ? letraBl.ObtenerLetra(letra.CodigoLetra) : new LetraBe();
            registro.CodigoLetra = letra.CodigoLetra;
            registro.FechaVencimiento = dtpFechaVencimiento.Value;
            registro.Dias = (registro.FechaVencimiento - letra.FechaVencimiento).Days;
            registro.Observacion = txtObservacion.Text.Trim();
            registro.Estado = letra.Estado;
            registro.CodigoLetraInicial = letra.CodigoLetraInicial;
            registro.CodigoLetraPadre = letra.CodigoLetraPadre;

            bool seGuardoRegistro = letraBl.Retirar(registro, seRegenera);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡Se asignó el mora correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorObservacion.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (txtObservacion.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorObservacion.Text = "Debe ingresar una observación";
                SetToolTipError(lblErrorObservacion);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltLetra.SetToolTip(label, label.Text);
        }

        private void chkRegenerar_CheckedChanged(object sender, EventArgs e)
        {
            txtObservacion.Text = "";
            if (chkRegenerar.Checked)
            {
                txtObservacion.Text = "Regeneración de Letra";
                dtpFechaVencimiento.Value = letra.FechaVencimiento.AddMonths(1);
            }

            dtpFechaVencimiento.Enabled = chkRegenerar.Checked;
            txtObservacion.ReadOnly = chkRegenerar.Checked;
        }
    }
}
