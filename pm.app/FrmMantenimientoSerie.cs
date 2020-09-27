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
    public partial class FrmMantenimientoSerie : RadForm
    {
        int? codigoSerie;

        SerieBl serieBl = new SerieBl();
        TipoComprobanteBl tipoComprobanteBl = new TipoComprobanteBl();

        public FrmMantenimientoSerie(int? codigoSerie = null)
        {
            InitializeComponent();
            this.codigoSerie = codigoSerie;
        }

        private void FrmMantenimientoSerie_Load(object sender, EventArgs e)
        {
            Text = !codigoSerie.HasValue ? "Nuevo Serie" : "Modificar Serie";
            ListarCombos();
            if (codigoSerie.HasValue)
            {
                CargarSerie();
            }
        }

        void CargarSerie()
        {
            SerieBe item = serieBl.ObtenerSerie(codigoSerie.Value);
            cbbCodigoTipoComprobante.SelectedValue = item.CodigoTipoComprobante;
            txtSerial.Text = item.Serial;
            txtValorInicial.Text = item.ValorInicial.ToString();
            txtValorFinal.Text = item.ValorFinal.ToString();
            txtValorActual.Text = item.ValorActual.ToString();
        }

        void ListarCombos()
        {
            ListarComboTipoComprobante();
        }

        void ListarComboTipoComprobante()
        {
            List<TipoComprobanteBe> listaCombo = tipoComprobanteBl.ListarComboTipoComprobante();
            listaCombo = listaCombo ?? new List<TipoComprobanteBe>();
            listaCombo.Insert(0, new TipoComprobanteBe { CodigoTipoComprobante = -1, Nombre = "[Seleccione...]" });

            cbbCodigoTipoComprobante.DataSource = null;
            cbbCodigoTipoComprobante.DataSource = listaCombo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            SerieBe registro = new SerieBe();
            if (codigoSerie.HasValue) registro.CodigoSerie = codigoSerie.Value;
            registro.CodigoTipoComprobante = (int)cbbCodigoTipoComprobante.SelectedValue;
            registro.Serial = txtSerial.Text.Trim();
            registro.ValorInicial = int.Parse(txtValorInicial.Text.Trim());
            registro.ValorFinal = int.Parse(txtValorFinal.Text.Trim());
            registro.ValorActual = int.Parse(txtValorActual.Text.Trim());

            bool seGuardoRegistro = serieBl.GuardarSerie(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorCodigoTipoComprobante.Text = "";
            lblErrorSerial.Text = "";
            lblErrorValorInicial.Text = "";
            lblErrorValorFinal.Text = "";
            lblErrorValorActual.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (cbbCodigoTipoComprobante.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoTipoComprobante.Text = "Debe seleccionar un tipo de comprobante";
                SetToolTipError(lblErrorCodigoTipoComprobante);
            }

            if (txtSerial.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorSerial.Text = "Debe ingresar serial";
                SetToolTipError(lblErrorSerial);
            }
            else
            {
                TipoComprobanteBe tipoComprobante = (TipoComprobanteBe)cbbCodigoTipoComprobante.SelectedItem;
                if (tipoComprobante.CodigoTipoComprobante != -1)
                {
                    if (txtSerial.Text.Trim().Length != 4)
                    {
                        estaValidado = false;
                        lblErrorSerial.Text = $"Debe tener {4} caracteres";
                        SetToolTipError(lblErrorSerial);
                    }
                }

                bool existeSerie = serieBl.ExisteSerie(txtSerial.Text.Trim(), (int)cbbCodigoTipoComprobante.SelectedValue, codigoSerie);

                if (existeSerie)
                {
                    estaValidado = false;
                    lblErrorSerial.Text = $"El serial ya existe";
                    SetToolTipError(lblErrorSerial);
                }
            }

            if (txtValorInicial.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorValorInicial.Text = "Debe ingresar valor inicial";
                SetToolTipError(lblErrorValorInicial);
            }
            else
            {
                decimal valorInicial = 0;

                if (!decimal.TryParse(txtValorInicial.Text.Trim(), out valorInicial))
                {
                    estaValidado = false;
                    lblErrorValorInicial.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorValorInicial);
                }
            }

            if (txtValorFinal.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorValorFinal.Text = "Debe ingresar valor final";
                SetToolTipError(lblErrorValorFinal);
            }
            else
            {
                decimal valorFinal = 0;

                if (!decimal.TryParse(txtValorFinal.Text.Trim(), out valorFinal))
                {
                    estaValidado = false;
                    lblErrorValorFinal.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorValorFinal);
                }
            }

            if (txtValorActual.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorValorActual.Text = "Debe ingresar valor actual";
                SetToolTipError(lblErrorValorActual);
            }
            else
            {
                decimal valorActual = 0;

                if (!decimal.TryParse(txtValorActual.Text.Trim(), out valorActual))
                {
                    estaValidado = false;
                    lblErrorValorActual.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorValorActual);
                }
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltSerie.SetToolTip(label, label.Text);
        }
    }
}
