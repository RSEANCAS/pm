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
    public partial class FrmMantenimientoMotivoTraslado : RadForm
    {
        int? codigoMotivoTraslado;

        MotivoTrasladoBl motivoTrasladoBl = new MotivoTrasladoBl();

        public FrmMantenimientoMotivoTraslado(int? codigoMotivoTraslado = null)
        {
            InitializeComponent();
            this.codigoMotivoTraslado = codigoMotivoTraslado;
        }

        private void FrmMantenimientoMotivoTraslado_Load(object sender, EventArgs e)
        {
            Text = !codigoMotivoTraslado.HasValue ? "Nuevo Motivo Traslado" : "Modificar Motivo Traslado";
            if (codigoMotivoTraslado.HasValue)
            {
                CargarMotivoTraslado();
            }
        }

        void CargarMotivoTraslado()
        {
            MotivoTrasladoBe item = motivoTrasladoBl.ObtenerMotivoTraslado(codigoMotivoTraslado.Value);
            txtDescripcion.Text = item.Descripcion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            MotivoTrasladoBe registro = new MotivoTrasladoBe();
            if (codigoMotivoTraslado.HasValue) registro.CodigoMotivoTraslado = codigoMotivoTraslado.Value;
            registro.Descripcion = txtDescripcion.Text.Trim();

            bool seGuardoRegistro = motivoTrasladoBl.GuardarMotivoTraslado(registro);

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
                lblErrorDescripcion.Text = "Debe ingresar nombre";
                SetToolTipError(lblErrorDescripcion);
            }
            else
            {
                bool existeMotivoTraslado = motivoTrasladoBl.ExisteMotivoTraslado(txtDescripcion.Text.Trim(), codigoMotivoTraslado);

                if (existeMotivoTraslado)
                {
                    estaValidado = false;
                    lblErrorDescripcion.Text = $"El nombre ya existe";
                    SetToolTipError(lblErrorDescripcion);
                }
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltMotivoTraslado.SetToolTip(label, label.Text);
        }
    }
}
