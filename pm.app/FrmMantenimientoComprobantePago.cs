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
using static pm.enums.Enums;

namespace pm.app
{
    public partial class FrmMantenimientoComprobantePago : Form
    {
        int? codigoComprobantePago;

        string fromFormName;
        int? codigoMoneda;
        int? codigoCliente, codigoDistritoCliente;
        string nombrePaisCliente, nombreDepartamentoCliente, nombreProvinciaCliente, nombreDistritoCliente;
        string nroDocumentoIdentidadCliente;

        List<ComprobantePagoDetalleBe> listaDetalleInicial = new List<ComprobantePagoDetalleBe>();
        List<ComprobantePagoDetalleBe> listaDetalle = new List<ComprobantePagoDetalleBe>();

        ComprobantePagoBl comprobantePagoBl = new ComprobantePagoBl();
        SerieBl serieBl = new SerieBl();
        TipoDocumentoIdentidadBl tipoDocumentoIdentidadBl = new TipoDocumentoIdentidadBl();
        ClienteBl proveedorBl = new ClienteBl();
        ControlBusquedaBl controlBusquedaBl = new ControlBusquedaBl();

        public FrmMantenimientoComprobantePago(int? codigoComprobantePago = null)
        {
            InitializeComponent();
            this.codigoComprobantePago = codigoComprobantePago;
        }

        public FrmMantenimientoComprobantePago(List<ComprobantePagoDetalleBe> listaComprobantePagoDetalle, int codigoCliente, int codigoMoneda, string fromFormName)
        {
            InitializeComponent();
            this.codigoCliente = codigoCliente;
            this.codigoMoneda = codigoMoneda;
            this.listaDetalle = listaComprobantePagoDetalle;
            this.fromFormName = fromFormName;
        }

        private void FrmMantenimientoComprobantePago_Load(object sender, EventArgs e)
        {
            Text = !codigoComprobantePago.HasValue ? "Nuevo Comprobante de Pago" : "Modificar Comprobante de Pago";
            ListarCombos();
            dgvDetalle.AutoGenerateColumns = false;
            if (codigoComprobantePago.HasValue)
            {
                CargarComprobantePago();
            }

            if (fromFormName != "FrmComprobantePago")
            {
                gpbCliente.Enabled = false;
                if (codigoCliente.HasValue) CargarCliente(codigoCliente);
                if (codigoMoneda.HasValue)
                {
                    cbbCodigoMoneda.SelectedValue = codigoMoneda.Value.ToString();
                    cbbCodigoMoneda.Enabled = false;
                }
                ListarComprobantePagoDetalle();
            }
            HabilitarBotonesGrilla();
        }

        void CargarComprobantePago()
        {
            ComprobantePagoBe item = comprobantePagoBl.ObtenerComprobantePago(codigoComprobantePago.Value, true, true);

            dtpFechaHoraPago.Value = item.FechaHoraPago;
            cbbCodigoSerie.SelectedValue = item.CodigoSerie;
            txtNroComprobante.Text = item.NroComprobante.ToString("00000000");
            cbbCodigoMoneda.SelectedValue = item.CodigoMoneda.ToString();

            codigoCliente = item.CodigoCliente;
            CargarCliente(codigoCliente);

            listaDetalleInicial = item.ListaComprobantePagoDetalle;
            listaDetalle = item.ListaComprobantePagoDetalle;
            ListarComprobantePagoDetalle();
        }

        void ListarCombos()
        {
            ListarComboSerie();
            ListarComboMoneda();
            ListarComboTipoDocumentoIdentidad();
        }

