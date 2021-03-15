using Newtonsoft.Json;
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
using static pm.enums.Enums;

namespace pm.app
{
    public partial class FrmLetraRegenerar : RadForm
    {
        LetraBe letraPadre = null;

        LetraBl letraBl = new LetraBl();
        public FrmLetraRegenerar(LetraBe letraPadre)
        {
            InitializeComponent();
            this.letraPadre = letraPadre;
        }

        private void FrmLetraRegenerar_Load(object sender, EventArgs e)
        {
            CargarLetra();
        }

        void CargarLetra()
        {
            if(letraPadre != null)
            {
                dtpFechaHoraEmision.Value = letraPadre.FechaHoraEmision;
                dtpFechaVencimiento.MinDate = letraPadre.FechaVencimiento;
                dtpFechaVencimiento.Value = letraPadre.FechaVencimiento;
                cbbCodigoTipoComprobanteRef.SelectedValue = letraPadre.CodigoTipoComprobanteRef.ToString();
                txtComprobanteRef.Text = $"{letraPadre.SerialSerieComprobanteRef}-{letraPadre.NroComprobanteComprobanteRef}";
                txtCliente.Text = letraPadre.Cliente.Nombres;
                txtAval.Text = letraPadre.FlagAval ? letraPadre.Aval.Nombres : "";
                cbbCodigoMoneda.SelectedValue = letraPadre.CodigoMoneda.ToString();
                txtMonto.Text = letraPadre.Total.ToString("0.00");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            LetraBe registro = JsonConvert.DeserializeObject<LetraBe>(JsonConvert.SerializeObject(letraPadre));
            registro.CodigoLetra = 0;
            registro.FechaVencimiento = dtpFechaVencimiento.Value;
            registro.Dias = (registro.FechaVencimiento - letraPadre.FechaVencimiento).Days;
            registro.Monto = decimal.Parse(txtMonto.Text);
            registro.Estado = (int)EstadoLetra.Pendiente;
            registro.CodigoLetraInicial = letraPadre.CodigoLetraInicial.HasValue ? letraPadre.CodigoLetraInicial.Value : letraPadre.CodigoLetra;
            registro.CodigoLetraPadre = letraPadre.CodigoLetra;

            int codigoLetra = 0, numeroLetra = 0;
            bool seGuardoRegistro = letraBl.GuardarLetra(registro, out codigoLetra, out numeroLetra);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡Se asignó el mora correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorFechaHoraEmision.Text = "";
            lblErrorFechaVencimiento.Text = "";
            lblErrorCodigoTipoComprobanteRef.Text = "";
            lblErrorComprobanteRef.Text = "";
            lblErrorCliente.Text = "";
            lblErrorAval.Text = "";
            lblErrorCodigoMoneda.Text = "";
            lblErrorMonto.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            decimal monto = 0;
            if (string.IsNullOrEmpty(txtMonto.Text.Trim()))
            {
                estaValidado = false;
                lblErrorMonto.Text = "Debe ingresar monto";
                SetToolTipError(lblErrorMonto);
            }
            else
            {

                if (!decimal.TryParse(txtMonto.Text.Trim(), out monto))
                {
                    estaValidado = false;
                    lblErrorMonto.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorMonto);
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
