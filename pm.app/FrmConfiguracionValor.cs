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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConfiguracionValorBe registro = new ConfiguracionValorBe();
            registro.CodigoTipoComprobanteGuiaRemision = (int)cbbCodigoTipoComprobanteGuiaRemision.SelectedValue;
            registro.CodigoTransportistaGuiaRemision = codigoTransportistaGuiaRemision;

            bool seGuardoRegistro = configuracionValorBl.GuardarConfiguracionValor(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
