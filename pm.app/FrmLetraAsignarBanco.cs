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
    public partial class FrmLetraAsignarBanco : RadForm
    {
        LetraBe letra;

        BancoBl bancoBl = new BancoBl();
        LetraBl letraBl = new LetraBl();

        public FrmLetraAsignarBanco(LetraBe letra)
        {
            InitializeComponent();
            this.letra = letra;
        }

        private void FrmLetraAsignarBanco_Load(object sender, EventArgs e)
        {
            ListarCombos();
            CargarLetra();
        }

        void CargarLetra()
        {
            if (letra.CodigoBanco.HasValue)
            {
                cbbCodigoBanco.SelectedValue = letra.CodigoBanco;
                txtCodigoUnico.Text = letra.CodigoUnicoBanco;
            }
        }

        void ListarCombos()
        {
            ListarComboBanco();
        }

        void ListarComboBanco()
        {
            List<BancoBe> listaCombo = bancoBl.ListarComboBanco();
            listaCombo = listaCombo ?? new List<BancoBe>();
            listaCombo.Insert(0, new BancoBe { CodigoBanco = -1, Nombre = "[Seleccione...]" });

            cbbCodigoBanco.DataSource = null;
            cbbCodigoBanco.DataSource = listaCombo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            LetraBe registro = new LetraBe();
            registro.CodigoLetra = letra.CodigoLetra;
            registro.CodigoBanco = (int)cbbCodigoBanco.SelectedValue;
            registro.CodigoUnicoBanco = txtCodigoUnico.Text.Trim();
            registro.Estado = letra.Estado;
            //switch ((EstadoLetra)letra.Estado)
            //{
            //    case EstadoLetra.PorAsignarBanco:
            //        registro.Estado = (int)EstadoLetra.Pendiente;
            //        break;
            //    default: 
            //        registro.Estado = letra.Estado;
            //        break;
            //}

            bool seGuardoRegistro = letraBl.AsignarBanco(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡Se asignó el banco correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorCodigoBanco.Text = "";
            lblErrorCodigoUnico.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (cbbCodigoBanco.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoBanco.Text = "Debe seleccionar un banco";
                SetToolTipError(lblErrorCodigoBanco);
            }
            else
            {
                if (txtCodigoUnico.Text.Trim() != "")
                //{
                //    estaValidado = false;
                //    lblErrorCodigoUnico.Text = "Debe ingresar un código único de pago";
                //    SetToolTipError(lblErrorCodigoUnico);
                //}
                //else
                {
                    bool existeCodigoUnicoBanco = letraBl.ExisteCodigoUnicoBanco(letra.CodigoLetra, (int)cbbCodigoBanco.SelectedValue, txtCodigoUnico.Text.Trim());

                    if (existeCodigoUnicoBanco)
                    {
                        estaValidado = false;
                        lblErrorCodigoUnico.Text = "El código único de pago ya existe";
                        SetToolTipError(lblErrorCodigoUnico);
                    }
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
