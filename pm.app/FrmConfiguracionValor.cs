using pm.be;
using pm.bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pm.enums.Enums;

namespace pm.app
{
    public partial class FrmConfiguracionValor : Form
    {
        int? codigoTransportistaGuiaRemision;

        ConfiguracionValorBl configuracionValorBl = new ConfiguracionValorBl();
        TipoComprobanteBl tipoComprobanteBl = new TipoComprobanteBl();
        ProveedorBl proveedorBl = new ProveedorBl();
        ControlBusquedaBl controlBusquedaBl = new ControlBusquedaBl();

        public FrmConfiguracionValor()
        {
            InitializeComponent();
        }

        private void FrmConfiguracionValor_Load(object sender, EventArgs e)
        {
            ListarCombos();
            CargarConfiguracionValor();
        }

        void ListarCombos()
        {
            ListarComboTipoComprobante();
        }

        void ListarComboTipoComprobante()
        {
            List<TipoComprobanteBe> listaCombo = tipoComprobanteBl.ListarComboTipoComprobante();
            listaCombo = listaCombo ?? new List<TipoComprobanteBe>();

            var listaTipoComprobanteGuiaRemision = listaCombo.Where(x => (new int[] { (int)TipoComprobante.GuiaRemisionRemitente, (int)TipoComprobante.GuiaRemisionTransportista }).Contains(x.CodigoTipoComprobante)).ToList();
            listaTipoComprobanteGuiaRemision.Insert(0, new TipoComprobanteBe { CodigoTipoComprobante = -1, Nombre = "[Ninguno...]" });

            cbbCodigoTipoComprobanteGuiaRemision.DataSource = null;
            cbbCodigoTipoComprobanteGuiaRemision.DataSource = listaTipoComprobanteGuiaRemision;
        }

        private void btnBuscarTransportistaGuiaRemision_Click(object sender, EventArgs e)
        {
            string formulario = this.GetType().FullName;
            string control = ((Control)sender).Name;
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, control, true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item, txtNroDocIdentidadTransportistaGuiaRemision.Text.Trim());
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarTransportistaGuiaRemision(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarTransportistaGuiaRemision(resultado.CodigoProveedor);
            }
        }

        void CargarTransportistaGuiaRemision(int? codigoTransportista)
        {
            ProveedorBe transportista = codigoTransportista == null ? null : proveedorBl.ObtenerProveedor(codigoTransportista.Value);
            if (transportista != null)
            {
                this.codigoTransportistaGuiaRemision = transportista.CodigoProveedor;
                txtNroDocIdentidadTransportistaGuiaRemision.Text = transportista.NroDocumentoIdentidad;
                txtNombresTransportistaGuiaRemision.Text = transportista.Nombres;
            }
            else
            {
                this.codigoTransportistaGuiaRemision = null;
                txtNroDocIdentidadTransportistaGuiaRemision.Text = "";
                txtNombresTransportistaGuiaRemision.Text = "";
            }
        }

        void CargarConfiguracionValor()
        {
            var item = configuracionValorBl.ObtenerConfiguracionValor();
            cbbCodigoTipoComprobanteGuiaRemision.SelectedValue = item.CodigoTipoComprobanteGuiaRemision;
            CargarTransportistaGuiaRemision(item.CodigoTransportistaGuiaRemision);
            txtRutaFacturacionElectronicaSunat.Text = item.RutaFacturacionElectronica;
            txtRutaCertificadoSunat.Text = item.RutaCertificado;
            txtContraseñaCertificadoSunat.Text = item.ContraseñaCertificado;
            txtUsuarioSOLSunat.Text = item.UsuarioSOL;
            txtContraseñaSOLSunat.Text = item.ContraseñaSOL;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            ConfiguracionValorBe registro = new ConfiguracionValorBe();
            registro.CodigoTipoComprobanteGuiaRemision = (int)cbbCodigoTipoComprobanteGuiaRemision.SelectedValue;
            registro.CodigoTransportistaGuiaRemision = codigoTransportistaGuiaRemision;
            registro.RutaFacturacionElectronica = txtRutaFacturacionElectronicaSunat.Text.Trim();
            registro.RutaCertificado = txtRutaCertificadoSunat.Text.Trim();
            registro.ContraseñaCertificado = txtContraseñaCertificadoSunat.Text.Trim();
            registro.UsuarioSOL = txtUsuarioSOLSunat.Text.Trim();
            registro.ContraseñaSOL = txtContraseñaSOLSunat.Text.Trim();

            bool seGuardoRegistro = configuracionValorBl.GuardarConfiguracionValor(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorRutaFacturacionElectronicaSunat.Text = "";
            lblErrorRutaCertificadoSunat.Text = "";
            lblErrorContraseñaCertificadoSunat.Text = "";
            lblErrorUsuarioSOLSunat.Text = "";
            lblErrorContraseñaSOLSunat.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (string.IsNullOrEmpty(txtRutaFacturacionElectronicaSunat.Text.Trim()))
            {
                estaValidado = false;
                lblErrorRutaFacturacionElectronicaSunat.Text = "Debe ingresar la ruta del directorio facturación electrónica";
                SetToolTipError(lblErrorRutaFacturacionElectronicaSunat);
            }
            else
            {
                if (!Directory.Exists(txtRutaFacturacionElectronicaSunat.Text.Trim()))
                {
                    estaValidado = false;
                    lblErrorRutaFacturacionElectronicaSunat.Text = "La ruta del directorio ingresada no existe";
                    SetToolTipError(lblErrorRutaFacturacionElectronicaSunat);
                }
            }

            if (string.IsNullOrEmpty(txtRutaCertificadoSunat.Text.Trim()))
            {
                estaValidado = false;
                lblErrorRutaCertificadoSunat.Text = "Debe ingresar la ruta del archivo certificado";
                SetToolTipError(lblErrorRutaCertificadoSunat);
            }
            else
            {
                if (!File.Exists(txtRutaCertificadoSunat.Text.Trim()))
                {
                    estaValidado = false;
                    lblErrorRutaCertificadoSunat.Text = "La ruta del archivo ingresada no existe";
                    SetToolTipError(lblErrorRutaCertificadoSunat);
                }
            }

            if (string.IsNullOrEmpty(txtContraseñaCertificadoSunat.Text.Trim()))
            {
                estaValidado = false;
                lblErrorContraseñaCertificadoSunat.Text = "Debe ingresar la contraseña del certificado";
                SetToolTipError(lblErrorContraseñaCertificadoSunat);
            }

            if (string.IsNullOrEmpty(txtUsuarioSOLSunat.Text.Trim()))
            {
                estaValidado = false;
                lblErrorUsuarioSOLSunat.Text = "Debe ingresar el usuario SOL";
                SetToolTipError(lblErrorUsuarioSOLSunat);
            }

            if (string.IsNullOrEmpty(txtContraseñaSOLSunat.Text.Trim()))
            {
                estaValidado = false;
                lblErrorContraseñaSOLSunat.Text = "Debe ingresar la contraseña SOL";
                SetToolTipError(lblErrorContraseñaSOLSunat);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltConfiguracionValor.SetToolTip(label, label.Text);
        }
    }
}
