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
    public partial class FrmMantenimientoComprobanteCompra : RadForm
    {
        int? codigoComprobanteCompra;

        int? codigoProveedor, codigoDistritoProveedor;
        string nombrePaisProveedor, nombreDepartamentoProveedor, nombreProvinciaProveedor, nombreDistritoProveedor;
        string nroDocumentoIdentidadProveedor;

        List<ComprobanteCompraDetalleBe> listaDetalleInicial = new List<ComprobanteCompraDetalleBe>();
        List<ComprobanteCompraDetalleBe> listaDetalle = new List<ComprobanteCompraDetalleBe>();
        List<ProductoIndividualBe> listaProductoIndividual = new List<ProductoIndividualBe>();

        ComprobanteCompraBl comprobanteCompraBl = new ComprobanteCompraBl();
        TipoComprobanteBl tipoComprobanteBl = new TipoComprobanteBl();
        TipoDocumentoIdentidadBl tipoDocumentoIdentidadBl = new TipoDocumentoIdentidadBl();
        ProveedorBl proveedorBl = new ProveedorBl();
        ControlBusquedaBl controlBusquedaBl = new ControlBusquedaBl();

        public FrmMantenimientoComprobanteCompra(int? codigoComprobanteCompra = null)
        {
            InitializeComponent();
            this.codigoComprobanteCompra = codigoComprobanteCompra;
        }

        private void FrmMantenimientoComprobanteCompra_Load(object sender, EventArgs e)
        {
            Text = !codigoComprobanteCompra.HasValue ? "Nuevo Comprobante de Compra" : "Modificar Comprobante de Compra";
            dtpFechaHoraRegistro_ValueChanged(dtpFechaHoraRegistro, new EventArgs());
            ListarCombos();
            dgvDetalle.AutoGenerateColumns = false;
            if (codigoComprobanteCompra.HasValue)
            {
                CargarComprobanteCompra();
            }
            else CalcularTotales();
            HabilitarBotonesGrilla();
        }

        void CargarComprobanteCompra()
        {
            ComprobanteCompraBe item = comprobanteCompraBl.ObtenerComprobanteCompra(codigoComprobanteCompra.Value, true, true);

            dtpFechaHoraRegistro.Value = item.FechaHoraRegistro;
            cbbCodigoTipoComprobante.SelectedValue = item.CodigoTipoComprobante;
            txtSerie.Text = item.Serie;
            txtNumero.Text = item.Numero.ToString("00000000");
            dtpFechaCompra.MinDate = new DateTime(item.FechaHoraRegistro.Year, item.FechaHoraRegistro.Month, item.FechaHoraRegistro.Day);
            dtpFechaCompra.Value = item.FechaCompra;
            txtSerieGuia.Text = item.SerieGuia;
            txtNumeroGuia.Text = item.NumeroGuia.ToString("00000000");

            codigoProveedor = item.CodigoProveedor;
            CargarProveedor(codigoProveedor);

            listaDetalleInicial = item.ListaComprobanteCompraDetalle;
            listaDetalle = item.ListaComprobanteCompraDetalle;
            listaProductoIndividual = item.ListaProductoIndividual ?? new List<ProductoIndividualBe>();
            ListarComprobanteCompraDetalle();
        }

        void ListarCombos()
        {
            ListarComboTipoComprobante();
            ListarComboTipoDocumentoIdentidad();
        }

        void ListarComboTipoComprobante()
        {
            List<TipoComprobanteBe> listaCombo = tipoComprobanteBl.ListarComboTipoComprobante();
            listaCombo = listaCombo ?? new List<TipoComprobanteBe>();
            listaCombo = listaCombo.Where(x => (new int[] { (int)TipoComprobante.Boleta, (int)TipoComprobante.Factura }).Contains(x.CodigoTipoComprobante)).ToList();
            listaCombo.Insert(0, new TipoComprobanteBe { CodigoTipoComprobante = -1, Nombre = "[Seleccione...]" });

            cbbCodigoTipoComprobante.DataSource = null;
            cbbCodigoTipoComprobante.DataSource = listaCombo;
        }

        void ListarComboTipoDocumentoIdentidad()
        {
            List<TipoDocumentoIdentidadBe> listaCombo = tipoDocumentoIdentidadBl.ListarComboTipoDocumentoIdentidad();
            listaCombo = listaCombo ?? new List<TipoDocumentoIdentidadBe>();
            listaCombo.Insert(0, new TipoDocumentoIdentidadBe { CodigoTipoDocumentoIdentidad = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoTipoDocumentoIdentidadProveedor.DataSource = null;
            cbbCodigoTipoDocumentoIdentidadProveedor.DataSource = listaCombo.Select(x => x).ToList();
        }

        private void dtpFechaHoraRegistro_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaCompra.MinDate = dtpFechaHoraRegistro.Value;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (nroDocumentoIdentidadProveedor == txtNroDocumentoIdentidadProveedor.Text.Trim()) return;
            if (txtNroDocumentoIdentidadProveedor.Text.Trim() == "") CargarProveedor(null);
            string formulario = this.GetType().FullName;
            string control = ((Control)sender).Name;
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, control, true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item, txtNroDocumentoIdentidadProveedor.Text.Trim());
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarProveedor(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarProveedor(resultado.CodigoProveedor);
            }
        }

        void CargarProveedor(int? codigoProveedor)
        {
            ProveedorBe proveedor = codigoProveedor == null ? null : proveedorBl.ObtenerProveedor(codigoProveedor.Value);
            if (proveedor != null)
            {
                this.codigoProveedor = proveedor.CodigoProveedor;
                this.nroDocumentoIdentidadProveedor = proveedor.NroDocumentoIdentidad;
                cbbCodigoTipoDocumentoIdentidadProveedor.SelectedValue = proveedor.CodigoTipoDocumentoIdentidad;
                txtNroDocumentoIdentidadProveedor.Text = proveedor.NroDocumentoIdentidad;
                txtNombresProveedor.Text = proveedor.Nombres;
                txtCorreoProveedor.Text = proveedor.Correo;
                txtDireccionProveedor.Text = proveedor.Direccion;
                if (proveedor.Distrito != null)
                {
                    codigoDistritoProveedor = proveedor.CodigoDistrito;
                    nombrePaisProveedor = proveedor.Distrito.Provincia.Departamento.Pais.ToString();
                    nombreDepartamentoProveedor = proveedor.Distrito.Provincia.Departamento.ToString();
                    nombreProvinciaProveedor = proveedor.Distrito.Provincia.ToString();
                    nombreDistritoProveedor = proveedor.Distrito.ToString();
                    txtUbicacionProveedor.Text = $"{proveedor.Distrito.Provincia.Departamento.Pais} - {proveedor.Distrito.Provincia.Departamento} - {proveedor.Distrito.Provincia} - {proveedor.Distrito}";
                }
            }
            else
            {
                this.codigoProveedor = null;
                this.nroDocumentoIdentidadProveedor = null;
                txtNroDocumentoIdentidadProveedor.Text = "";
                txtNombresProveedor.Text = "";
            }
        }

        void ListarComprobanteCompraDetalle()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = listaDetalle;
            CalcularTotales();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            FrmMantenimientoComprobanteCompraDetalle frm = new FrmMantenimientoComprobanteCompraDetalle();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                frm.Detalle.CodigoComprobanteCompraDetalle = GenerarCodigoComprobanteCompraDetalleTemporal(frm.Detalle.CodigoProducto);
                listaDetalle.Add(frm.Detalle);
                listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarComprobanteCompraDetalle();
            }
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (ComprobanteCompraDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            List<ProductoIndividualBe> lista = listaProductoIndividual.Where(x => x.CodigoComprobanteCompraDetalle == item.CodigoComprobanteCompraDetalle).ToList();

            FrmMantenimientoComprobanteCompraDetalle frm = new FrmMantenimientoComprobanteCompraDetalle(item, lista.Count);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ListaDetalleInicial = this.listaDetalleInicial;
            frm.ListaDetalleActual = this.listaDetalle;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                listaDetalle[indexData] = frm.Detalle;
                //listaDetalle = listaDetalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                ListarComprobanteCompraDetalle();
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (ComprobanteCompraDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                listaDetalle.RemoveAt(indexData);
                ListarComprobanteCompraDetalle();
            }
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvDetalle.CurrentRow.Index;

            var item = (ComprobanteCompraDetalleBe)dgvDetalle.Rows[rowIndex].DataBoundItem;
            int indexData = listaDetalle.IndexOf(item);

            List<ProductoIndividualBe> lista = listaProductoIndividual.Where(x => x.CodigoComprobanteCompraDetalle == item.CodigoComprobanteCompraDetalle).ToList();

            FrmComprobanteCompraDetalleProductoIndividual frm = new FrmComprobanteCompraDetalleProductoIndividual(item, lista);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                listaProductoIndividual = frm.Detalle;
                bool flagCompleto = listaProductoIndividual.Count == item.Cantidad;
                listaDetalle[indexData].FlagCompleto = flagCompleto;
                ListarComprobanteCompraDetalle();
            }
        }

        void CalcularTotales()
        {
            listaDetalle = listaDetalle ?? new List<ComprobanteCompraDetalleBe>();
            txtTotalImporte.Text = listaDetalle.Sum(x => x.ImporteTotal).ToString("#,##0.00");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            ComprobanteCompraBe registro = new ComprobanteCompraBe();

            if (codigoComprobanteCompra.HasValue) registro.CodigoComprobanteCompra = codigoComprobanteCompra.Value;
            registro.FechaHoraRegistro = dtpFechaHoraRegistro.Value;
            registro.CodigoTipoComprobante = (int)cbbCodigoTipoComprobante.SelectedValue;
            registro.Serie = txtSerie.Text.Trim();
            registro.Numero = int.Parse(txtNumero.Text.Trim());
            registro.FechaCompra = dtpFechaCompra.Value;
            registro.SerieGuia = txtSerieGuia.Text.Trim();
            registro.NumeroGuia = int.Parse(txtNumeroGuia.Text.Trim());
            registro.CodigoProveedor = codigoProveedor.Value;
            registro.ListaComprobanteCompraDetalle = listaDetalle;
            registro.ListaComprobanteCompraDetalleEliminar = listaDetalleInicial == null ? null : listaDetalleInicial.Where(x => listaDetalle.Count(y => y.CodigoComprobanteCompraDetalle == x.CodigoComprobanteCompraDetalle) == 0).Select(x => x.CodigoComprobanteCompraDetalle).ToArray();
            registro.ListaProductoIndividual = listaProductoIndividual;
            registro.FlagCompleto = listaDetalle.Count == listaDetalle.Count(x => x.FlagCompleto);
            registro.TotalImporte = listaDetalle.Sum(x => x.ImporteTotal);

            bool seGuardoRegistro = comprobanteCompraBl.GuardarComprobanteCompra(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorFechaHoraRegistro.Text = "";
            lblErrorCodigoTipoComprobante.Text = "";
            lblErrorSerie.Text = "";
            lblErrorNumero.Text = "";
            lblErrorFechaCompra.Text = "";
            lblErrorSerieGuia.Text = "";
            lblErrorNumeroGuia.Text = "";
            lblErrorProveedor.Text = "";
            lblErrorDetalle.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (cbbCodigoTipoComprobante.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoTipoComprobante.Text = "Debe seleccionar un tipo comprobante";
                SetToolTipError(lblErrorCodigoTipoComprobante);
            }

            if (txtSerie.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorSerie.Text = "Debe ingresar serie";
                SetToolTipError(lblErrorSerie);
            }

            if (string.IsNullOrEmpty(txtNumero.Text.Trim()))
            {
                estaValidado = false;
                lblErrorNumero.Text = "Debe ingresar número";
                SetToolTipError(lblErrorNumero);
            }
            else
            {
                decimal numero = 0;

                if (!decimal.TryParse(txtNumero.Text.Trim(), out numero))
                {
                    estaValidado = false;
                    lblErrorNumero.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorNumero);
                }
            }

            if (txtSerieGuia.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorSerieGuia.Text = "Debe ingresar serie de guía";
                SetToolTipError(lblErrorSerieGuia);
            }

            if (string.IsNullOrEmpty(txtNumeroGuia.Text.Trim()))
            {
                estaValidado = false;
                lblErrorNumeroGuia.Text = "Debe ingresar número de guía";
                SetToolTipError(lblErrorNumeroGuia);
            }
            else
            {
                decimal numeroGuia = 0;

                if (!decimal.TryParse(txtNumeroGuia.Text.Trim(), out numeroGuia))
                {
                    estaValidado = false;
                    lblErrorNumeroGuia.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorNumeroGuia);
                }
            }

            if (codigoProveedor == null)
            {
                estaValidado = false;
                lblErrorProveedor.Text = "Debe seleccionar proveedor";
                SetToolTipError(lblErrorProveedor);
            }

            if ((listaDetalle ?? new List<ComprobanteCompraDetalleBe>()).Count == 0)
            {
                estaValidado = false;
                lblErrorDetalle.Text = "No tiene registros de detalle";
                SetToolTipError(lblErrorDetalle);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltComprobanteCompra.SetToolTip(label, label.Text);
        }

        private void dgvDetalle_SelectionChanged(object sender, EventArgs e)
        {
            HabilitarBotonesGrilla();
        }

        void HabilitarBotonesGrilla()
        {
            bool habilitarBoton = dgvDetalle.CurrentRow == null ? false : dgvDetalle.CurrentRow.Index != -1;

            btnModificarDetalle.Enabled = habilitarBoton;
            btnEliminarDetalle.Enabled = habilitarBoton;
            btnUnidades.Enabled = habilitarBoton;
        }

        int GenerarCodigoComprobanteCompraDetalleTemporal(int codigoProducto)
        {
            int codigoComprobanteCompraDetalle = 0;
            listaDetalleInicial = listaDetalleInicial ?? new List<ComprobanteCompraDetalleBe>();
            var registro = listaDetalleInicial.FirstOrDefault(x => x.CodigoProducto == codigoProducto);
            listaDetalle = listaDetalle ?? new List<ComprobanteCompraDetalleBe>();
            if (registro == null) codigoComprobanteCompraDetalle = listaDetalle.Select(x => x.CodigoComprobanteCompraDetalle).DefaultIfEmpty().Min() - 1;
            else codigoComprobanteCompraDetalle = registro.CodigoComprobanteCompraDetalle;
            return codigoComprobanteCompraDetalle;
        }
    }
}