        void ListarComboSerie()
        {
            List<SerieBe> listaCombo = serieBl.ListarComboSerie((int)TipoComprobante.ComprobantePago);
            listaCombo = listaCombo ?? new List<SerieBe>();
            listaCombo.Insert(0, new SerieBe { CodigoSerie = -1, Serial = "[Seleccione...]" });

            cbbCodigoSerie.DataSource = null;
            cbbCodigoSerie.DataSource = listaCombo;
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
            ClienteBe proveedor = codigoCliente == null ? null : proveedorBl.ObtenerCliente(codigoCliente.Value);
            if (proveedor != null)
            {
                this.codigoCliente = proveedor.CodigoCliente;
                this.nroDocumentoIdentidadCliente = proveedor.NroDocumentoIdentidad;
                cbbCodigoTipoDocumentoIdentidadCliente.SelectedValue = proveedor.CodigoTipoDocumentoIdentidad;
                txtNroDocumentoIdentidadCliente.Text = proveedor.NroDocumentoIdentidad;
                txtNombresCliente.Text = proveedor.Nombres;
                txtCorreoCliente.Text = proveedor.Correo;
                txtDireccionCliente.Text = proveedor.Direccion;
                if (proveedor.Distrito != null)
                {
                    codigoDistritoCliente = proveedor.CodigoDistrito;
                    nombrePaisCliente = proveedor.Distrito.Provincia.Departamento.Pais.ToString();
                    nombreDepartamentoCliente = proveedor.Distrito.Provincia.Departamento.ToString();
                    nombreProvinciaCliente = proveedor.Distrito.Provincia.ToString();
                    nombreDistritoCliente = proveedor.Distrito.ToString();
                    txtUbicacionCliente.Text = $"{proveedor.Distrito.Provincia.Departamento.Pais} - {proveedor.Distrito.Provincia.Departamento} - {proveedor.Distrito.Provincia} - {proveedor.Distrito}";
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

        void ListarComprobantePagoDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listaDetalle;
            CalcularTotales();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            FrmMantenimientoComprobantePagoDetalle frm = new FrmMantenimientoComprobantePagoDetalle();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                frm.Detalle.CodigoComprobantePagoDetalle = GenerarCodigoComprobantePagoDetalleTemporal(frm.Detalle.CodigoTipoDocumentoPago, frm.Detalle.CodigoDocumentoPago);
                listaDetalle.Add(frm.Detalle);
                listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarComprobantePagoDetalle();
            }
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (ComprobantePagoDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            FrmMantenimientoComprobantePagoDetalle frm = new FrmMantenimientoComprobantePagoDetalle(item);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                listaDetalle[indexData] = frm.Detalle;
                //listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarComprobantePagoDetalle();
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (ComprobantePagoDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                listaDetalle.RemoveAt(indexData);
                ListarComprobantePagoDetalle();
            }
        }

        void CalcularTotales()
        {
            listaDetalle = listaDetalle ?? new List<ComprobantePagoDetalleBe>();
            txtMonto.Text = listaDetalle.Sum(x => x.ImportePagar).ToString("#,##0.00");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            ComprobantePagoBe registro = new ComprobantePagoBe();

            if (codigoComprobantePago.HasValue) registro.CodigoComprobantePago = codigoComprobantePago.Value;
            registro.FechaHoraPago = dtpFechaHoraPago.Value;
            registro.CodigoSerie = (int)cbbCodigoSerie.SelectedValue;
            if (!string.IsNullOrEmpty(txtNroComprobante.Text)) registro.NroComprobante = int.Parse(txtNroComprobante.Text.Trim());
            registro.CodigoMoneda = int.Parse(cbbCodigoMoneda.SelectedValue.ToString());
            registro.CodigoCliente = codigoCliente.Value;
            registro.ListaComprobantePagoDetalle = listaDetalle;
            registro.ListaComprobantePagoDetalleEliminar = listaDetalleInicial == null ? null : listaDetalleInicial.Where(x => listaDetalle.Count(y => y.CodigoComprobantePagoDetalle == x.CodigoComprobantePagoDetalle) == 0).Select(x => x.CodigoComprobantePagoDetalle).ToArray();
            registro.Monto = listaDetalle.Sum(x => x.ImportePagar);

            bool seGuardoRegistro = comprobantePagoBl.GuardarComprobantePago(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorFechaHoraPago.Text = "";
            lblErrorCodigoSerie.Text = "";
            lblErrorSerie.Text = "";
            lblErrorNroComprobante.Text = "";
            lblErrorCodigoMoneda.Text = "";
            lblErrorCliente.Text = "";
            lblErrorDetalle.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (cbbCodigoSerie.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoSerie.Text = "Debe seleccionar una serie";
                SetToolTipError(lblErrorCodigoSerie);
            }

            if (!string.IsNullOrEmpty(txtNroComprobante.Text.Trim()))
            //{
            //    estaValidado = false;
            //    lblErrorNroComprobante.Text = "Debe ingresar número";
            //    SetToolTipError(lblErrorNroComprobante);
            //}
            //else
            {
                decimal numero = 0;

                if (!decimal.TryParse(txtNroComprobante.Text.Trim(), out numero))
                {
                    estaValidado = false;
                    lblErrorNroComprobante.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorNroComprobante);
                }
            }

            if (cbbCodigoMoneda.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoSerie.Text = "Debe seleccionar una moneda";
                SetToolTipError(lblErrorCodigoSerie);
            }

            if (codigoCliente == null)
            {
                estaValidado = false;
                lblErrorCliente.Text = "Debe seleccionar proveedor";
                SetToolTipError(lblErrorCliente);
            }

            if ((listaDetalle ?? new List<ComprobantePagoDetalleBe>()).Count == 0)
            {
                estaValidado = false;
                lblErrorDetalle.Text = "No tiene registros de detalle";
                SetToolTipError(lblErrorDetalle);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltComprobantePago.SetToolTip(label, label.Text);
        }

        private void dgvDetalle_SelectionChanged(object sender, EventArgs e)
        {
            HabilitarBotonesGrilla();
        }

        void HabilitarBotonesGrilla()
        {
            bool habilitarBoton = false;
            if (string.IsNullOrEmpty(fromFormName))
            {
                habilitarBoton = dgvDetalle.CurrentRow == null ? false : dgvDetalle.CurrentRow.Index != -1;

                btnModificarDetalle.Enabled = habilitarBoton;
                btnEliminarDetalle.Enabled = habilitarBoton;
            }
            else
            {
                btnAgregarDetalle.Enabled = habilitarBoton;
                btnEliminarDetalle.Enabled = habilitarBoton;
            }
        }

        int GenerarCodigoComprobantePagoDetalleTemporal(int codigoTipoDocumentoPago, int codigoDocumentoPago)
        {
            int codigoComprobantePagoDetalle = 0;
            listaDetalleInicial = listaDetalleInicial ?? new List<ComprobantePagoDetalleBe>();
            var registro = listaDetalleInicial.FirstOrDefault(x => x.CodigoTipoDocumentoPago == codigoTipoDocumentoPago && x.CodigoDocumentoPago == codigoDocumentoPago);
            listaDetalle = listaDetalle ?? new List<ComprobantePagoDetalleBe>();
            if (registro == null) codigoComprobantePagoDetalle = listaDetalle.Select(x => x.CodigoComprobantePagoDetalle).DefaultIfEmpty().Min() - 1;
            else codigoComprobantePagoDetalle = registro.CodigoComprobantePagoDetalle;
            return codigoComprobantePagoDetalle;
        }
    }
}
