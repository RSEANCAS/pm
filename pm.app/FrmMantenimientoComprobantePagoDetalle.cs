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
    public partial class FrmMantenimientoComprobantePagoDetalle : Form
    {
        public List<ComprobantePagoDetalleBe> ListaDetalleInicial { get; set; }
        public List<ComprobantePagoDetalleBe> ListaDetalleActual { get; set; }
        ComprobantePagoDetalleBe _Detalle;
        public ComprobantePagoDetalleBe Detalle { get { return _Detalle; } }
        int? codigoDocumentoPago;

        int? cantidadUnidadesRegistradas;

        FacturaVentaBl facturaVentaBl = new FacturaVentaBl();
        LetraBl letraBl = new LetraBl();

        ProductoBl productoBl = new ProductoBl();
        ProductoIndividualBl productoIndividualBl = new ProductoIndividualBl();
        ControlBusquedaBl controlBusquedaBl = new ControlBusquedaBl();

        public FrmMantenimientoComprobantePagoDetalle(ComprobantePagoDetalleBe item = null, int? cantidadUnidadesRegistradas = null)
        {
            InitializeComponent();
            _Detalle = item;
            this.cantidadUnidadesRegistradas = cantidadUnidadesRegistradas;
        }

        private void FrmMantenimientoComprobantePagoDetalle_Load(object sender, EventArgs e)
        {
            Text = Detalle == null ? "Agregar Registro" : "Modificar Registro";
            ListarComboTipoDocumentoPago();
            if (Detalle != null)
            {
                CargarComprobantePagoDetalle();
            }
        }

        void CargarComprobantePagoDetalle()
        {
            cbbCodigoTipoDocumentoPago.SelectedValue = Detalle.CodigoTipoDocumentoPago.ToString();
            CargarDocumentoPago(Detalle.CodigoTipoDocumentoPago, Detalle.CodigoDocumentoPago);
            txtMonto.Text = Detalle.Monto.ToString("0.00");
            txtMora.Text = Detalle.Mora.ToString("0.00");
            txtProtesto.Text = Detalle.Protesto.ToString("0.00");
            txtTotal.Text = Detalle.Total.ToString("0.00");
            txtMontoPagar.Text = Detalle.MontoPagar.ToString("0.00");
            txtMoraPagar.Text = Detalle.MoraPagar.ToString("0.00");
            txtProtestoPagar.Text = Detalle.ProtestoPagar.ToString("0.00");
            txtImportePagar.Text = Detalle.ImportePagar.ToString("0.00");
            //CalcularImporteTotal();
        }

        void CargarDocumentoPago(int? codigoTipoDocumentoPago, int? codigoDocumentoPago)
        {
            if (codigoTipoDocumentoPago != null)
            {
                if (codigoTipoDocumentoPago == (int)TipoDocumentoPago.Factura)
                {
                    dynamic documentoPago = codigoDocumentoPago == null ? null : facturaVentaBl.ObtenerFacturaVenta(codigoDocumentoPago.Value, withSerie: true);
                    if (documentoPago != null)
                    {
                        this.codigoDocumentoPago = documentoPago.CodigoFacturaVenta;
                        txtDescripcion.Text = $"{((TipoDocumentoPago)codigoTipoDocumentoPago).GetAttributeOfType<DescriptionAttribute>().Description} {documentoPago.Serie.Serial}-{documentoPago.NroComprobante.ToString("00000000")}";
                        txtMonto.Text = documentoPago.TotalImporte.ToString("0.00");
                        txtMora.Text = "0.00";
                        txtProtesto.Text = "0.00";
                        txtMontoPagar.Text = documentoPago.TotalImporte.ToString("0.00");
                        txtMoraPagar.Text = "0.00";
                        txtProtestoPagar.Text = "0.00";
                    }
                    else
                    {
                        this.codigoDocumentoPago = null;
                        txtDescripcion.Text = "";
                        txtMonto.Text = "";
                        txtMora.Text = "";
                        txtProtesto.Text = "";
                        txtMontoPagar.Text = "";
                        txtMoraPagar.Text = "";
                        txtProtestoPagar.Text = "";
                    }
                }

                if (codigoTipoDocumentoPago == (int)TipoDocumentoPago.Letra)
                {
                    dynamic documentoPago = codigoDocumentoPago == null ? null : letraBl.ObtenerLetra(codigoDocumentoPago.Value);
                    if (documentoPago != null)
                    {
                        this.codigoDocumentoPago = documentoPago.CodigoLetra;
                        txtDescripcion.Text = $"{((TipoDocumentoPago)codigoTipoDocumentoPago).GetAttributeOfType<DescriptionAttribute>().Description} {documentoPago.Numero.ToString("00000000")}";
                        txtMonto.Text = documentoPago.Monto.ToString("0.00");
                        txtMora.Text = documentoPago.Mora.ToString("0.00");
                        txtProtesto.Text = documentoPago.Protesto.ToString("0.00");
                        txtMontoPagar.Text = documentoPago.Monto.ToString("0.00");
                        txtMoraPagar.Text = documentoPago.Mora.ToString("0.00");
                        txtProtestoPagar.Text = documentoPago.Protesto.ToString("0.00");
                    }
                    else
                    {
                        this.codigoDocumentoPago = null;
                        txtDescripcion.Text = "";
                        txtMonto.Text = "";
                        txtMora.Text = "";
                        txtProtesto.Text = "";
                        txtMontoPagar.Text = "";
                        txtMoraPagar.Text = "";
                        txtProtestoPagar.Text = "";
                    }
                }
            }
            else
            {
                this.codigoDocumentoPago = null;
                txtDescripcion.Text = "";
                txtMonto.Text = "";
                txtMora.Text = "";
                txtProtesto.Text = "";
                txtMontoPagar.Text = "";
                txtMoraPagar.Text = "";
                txtProtestoPagar.Text = "";
            }

        }

        void ListarComboTipoDocumentoPago()
        {
            List<Combo> listaCombo = Enum<TipoDocumentoPago>.GetCollection().ToList();

            listaCombo.Insert(0, new Combo { Value = "-1", Text = "[Seleccione...]" });

            cbbCodigoTipoDocumentoPago.DataSource = null;
            cbbCodigoTipoDocumentoPago.DataSource = listaCombo;
        }

        private void btnBuscarDocumentoPago_Click(object sender, EventArgs e)
        {
            if (cbbCodigoTipoDocumentoPago.SelectedIndex == 0) return;

            int codigoTipoDocumentoPago = int.Parse(cbbCodigoTipoDocumentoPago.SelectedValue.ToString());
            TipoDocumentoPago tipoDocumentoPago = ((TipoDocumentoPago)codigoTipoDocumentoPago);

            string strTipoDocumentoPago = tipoDocumentoPago.GetAttributeOfType<DescriptionAttribute>().Description;

            string formulario = this.GetType().FullName;
            string control = ((Control)sender).Name;
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, $"{control}{strTipoDocumentoPago}", true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarDocumentoPago(null, null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                int? codigoDocumentoPago = tipoDocumentoPago == TipoDocumentoPago.Factura ? resultado.CodigoFacturaVenta : tipoDocumentoPago == TipoDocumentoPago.Letra ? resultado.CodigoLetra : null;
                CargarDocumentoPago(codigoTipoDocumentoPago, codigoDocumentoPago);
                CalcularImporteTotal();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            _Detalle = _Detalle ?? new ComprobantePagoDetalleBe();

            //_Detalle.CodigoComprobantePagoDetalle = 0;
            _Detalle.CodigoTipoDocumentoPago = int.Parse(cbbCodigoTipoDocumentoPago.SelectedValue.ToString());
            _Detalle.CodigoDocumentoPago = !codigoDocumentoPago.HasValue ? 0 : codigoDocumentoPago.Value;
            _Detalle.Descripcion = txtDescripcion.Text.Trim();
            _Detalle.Monto = decimal.Parse(txtMonto.Text.Trim());
            _Detalle.Mora = decimal.Parse(txtMora.Text.Trim());
            _Detalle.Protesto = decimal.Parse(txtProtesto.Text.Trim());
            _Detalle.Total = decimal.Parse(txtTotal.Text.Trim());
            _Detalle.MontoPagar = decimal.Parse(txtMontoPagar.Text.Trim());
            _Detalle.MoraPagar = decimal.Parse(txtMoraPagar.Text.Trim());
            _Detalle.ProtestoPagar = decimal.Parse(txtProtestoPagar.Text.Trim());
            _Detalle.ImportePagar = decimal.Parse(txtImportePagar.Text.Trim());

            DialogResult = DialogResult.OK;
            Close();
        }

        void LimpiarErrores()
        {
            lblErrorCodigoTipoDocumentoPago.Text = "";
            lblErrorDocumentoPago.Text = "";
            lblErrorMonto.Text = "";
            lblErrorMora.Text = "";
            lblErrorProtesto.Text = "";
            lblErrorTotal.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (!codigoDocumentoPago.HasValue || cbbCodigoTipoDocumentoPago.SelectedIndex == 0)
            {
                if (cbbCodigoTipoDocumentoPago.SelectedIndex == 0)
                {
                    estaValidado = false;
                    lblErrorCodigoTipoDocumentoPago.Text = "Debe seleccionar tipo de documento de pago";
                    SetToolTipError(lblErrorCodigoTipoDocumentoPago);
                }

                if (!codigoDocumentoPago.HasValue)
                {
                    estaValidado = false;
                    lblErrorDocumentoPago.Text = "Debe seleccionar documento de pago";
                    SetToolTipError(lblErrorDocumentoPago);
                }
            }
            else
            {
                bool existeDocumentoPago = ListaDetalleActual.Exists(x => x.CodigoTipoDocumentoPago == int.Parse(cbbCodigoTipoDocumentoPago.SelectedValue.ToString()) && x.CodigoDocumentoPago == codigoDocumentoPago && (x.CodigoComprobantePagoDetalle != (_Detalle ?? new ComprobantePagoDetalleBe()).CodigoComprobantePagoDetalle));

                if (existeDocumentoPago)
                {
                    estaValidado = false;
                    lblErrorDocumentoPago.Text = $"El documento de pago seleccionado ya existe";
                    SetToolTipError(lblErrorDocumentoPago);
                }
            }

            decimal monto = 0;
            if (string.IsNullOrEmpty(txtMonto.Text.Trim()))
            {
                estaValidado = false;
                lblErrorMonto.Text = "Debe ingresar monto";
                SetToolTipError(lblErrorMonto);
            }
            else
            {

                if (!decimal.TryParse(txtMonto.Text.Trim(), out monto))
                {
                    estaValidado = false;
                    lblErrorMonto.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorMonto);
                }
            }

            decimal montoPagar = 0;
            if (string.IsNullOrEmpty(txtMontoPagar.Text.Trim()))
            {
                estaValidado = false;
                lblErrorMontoPagar.Text = "Debe ingresar monto a pagar";
                SetToolTipError(lblErrorMontoPagar);
            }
            else
            {

                if (!decimal.TryParse(txtMontoPagar.Text.Trim(), out montoPagar))
                {
                    estaValidado = false;
                    lblErrorMontoPagar.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorMontoPagar);
                }
                else
                {
                    if (montoPagar > monto)
                    {
                        estaValidado = false;
                        lblErrorMontoPagar.Text = "El monto a pagar no puede ser mayor al monto";
                        SetToolTipError(lblErrorMontoPagar);
                    }
                }
            }

            decimal mora = 0;
            if (string.IsNullOrEmpty(txtMora.Text.Trim()))
            {
                estaValidado = false;
                lblErrorMora.Text = "Debe ingresar mora";
                SetToolTipError(lblErrorMora);
            }
            else
            {

                if (!decimal.TryParse(txtMora.Text.Trim(), out mora))
                {
                    estaValidado = false;
                    lblErrorMora.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorMora);
                }
            }

            decimal moraPagar = 0;
            if (string.IsNullOrEmpty(txtMoraPagar.Text.Trim()))
            {
                estaValidado = false;
                lblErrorMoraPagar.Text = "Debe ingresar mora a pagar";
                SetToolTipError(lblErrorMoraPagar);
            }
            else
            {

                if (!decimal.TryParse(txtMoraPagar.Text.Trim(), out moraPagar))
                {
                    estaValidado = false;
                    lblErrorMoraPagar.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorMoraPagar);
                }
                else
                {
                    if (moraPagar > mora)
                    {
                        estaValidado = false;
                        lblErrorMoraPagar.Text = "El mora a pagar no puede ser mayor a la mora";
                        SetToolTipError(lblErrorMoraPagar);
                    }
                }
            }

            decimal protesto = 0;
            if (string.IsNullOrEmpty(txtProtesto.Text.Trim()))
            {
                estaValidado = false;
                lblErrorProtesto.Text = "Debe ingresar protesto";
                SetToolTipError(lblErrorProtesto);
            }
            else
            {

                if (!decimal.TryParse(txtProtesto.Text.Trim(), out protesto))
                {
                    estaValidado = false;
                    lblErrorProtesto.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorProtesto);
                }
            }

            decimal protestoPagar = 0;
            if (string.IsNullOrEmpty(txtProtestoPagar.Text.Trim()))
            {
                estaValidado = false;
                lblErrorProtestoPagar.Text = "Debe ingresar protesto a pagar";
                SetToolTipError(lblErrorProtestoPagar);
            }
            else
            {

                if (!decimal.TryParse(txtProtestoPagar.Text.Trim(), out protestoPagar))
                {
                    estaValidado = false;
                    lblErrorProtestoPagar.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorProtestoPagar);
                }
                else
                {
                    if (protestoPagar > protesto)
                    {
                        estaValidado = false;
                        lblErrorProtestoPagar.Text = "El protesto a pagar no puede ser mayor al protesto";
                        SetToolTipError(lblErrorProtestoPagar);
                    }
                }
            }

            decimal total = 0;
            if (string.IsNullOrEmpty(txtTotal.Text.Trim()))
            {
                estaValidado = false;
                lblErrorTotal.Text = "Debe ingresar total";
                SetToolTipError(lblErrorTotal);
            }
            else
            {

                if (!decimal.TryParse(txtTotal.Text.Trim(), out total))
                {
                    estaValidado = false;
                    lblErrorTotal.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorTotal);
                }
            }

            decimal importePagar = 0;
            if (string.IsNullOrEmpty(txtImportePagar.Text.Trim()))
            {
                estaValidado = false;
                lblErrorImportePagar.Text = "Debe ingresar importe a pagar";
                SetToolTipError(lblErrorImportePagar);
            }
            else
            {

                if (!decimal.TryParse(txtImportePagar.Text.Trim(), out importePagar))
                {
                    estaValidado = false;
                    lblErrorImportePagar.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorImportePagar);
                }
                else
                {
                    if (importePagar > total)
                    {
                        estaValidado = false;
                        lblErrorImportePagar.Text = "El importe a pagar no puede ser mayor al importe total";
                        SetToolTipError(lblErrorImportePagar);
                    }
                }
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltComprobantePagoDetalle.SetToolTip(label, label.Text);
        }

        void CalcularImporteTotal()
        {
            decimal monto = string.IsNullOrEmpty(txtMonto.Text.Trim()) ? 0M : decimal.Parse(txtMonto.Text.Trim());
            decimal mora = string.IsNullOrEmpty(txtMora.Text.Trim()) ? 0M : decimal.Parse(txtMora.Text.Trim());
            decimal protesto = string.IsNullOrEmpty(txtProtesto.Text.Trim()) ? 0M : decimal.Parse(txtProtesto.Text.Trim());

            decimal montoPagar = string.IsNullOrEmpty(txtMontoPagar.Text.Trim()) ? 0M : decimal.Parse(txtMontoPagar.Text.Trim());
            decimal moraPagar = string.IsNullOrEmpty(txtMoraPagar.Text.Trim()) ? 0M : decimal.Parse(txtMoraPagar.Text.Trim());
            decimal protestoPagar = string.IsNullOrEmpty(txtProtestoPagar.Text.Trim()) ? 0M : decimal.Parse(txtProtestoPagar.Text.Trim());

            decimal total = monto + mora + protesto;
            decimal totalPagar = montoPagar + moraPagar + protestoPagar;

            txtTotal.Text = total.ToString("0.00");
            txtImportePagar.Text = totalPagar.ToString("0.00");
        }

        private void txtMontoPagar_TextChanged(object sender, EventArgs e)
        {
            CalcularImporteTotal();
        }

        private void txtMoraPagar_TextChanged(object sender, EventArgs e)
        {
            CalcularImporteTotal();
        }

        private void txtProtestoPagar_TextChanged(object sender, EventArgs e)
        {
            CalcularImporteTotal();
        }
    }
}
