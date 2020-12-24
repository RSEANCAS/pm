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
    public partial class FrmMantenimientoTipoCambio : Form
    {
        int? codigoTipoCambio;

        TipoCambioBl tipoCambioBl = new TipoCambioBl();

        public FrmMantenimientoTipoCambio(int? codigoTipoCambio = null)
        {
            InitializeComponent();
            this.codigoTipoCambio = codigoTipoCambio;
        }

        private void FrmMantenimientoTipoCambio_Load(object sender, EventArgs e)
        {
            Text = !codigoTipoCambio.HasValue ? "Nuevo Tipo Cambio" : "Modificar Tipo Cambio";
            if (codigoTipoCambio.HasValue)
            {
                CargarTipoCambio();
            }
        }

        void CargarTipoCambio()
        {
            TipoCambioBe item = tipoCambioBl.ObtenerTipoCambio(codigoTipoCambio.Value);
            dtpFechaCambio.Value = item.FechaCambio;
            txtValorVenta.Text = item.ValorVenta.ToString("0.00");
            txtValorCompra.Text = item.ValorCompra.ToString("0.00");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            TipoCambioBe registro = new TipoCambioBe();
            if (codigoTipoCambio.HasValue) registro.CodigoTipoCambio = codigoTipoCambio.Value;
            registro.FechaCambio = dtpFechaCambio.Value;
            registro.ValorVenta = decimal.Parse(txtValorVenta.Text.Trim());
            registro.ValorCompra = decimal.Parse(txtValorCompra.Text.Trim());

            bool seGuardoRegistro = tipoCambioBl.GuardarTipoCambio(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorFechaCambio.Text = "";
            lblErrorValorVenta.Text = "";
            lblErrorValorCompra.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            bool existeTipoCambio = tipoCambioBl.ExisteTipoCambio(dtpFechaCambio.Value, codigoTipoCambio);

            if (existeTipoCambio)
            {
                estaValidado = false;
                lblErrorFechaCambio.Text = $"La fecha de cambio ya existe";
                SetToolTipError(lblErrorFechaCambio);
            }

            if (txtValorVenta.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorValorVenta.Text = "Debe ingresar valor de venta";
                SetToolTipError(lblErrorValorVenta);
            }
            else
            {
                decimal valorVenta = 0;

                if (!decimal.TryParse(txtValorVenta.Text.Trim(), out valorVenta))
                {
                    estaValidado = false;
                    lblErrorValorVenta.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorValorVenta);
                }
            }

            if (txtValorCompra.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorValorCompra.Text = "Debe ingresar valor de compra";
                SetToolTipError(lblErrorValorCompra);
            }
            else
            {
                decimal valorCompra = 0;

                if (!decimal.TryParse(txtValorCompra.Text.Trim(), out valorCompra))
                {
                    estaValidado = false;
                    lblErrorValorCompra.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorValorCompra);
                }
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltTipoCambio.SetToolTip(label, label.Text);
        }
    }
}
