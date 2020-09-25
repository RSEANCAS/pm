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
    public partial class FrmMantenimientoBanco : Form
    {
        int? codigoBanco;

        BancoBl bancoBl = new BancoBl();

        public FrmMantenimientoBanco(int? codigoBanco = null)
        {
            InitializeComponent();
            this.codigoBanco = codigoBanco;
        }

        private void FrmMantenimientoBanco_Load(object sender, EventArgs e)
        {
            Text = !codigoBanco.HasValue ? "Nuevo Banco" : "Modificar Banco";
            if (codigoBanco.HasValue)
            {
                CargarBanco();
            }
        }

        void CargarBanco()
        {
            BancoBe item = bancoBl.ObtenerBanco(codigoBanco.Value);
            txtNombre.Text = item.Nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            BancoBe registro = new BancoBe();
            if (codigoBanco.HasValue) registro.CodigoBanco = codigoBanco.Value;
            registro.Nombre = txtNombre.Text.Trim();

            bool seGuardoRegistro = bancoBl.GuardarBanco(registro);

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
                bool existeBanco = bancoBl.ExisteBanco(txtNombre.Text.Trim(), codigoBanco);

                if (existeBanco)
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
            tltBanco.SetToolTip(label, label.Text);
        }
    }
}
