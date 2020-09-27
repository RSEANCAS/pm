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
    public partial class FrmMantenimientoUnidadMedida : RadForm
    {
        int? codigoUnidadMedida;

        UnidadMedidaBl unidadMedidaBl = new UnidadMedidaBl();

        public FrmMantenimientoUnidadMedida(int? codigoUnidadMedida = null)
        {
            InitializeComponent();
            this.codigoUnidadMedida = codigoUnidadMedida;
        }

        private void FrmMantenimientoUnidadMedida_Load(object sender, EventArgs e)
        {
            Text = !codigoUnidadMedida.HasValue ? "Nuevo Unidad de Medida" : "Modificar Unidad de Medida";
            if (codigoUnidadMedida.HasValue)
            {
                CargarUnidadMedida();
            }
        }

        void CargarUnidadMedida()
        {
            UnidadMedidaBe item = unidadMedidaBl.ObtenerUnidadMedida(codigoUnidadMedida.Value);
            txtDescripcion.Text = item.Descripcion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            UnidadMedidaBe registro = new UnidadMedidaBe();
            if (codigoUnidadMedida.HasValue) registro.CodigoUnidadMedida = codigoUnidadMedida.Value;
            registro.Descripcion = txtDescripcion.Text.Trim();

            bool seGuardoRegistro = unidadMedidaBl.GuardarUnidadMedida(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorDescripcion.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (txtDescripcion.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorDescripcion.Text = "Debe ingresar descripción";
                SetToolTipError(lblErrorDescripcion);
            }
            else
            {
                bool existeUnidadMedida = unidadMedidaBl.ExisteUnidadMedida(txtDescripcion.Text.Trim(), codigoUnidadMedida);

                if (existeUnidadMedida)
                {
                    estaValidado = false;
                    lblErrorDescripcion.Text = $"El descripción ya existe";
                    SetToolTipError(lblErrorDescripcion);
                }
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltUnidadMedida.SetToolTip(label, label.Text);
        }
    }
}
