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
    public partial class FrmMantenimientoMotivoNota : RadForm
    {
        int? codigoMotivoNota;

        MotivoNotaBl motivoNotaBl = new MotivoNotaBl();
        TipoComprobanteBl tipoComprobanteBl = new TipoComprobanteBl();

        public FrmMantenimientoMotivoNota(int? codigoMotivoNota = null)
        {
            InitializeComponent();
            this.codigoMotivoNota = codigoMotivoNota;
        }

        private void FrmMantenimientoMotivoNota_Load(object sender, EventArgs e)
        {
            Text = !codigoMotivoNota.HasValue ? "Nuevo Motivo Nota" : "Modificar Motivo Nota";
            ListarCombos();
            if (codigoMotivoNota.HasValue)
            {
                CargarMotivoNota();
            }
        }

        void CargarMotivoNota()
        {
            MotivoNotaBe item = motivoNotaBl.ObtenerMotivoNota(codigoMotivoNota.Value);
            txtDescripcion.Text = item.Descripcion;
        }

        void ListarCombos()
        {
            ListarComboTipoComprobante();
        }

        void ListarComboTipoComprobante()
        {
            List<TipoComprobanteBe> listaCombo = tipoComprobanteBl.ListarComboTipoComprobante();
            listaCombo = listaCombo ?? new List<TipoComprobanteBe>();
            listaCombo = listaCombo.Where(x => (new int[] { (int)TipoComprobante.NotaCredito, (int)TipoComprobante.NotaDebito }).Contains(x.CodigoTipoComprobante)).ToList();
            listaCombo.Insert(0, new TipoComprobanteBe { CodigoTipoComprobante = -1, Nombre = "[Seleccione...]" });

            cbbCodigoTipoComprobante.DataSource = null;
            cbbCodigoTipoComprobante.DataSource = listaCombo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            MotivoNotaBe registro = new MotivoNotaBe();
            if (codigoMotivoNota.HasValue) registro.CodigoMotivoNota = codigoMotivoNota.Value;
            registro.Descripcion = txtDescripcion.Text.Trim();
            registro.CodigoTipoComprobante = (int)cbbCodigoTipoComprobante.SelectedValue;

            bool seGuardoRegistro = motivoNotaBl.GuardarMotivoNota(registro);

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
            lblErrorCodigoTipoComprobante.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (txtDescripcion.Text.Trim() == "" || cbbCodigoTipoComprobante.SelectedIndex == 0)
            {
                if (txtDescripcion.Text.Trim() == "")
                {
                    estaValidado = false;
                    lblErrorDescripcion.Text = "Debe ingresar nombre";
                    SetToolTipError(lblErrorDescripcion);
                }

                if (cbbCodigoTipoComprobante.SelectedIndex == 0)
                {
                    estaValidado = false;
                    lblErrorCodigoTipoComprobante.Text = "Debe seleccionar tipo de comprobante";
                    SetToolTipError(lblErrorCodigoTipoComprobante);
                }
            }
            else
            {
                bool existeMotivoNota = motivoNotaBl.ExisteMotivoNota(txtDescripcion.Text.Trim(), (int)cbbCodigoTipoComprobante.SelectedValue, codigoMotivoNota);

                if (existeMotivoNota)
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
            tltMotivoNota.SetToolTip(label, label.Text);
        }
    }
}
