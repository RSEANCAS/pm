using pm.be;
using pm.bl;
using pm.enums;
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
    public partial class FrmMantenimientoCotizacion : RadForm
    {
        int? codigoCotizacion;
        int? codigoCliente, codigoDistritoCliente;
        string nombrePaisCliente, nombreDepartamentoCliente, nombreProvinciaCliente, nombreDistritoCliente;
        string nroDocumentoIdentidadCliente;
        int? codigoVendedor;
        string nroDocumentoIdentidadVendedor;
        List<CotizacionDetalleBe> listaDetalleInicial = new List<CotizacionDetalleBe>();
        List<CotizacionDetalleBe> listaDetalle = new List<CotizacionDetalleBe>();

        CotizacionBl cotizacionBl = new CotizacionBl();
        TipoDocumentoIdentidadBl tipoDocumentoIdentidadBl = new TipoDocumentoIdentidadBl();
        ClienteBl clienteBl = new ClienteBl();
        PersonalBl personalBl = new PersonalBl();
        ControlBusquedaBl controlBusquedaBl = new ControlBusquedaBl();

        public FrmMantenimientoCotizacion(int? codigoCotizacion = null)
        {
            InitializeComponent();
            this.codigoCotizacion = codigoCotizacion;
        }

        private void FrmMantenimientoCotizacion_Load(object sender, EventArgs e)
        {
            Text = !codigoCotizacion.HasValue ? "Nueva Cotización" : "Modificar Cotización";
            ListarCombos();
            dgvDetalle.AutoGenerateColumns = false;
            if (codigoCotizacion.HasValue)
            {
                CargarCotizacion();
            }
            HabilitarModificarYEliminar();
        }

        void CargarCotizacion()
        {
            CotizacionBe item = cotizacionBl.ObtenerCotizacion(codigoCotizacion.Value, true);

            dtpFechaHoraEmision.Value = item.FechaHoraEmision;
            txtNroComprobante.Text = item.NroComprobante.ToString("00000000");
            txtNroPedido.Text = item.NroPedido;
            cbbCodigoMoneda.SelectedValue = item.CodigoMoneda.ToString();

            codigoCliente = item.CodigoCliente;
            CargarCliente(codigoCliente);

            codigoVendedor = item.CodigoVendedor;
            CargarVendedor(codigoVendedor);

            listaDetalleInicial = item.ListaCotizacionDetalle;
            listaDetalle = item.ListaCotizacionDetalle;
            ListarCotizacionDetalle();
        }

        void ListarCombos()
        {
            ListarComboMoneda();
            ListarComboTipoDocumentoIdentidad();
        }

        void ListarComboMoneda()
        {
            List<Combo> listaCombo = Enum<Moneda>.GetCollection().ToList();

            listaCombo.Insert(0, new Combo { Value = "-1", Text = "[Seleccione...]" });

            cbbCodigoMoneda.DataSource = null;
            cbbCodigoMoneda.DataSource = listaCombo;
        }

        void ListarComboTipoDocumentoIdentidad()
        {
            List<TipoDocumentoIdentidadBe> listaCombo = tipoDocumentoIdentidadBl.ListarComboTipoDocumentoIdentidad();
            listaCombo = listaCombo ?? new List<TipoDocumentoIdentidadBe>();
            listaCombo.Insert(0, new TipoDocumentoIdentidadBe { CodigoTipoDocumentoIdentidad = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoTipoDocumentoIdentidadCliente.DataSource = null;
            cbbCodigoTipoDocumentoIdentidadCliente.DataSource = listaCombo.Select(x => x).ToList();

            cbbCodigoTipoDocumentoIdentidadVendedor.DataSource = null;
            cbbCodigoTipoDocumentoIdentidadVendedor.DataSource = listaCombo.Select(x => x).ToList();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (nroDocumentoIdentidadCliente == txtNroDocumentoIdentidadCliente.Text.Trim()) return;
            if (txtNroDocumentoIdentidadCliente.Text.Trim() == "") CargarCliente(null);
            string formulario = this.GetType().FullName;
            string control = ((Control)sender).Name;
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, control, true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item, txtNroDocumentoIdentidadCliente.Text.Trim());
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarCliente(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarCliente(resultado.CodigoCliente);
            }
        }

        void CargarCliente(int? codigoCliente)
        {
            ClienteBe cliente = codigoCliente == null ? null : clienteBl.ObtenerCliente(codigoCliente.Value);
            if (cliente != null)
            {
                this.codigoCliente = cliente.CodigoCliente;
                this.nroDocumentoIdentidadCliente = cliente.NroDocumentoIdentidad;
                cbbCodigoTipoDocumentoIdentidadCliente.SelectedValue = cliente.CodigoTipoDocumentoIdentidad;
                txtNroDocumentoIdentidadCliente.Text = cliente.NroDocumentoIdentidad;
                txtNombresCliente.Text = cliente.Nombres;
                txtCorreoCliente.Text = cliente.Correo;
                txtDireccionCliente.Text = cliente.Direccion;
                if (cliente.Distrito != null)
                {
                    codigoDistritoCliente = cliente.CodigoDistrito;
                    nombrePaisCliente = cliente.Distrito.Provincia.Departamento.Pais.ToString();
                    nombreDepartamentoCliente = cliente.Distrito.Provincia.Departamento.ToString();
                    nombreProvinciaCliente = cliente.Distrito.Provincia.ToString();
                    nombreDistritoCliente = cliente.Distrito.ToString();
                    txtUbicacionCliente.Text = $"{cliente.Distrito.Provincia.Departamento.Pais} - {cliente.Distrito.Provincia.Departamento} - {cliente.Distrito.Provincia} - {cliente.Distrito}";
                }
            }
            else
            {
                this.codigoCliente = null;
                this.nroDocumentoIdentidadCliente = null;
                txtNroDocumentoIdentidadCliente.Text = "";
                txtNombresCliente.Text = "";
            }
        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            if (nroDocumentoIdentidadVendedor == txtNroDocumentoIdentidadVendedor.Text.Trim()) return;
            if (txtNroDocumentoIdentidadVendedor.Text.Trim() == "") CargarVendedor(null);
            string formulario = this.GetType().FullName;
            string control = ((Control)sender).Name;
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, control, true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item, txtNroDocumentoIdentidadVendedor.Text.Trim());
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarVendedor(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarVendedor(resultado.CodigoPersonal);
            }
        }

        void CargarVendedor(int? codigoVendedor)
        {
            PersonalBe vendedor = codigoVendedor == null ? null : personalBl.ObtenerPersonal(codigoVendedor.Value);
            if (vendedor != null)
            {
                this.codigoVendedor = vendedor.CodigoPersonal;
                this.nroDocumentoIdentidadVendedor = vendedor.NroDocumentoIdentidad;
                cbbCodigoTipoDocumentoIdentidadVendedor.SelectedValue = vendedor.CodigoTipoDocumentoIdentidad;
                txtNroDocumentoIdentidadVendedor.Text = vendedor.NroDocumentoIdentidad;
                txtNombresVendedor.Text = vendedor.Nombres;
                txtCorreoVendedor.Text = vendedor.Correo;
            }
            else
            {
                this.codigoVendedor = null;
                this.nroDocumentoIdentidadVendedor = null;
                txtNroDocumentoIdentidadVendedor.Text = "";
                txtNombresVendedor.Text = "";
            }
        }

        void ListarCotizacionDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listaDetalle;
            CalcularTotales();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            FrmMantenimientoCotizacionDetalle frm = new FrmMantenimientoCotizacionDetalle();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                frm.Detalle.CodigoCotizacionDetalle = GenerarCodigoCotizacionDetalleTemporal(frm.Detalle.CodigoProductoIndividual);
                listaDetalle.Add(frm.Detalle);
                listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarCotizacionDetalle();
            }
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (CotizacionDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            FrmMantenimientoCotizacionDetalle frm = new FrmMantenimientoCotizacionDetalle(item);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                listaDetalle[indexData] = frm.Detalle;
                //listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarCotizacionDetalle();
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (CotizacionDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                listaDetalle.RemoveAt(indexData);
                ListarCotizacionDetalle();
            }
        }

        void CalcularTotales()
        {
            listaDetalle = listaDetalle ?? new List<CotizacionDetalleBe>();
            txtTotalImporte.Text = listaDetalle.Sum(x => x.Importe).ToString("#,##0.00");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            CotizacionBe registro = new CotizacionBe();

            if (codigoCotizacion.HasValue) registro.CodigoCotizacion = codigoCotizacion.Value;
            registro.FechaHoraEmision = dtpFechaHoraEmision.Value;
            registro.NroComprobante = int.Parse(string.IsNullOrEmpty(txtNroComprobante.Text.Trim()) ? "0" : txtNroComprobante.Text.Trim());
            registro.NroPedido = txtNroPedido.Text.Trim();
            registro.CodigoMoneda = int.Parse(cbbCodigoMoneda.SelectedValue.ToString());
            registro.CodigoCliente = codigoCliente.Value;
            registro.CodigoVendedor = codigoVendedor.Value;
            registro.ListaCotizacionDetalle = listaDetalle;
            registro.ListaCotizacionDetalleEliminar = listaDetalleInicial == null ? null : listaDetalleInicial.Where(x => listaDetalle.Count(y => y.CodigoCotizacionDetalle == x.CodigoCotizacionDetalle) == 0).Select(x => x.CodigoCotizacionDetalle).ToArray();
            registro.TotalImporte = listaDetalle.Sum(x => x.Importe);

            bool seGuardoRegistro = cotizacionBl.GuardarCotizacion(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardarEmitir_Click(object sender, EventArgs e)
        {

        }

        void LimpiarErrores()
        {
            lblErrorFechaHoraEmision.Text = "";
            lblErrorNroComprobante.Text = "";
            lblErrorNroPedido.Text = "";
            lblErrorCodigoMoneda.Text = "";
            lblErrorCliente.Text = "";
            lblErrorDetalle.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (cbbCodigoMoneda.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoMoneda.Text = "Debe seleccionar una moneda";
                SetToolTipError(lblErrorCodigoMoneda);
            }

            if (txtNroPedido.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorNroPedido.Text = "Debe ingresar N° de pedido";
                SetToolTipError(lblErrorNroPedido);
            }

            if (codigoCliente == null)
            {
                estaValidado = false;
                lblErrorCliente.Text = "Debe seleccionar cliente";
                SetToolTipError(lblErrorCliente);
            }

            if ((listaDetalle ?? new List<CotizacionDetalleBe>()).Count == 0)
            {
                estaValidado = false;
                lblErrorDetalle.Text = "No tiene registros de detalle";
                SetToolTipError(lblErrorDetalle);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltCotizacion.SetToolTip(label, label.Text);
        }

        private void dgvDetalle_SelectionChanged(object sender, EventArgs e)
        {
            HabilitarModificarYEliminar();
        }

        void HabilitarModificarYEliminar()
        {
            bool habilitarEditarYEliminar = dgvDetalle.CurrentRow == null ? false : dgvDetalle.CurrentRow.Index != 1;

            btnModificarDetalle.Enabled = habilitarEditarYEliminar;
            btnEliminarDetalle.Enabled = habilitarEditarYEliminar;
        }

        int GenerarCodigoCotizacionDetalleTemporal(int codigoProductoIndividual)
        {
            int codigoCotizacionDetalle = 0;
            listaDetalleInicial = listaDetalleInicial ?? new List<CotizacionDetalleBe>();
            var registro = listaDetalleInicial.FirstOrDefault(x => x.CodigoProductoIndividual == codigoProductoIndividual);
            listaDetalle = listaDetalle ?? new List<CotizacionDetalleBe>();
            if (registro == null) codigoCotizacionDetalle = listaDetalle.Select(x => x.CodigoCotizacionDetalle).DefaultIfEmpty().Min() - 1;
            else codigoCotizacionDetalle = registro.CodigoCotizacionDetalle;
            return codigoCotizacionDetalle;
        }
    }
}
