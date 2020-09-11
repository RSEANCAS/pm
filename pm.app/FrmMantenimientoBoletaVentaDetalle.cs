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
    public partial class FrmMantenimientoBoletaVentaDetalle : Form
    {
        public List<BoletaVentaDetalleBe> ListaDetalleInicial { get; set; }
        public List<BoletaVentaDetalleBe> ListaDetalleActual { get; set; }
        BoletaVentaDetalleBe _Detalle;
        public BoletaVentaDetalleBe Detalle { get { return _Detalle; } }
        int? codigoProducto, codigoProductoIndividual;
        string codigoBarraProductoIndividual;
        TipoCalculo tipoCalculo = TipoCalculo.ValorUnitario;
        TipoDescuento tipoDescuento = TipoDescuento.Porcentaje;
        decimal valorVenta = 0, precioVenta = 0, baseImponible = 0;

        UnidadMedidaBl unidadMedidaBl = new UnidadMedidaBl();
        ProductoBl productoBl = new ProductoBl();
        ProductoIndividualBl productoIndividualBl = new ProductoIndividualBl();

        public FrmMantenimientoBoletaVentaDetalle(BoletaVentaDetalleBe item = null)
        {
            InitializeComponent();
            _Detalle = item;
        }

        private void FrmMantenimientoBoletaVentaDetalle_Load(object sender, EventArgs e)
        {
            Text = Detalle == null ? "Agregar Registro" : "Modificar Registro";
            ListarCombos();
            if (Detalle != null)
            {
                CargarBoletaVentaDetalle();
            }
        }

        void CargarBoletaVentaDetalle()
        {
            CargarProducto(Detalle.CodigoProducto);
            CargarProductoIndividual(Detalle.CodigoProductoIndividual);
            cbbCodigoUnidadMedida.SelectedValue = Detalle.CodigoUnidadMedida;
            txtCantidad.Text = Detalle.Cantidad.ToString("0.00");

            switch ((TipoCalculo)Detalle.TipoCalculo)
            {
                case TipoCalculo.ValorUnitario: rdbTipoCalculoValoUnitario.Checked = true; break;
                case TipoCalculo.PrecioUnitario: rdbTipoCalculoPrecioUnitario.Checked = true; break;
                case TipoCalculo.TotalImporte: rdbTipoCalculoTotalImporte.Checked = true; break;
            }

            txtValorUnitario.Text = Detalle.ValorUnitario.ToString("0.00");
            txtPrecioUnitario.Text = Detalle.PrecioUnitario.ToString("0.00");

            switch ((TipoDescuento)Detalle.TipoDescuento)
            {
                case TipoDescuento.Porcentaje: rdbPorcentajeDescuento.Checked = true; break;
                case TipoDescuento.Descuento: rdbDescuento.Checked = true; break;
            }

            txtPorcentajeDescuento.Text = Detalle.PorcentajeDescuento.ToString("0.00");
            txtDescuento.Text = Detalle.Descuento.ToString("0.00");

            txtIgv.Text = Detalle.Igv.ToString("0.00");
            txtImporteTotal.Text = Detalle.Importe.ToString("0.00");
        }

        void CargarProducto(int? codigoProducto)
        {
            ProductoBe producto = codigoProducto == null ? null : productoBl.ObtenerProducto(codigoProducto.Value);
            if (producto != null)
            {
                this.codigoProducto = producto.CodigoProducto;
                txtNombreProducto.Text = producto.Nombre;
            }
            else
            {
                this.codigoProducto = null;
                txtNombreProducto.Text = "";
            }
        }

        void CargarProductoIndividual(int? codigoProductoIndividual)
        {
            ProductoIndividualBe productoIndividual = codigoProductoIndividual == null ? null : productoIndividualBl.ObtenerProductoIndividual(codigoProductoIndividual.Value);
            if (productoIndividual != null)
            {
                this.codigoProductoIndividual = productoIndividual.CodigoProductoIndividual;
                this.codigoBarraProductoIndividual = productoIndividual.CodigoBarra;
                txtCodigoBarraProductoIndividual.Text = productoIndividual.CodigoBarra;
                txtNombreProductoIndividual.Text = productoIndividual.Nombre;
            }
            else
            {
                this.codigoProductoIndividual = null;
                this.codigoBarraProductoIndividual = null;
                txtCodigoBarraProductoIndividual.Text = "";
                txtNombreProductoIndividual.Text = "";
            }
        }

        void ListarCombos()
        {
            ListarComboUnidadMedida();
        }

        void ListarComboUnidadMedida()
        {
            List<UnidadMedidaBe> listaCombo = unidadMedidaBl.ListarComboUnidadMedida();
            listaCombo = listaCombo ?? new List<UnidadMedidaBe>();
            listaCombo.Insert(0, new UnidadMedidaBe { CodigoUnidadMedida = -1, Descripcion = "[Seleccione...]" });

            cbbCodigoUnidadMedida.DataSource = null;
            cbbCodigoUnidadMedida.DataSource = listaCombo;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            List<dynamic> listaColumnas = new List<dynamic>();
            listaColumnas.Add(new { Campo = "CodigoProducto", NombreColumna = "CodigoProducto", EsVisible = false, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = false });
            listaColumnas.Add(new { Campo = "Nombre", NombreColumna = "Nombre", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Cantidad", NombreColumna = "Cantidad", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Color", NombreColumna = "Color", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });

            string table = "dbo.Producto";
            DataGridViewColumn[] columns = listaColumnas.Select(x => {
                DataGridViewColumn column = x.TipoColumna;
                column.Name = $"dgvResultados_{x.Campo}";
                column.DataPropertyName = x.Campo;
                column.HeaderText = x.NombreColumna;
                column.Visible = x.EsVisible;
                return column;
            }).ToArray();
            string[] columnsFilter = listaColumnas.Where(x => x.EsFiltro).Select(x => (string)x.Campo).ToArray();

            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro("Buscar Producto", table, columns.Cast<DataGridViewColumn>().ToArray(), columnsFilter, typeof(ProductoBe));
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarProducto(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarProducto(resultado.CodigoProducto);
            }
        }

        private void btnBuscarProductoIndividual_Click(object sender, EventArgs e)
        {
            if ((codigoBarraProductoIndividual ?? "") == txtCodigoBarraProductoIndividual.Text.Trim() && codigoBarraProductoIndividual != null) return;
            if (txtCodigoBarraProductoIndividual.Text.Trim() == "") CargarProductoIndividual(null);
            List<dynamic> listaColumnas = new List<dynamic>();
            listaColumnas.Add(new { Campo = "CodigoProductoIndividual", NombreColumna = "CodigoProductoIndividual", EsVisible = false, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = false });
            listaColumnas.Add(new { Campo = "CodigoBarra", NombreColumna = "Código Barra", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Nombre", NombreColumna = "Nombre", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            //listaColumnas.Add(new { Campo = "Cantidad", NombreColumna = "Cantidad", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Color", NombreColumna = "Color", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });

            string table = "dbo.ProductoIndividual";
            DataGridViewColumn[] columns = listaColumnas.Select(x => {
                DataGridViewColumn column = x.TipoColumna;
                column.Name = $"dgvResultados_{x.Campo}";
                column.DataPropertyName = x.Campo;
                column.HeaderText = x.NombreColumna;
                column.Visible = x.EsVisible;
                return column;
            }).ToArray();
            string[] columnsFilter = listaColumnas.Where(x => x.EsFiltro).Select(x => (string)x.Campo).ToArray();

            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro("Buscar Producto Individual", table, columns.Cast<DataGridViewColumn>().ToArray(), columnsFilter, typeof(ProductoIndividualBe));
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarProductoIndividual(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarProductoIndividual(resultado.CodigoProductoIndividual);
            }
        }

        private void rdbTipoCalculoValoUnitario_CheckedChanged(object sender, EventArgs e)
        {
            tipoCalculo = TipoCalculo.ValorUnitario;
            txtValorUnitario.ReadOnly = false;
            txtPrecioUnitario.ReadOnly = true;
            txtImporteTotal.ReadOnly = true;
            Calculo();
        }

        private void rdbTipoCalculoPrecioUnitario_CheckedChanged(object sender, EventArgs e)
        {
            tipoCalculo = TipoCalculo.PrecioUnitario;
            txtPrecioUnitario.ReadOnly = false;
            txtValorUnitario.ReadOnly = true;
            txtImporteTotal.ReadOnly = true;
            Calculo();
        }

        private void rdbTipoCalculoTotalImporte_CheckedChanged(object sender, EventArgs e)
        {
            tipoCalculo = TipoCalculo.TotalImporte;
            txtImporteTotal.ReadOnly = false;
            txtValorUnitario.ReadOnly = true;
            txtPrecioUnitario.ReadOnly = true;
            Calculo();
        }

        private void rdbPorcentajeDescuento_CheckedChanged(object sender, EventArgs e)
        {
            tipoDescuento = TipoDescuento.Porcentaje;
            txtPorcentajeDescuento.ReadOnly = false;
            txtDescuento.ReadOnly = true;
        }

        private void rdbDescuento_CheckedChanged(object sender, EventArgs e)
        {
            tipoDescuento = TipoDescuento.Descuento;
            txtDescuento.ReadOnly = false;
            txtPorcentajeDescuento.ReadOnly = true;
        }

        void Calculo()
        {
            decimal cantidad = 0, valorUnitario = 0, precioUnitario = 0, porcentajeDescuento = 0, valorPorcentajeDescuento = 0, descuento = 0, valorVenta = 0, precioVenta = 0, igv = 0, baseImponible = 0, totalImporte = 0;

            decimal.TryParse(txtCantidad.Text.Trim(), out cantidad);
            decimal porcentajeIgv = 18M;
            decimal valorPorcentajeIgv = porcentajeIgv / 100;

            switch (tipoCalculo)
            {
                case TipoCalculo.ValorUnitario:
                    decimal.TryParse(txtValorUnitario.Text.Trim(), out valorUnitario);
                    precioUnitario = valorUnitario * (1 + valorPorcentajeIgv);
                    valorVenta = valorUnitario * cantidad;
                    precioVenta = precioUnitario * cantidad;
                    switch (tipoDescuento)
                    {
                        case TipoDescuento.Porcentaje:
                            decimal.TryParse(txtPorcentajeDescuento.Text.Trim(), out porcentajeDescuento);
                            valorPorcentajeDescuento = porcentajeDescuento / 100;
                            descuento = precioVenta * valorPorcentajeDescuento;
                            break;
                        case TipoDescuento.Descuento:
                            break;
                    }
                    totalImporte = precioVenta - descuento;
                    baseImponible = totalImporte / (1 + valorPorcentajeIgv);
                    igv = totalImporte - baseImponible;
                    break;
                case TipoCalculo.PrecioUnitario:
                    decimal.TryParse(txtPrecioUnitario.Text.Trim(), out precioUnitario);
                    valorUnitario = precioUnitario / (1 + valorPorcentajeIgv);
                    valorVenta = valorUnitario * cantidad;
                    precioVenta = precioUnitario * cantidad;
                    switch (tipoDescuento)
                    {
                        case TipoDescuento.Porcentaje:
                            decimal.TryParse(txtPorcentajeDescuento.Text.Trim(), out porcentajeDescuento);
                            valorPorcentajeDescuento = porcentajeDescuento / 100;
                            descuento = precioVenta * valorPorcentajeDescuento;
                            break;
                        case TipoDescuento.Descuento:
                            break;
                    }
                    totalImporte = precioVenta - descuento;
                    baseImponible = totalImporte / (1 + valorPorcentajeIgv);
                    igv = totalImporte - baseImponible;
                    break;
                case TipoCalculo.TotalImporte:
                    decimal.TryParse(txtImporteTotal.Text.Trim(), out totalImporte);
                    switch (tipoDescuento)
                    {
                        case TipoDescuento.Porcentaje:
                            decimal.TryParse(txtPorcentajeDescuento.Text.Trim(), out porcentajeDescuento);
                            valorPorcentajeDescuento = porcentajeDescuento / 100;
                            descuento = precioVenta * valorPorcentajeDescuento;
                            break;
                        case TipoDescuento.Descuento:
                            break;
                    }
                    break;
            }

            txtCantidad.Text = cantidad.ToString("0.00");
            txtValorUnitario.Text = valorUnitario.ToString("0.00");
            txtPrecioUnitario.Text = precioUnitario.ToString("0.00");
            this.valorVenta = valorVenta;
            this.precioVenta = precioVenta;
            txtPorcentajeDescuento.Text = porcentajeDescuento.ToString("0.00");
            txtDescuento.Text = descuento.ToString("0.00");
            txtIgv.Text = igv.ToString("0.00");
            this.baseImponible = baseImponible;
            txtImporteTotal.Text = totalImporte.ToString("0.00");
        }

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            Calculo();
        }

        private void txtValorUnitario_Validated(object sender, EventArgs e)
        {
            Calculo();
        }

        private void txtPrecioUnitario_Validated(object sender, EventArgs e)
        {
            Calculo();
        }

        private void txtPorcentajeDescuento_Validated(object sender, EventArgs e)
        {
            Calculo();
        }

        private void txtDescuento_Validated(object sender, EventArgs e)
        {
            Calculo();
        }

        private void txtImporteTotal_Validated(object sender, EventArgs e)
        {
            Calculo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            _Detalle = _Detalle ?? new BoletaVentaDetalleBe();

            _Detalle.CodigoBoletaVentaDetalle = 0;
            _Detalle.Detalle = codigoProductoIndividual.HasValue ? txtNombreProductoIndividual.Text.Trim() : txtNombreProducto.Text.Trim();
            _Detalle.CodigoProducto = codigoProducto.Value;
            _Detalle.Producto = new ProductoBe { Nombre = txtNombreProducto.Text.Trim() };
            _Detalle.CodigoProductoIndividual = codigoProductoIndividual.Value;
            _Detalle.ProductoIndividual = new ProductoIndividualBe { Nombre = txtNombreProductoIndividual.Text.Trim() };
            _Detalle.CodigoUnidadMedida = (int)cbbCodigoUnidadMedida.SelectedValue;
            _Detalle.UnidadMedida = new UnidadMedidaBe { Descripcion = cbbCodigoUnidadMedida.SelectedText };
            _Detalle.Cantidad = decimal.Parse(txtCantidad.Text.Trim());
            _Detalle.TipoCalculo = (int)tipoCalculo;
            _Detalle.ValorUnitario = decimal.Parse(txtValorUnitario.Text.Trim());
            _Detalle.PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text.Trim());
            _Detalle.ValorVenta = this.valorVenta;
            _Detalle.PrecioVenta = this.precioVenta;
            _Detalle.TipoDescuento = (int)tipoDescuento;
            _Detalle.PorcentajeDescuento = decimal.Parse(txtPorcentajeDescuento.Text.Trim());
            _Detalle.Descuento = decimal.Parse(txtDescuento.Text.Trim());
            _Detalle.Igv = decimal.Parse(txtIgv.Text.Trim());
            _Detalle.BaseImponible = this.baseImponible;
            _Detalle.Importe = decimal.Parse(txtImporteTotal.Text.Trim());

            DialogResult = DialogResult.OK;
            Close();
        }

        void LimpiarErrores()
        {
            lblErrorProducto.Text = "";
            lblErrorProductoIndividual.Text = "";
            lblErrorUnidadMedida.Text = "";
            lblErrorCantidad.Text = "";
            lblErrorValorUnitario.Text = "";
            lblErrorPrecioUnitario.Text = "";
            lblErrorPorcentajeDescuento.Text = "";
            lblErrorDescuento.Text = "";
            lblErrorIgv.Text = "";
            lblErrorImporteTotal.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if (codigoProducto == null)
            {
                    estaValidado = false;
                    lblErrorProducto.Text = "Debe seleccionar producto";
                    SetToolTipError(lblErrorProducto);
            }

            if (codigoProductoIndividual == null)
            {
                estaValidado = false;
                lblErrorProductoIndividual.Text = "Debe seleccionar producto individual";
                SetToolTipError(lblErrorProductoIndividual);
            }
            else
            {
                ListaDetalleActual = ListaDetalleActual ?? new List<BoletaVentaDetalleBe>();

                int? codigoBoletaVentaDetalle = Detalle == null ? null : (int?)Detalle.CodigoBoletaVentaDetalle;

                bool existeProductoIndividual = ListaDetalleActual.Count(x => x.CodigoProductoIndividual == codigoProductoIndividual && x.CodigoBoletaVentaDetalle != codigoBoletaVentaDetalle) > 0;

                if (existeProductoIndividual)
                {
                    estaValidado = false;
                    lblErrorProductoIndividual.Text = $"El producto individual seleccionado ya existe";
                    SetToolTipError(lblErrorProductoIndividual);
                }
            }

            if (cbbCodigoUnidadMedida.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorUnidadMedida.Text = "Debe seleccionar una unidad medida";
                SetToolTipError(lblErrorUnidadMedida);
            }

            if (string.IsNullOrEmpty(txtCantidad.Text.Trim()))
            {
                estaValidado = false;
                lblErrorCantidad.Text = "Debe ingresar cantidad";
                SetToolTipError(lblErrorCantidad);
            }
            else
            {
                decimal cantidad = 0;

                if (!decimal.TryParse(txtCantidad.Text.Trim(), out cantidad))
                {
                    estaValidado = false;
                    lblErrorCantidad.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorCantidad);
                }
            }

            if (tipoCalculo == TipoCalculo.ValorUnitario)
            {
                if (string.IsNullOrEmpty(txtValorUnitario.Text.Trim()))
                {
                    estaValidado = false;
                    lblErrorValorUnitario.Text = "Debe ingresar valor unitario";
                    SetToolTipError(lblErrorValorUnitario);
                }
                else
                {
                    decimal valorUnitario = 0;

                    if (!decimal.TryParse(txtValorUnitario.Text.Trim(), out valorUnitario))
                    {
                        estaValidado = false;
                        lblErrorValorUnitario.Text = "Debe ingresar un valor numérico";
                        SetToolTipError(lblErrorValorUnitario);
                    }
                }
            }
            else if (tipoCalculo == TipoCalculo.PrecioUnitario)
            {
                if (string.IsNullOrEmpty(txtPrecioUnitario.Text.Trim()))
                {
                    estaValidado = false;
                    lblErrorPrecioUnitario.Text = "Debe ingresar precio unitario";
                    SetToolTipError(lblErrorPrecioUnitario);
                }
                else
                {
                    decimal precioUnitario = 0;

                    if (!decimal.TryParse(txtPrecioUnitario.Text.Trim(), out precioUnitario))
                    {
                        estaValidado = false;
                        lblErrorPrecioUnitario.Text = "Debe ingresar un valor numérico";
                        SetToolTipError(lblErrorPrecioUnitario);
                    }
                }
            }

            if (tipoDescuento == TipoDescuento.Porcentaje)
            {
                if (string.IsNullOrEmpty(txtPorcentajeDescuento.Text.Trim()))
                {
                    estaValidado = false;
                    lblErrorPorcentajeDescuento.Text = "Debe ingresar valor porcentaje descuento";
                    SetToolTipError(lblErrorPorcentajeDescuento);
                }
                else
                {
                    decimal porcentajeDescuento = 0;

                    if (!decimal.TryParse(txtPorcentajeDescuento.Text.Trim(), out porcentajeDescuento))
                    {
                        estaValidado = false;
                        lblErrorPorcentajeDescuento.Text = "Debe ingresar un valor numérico";
                        SetToolTipError(lblErrorPorcentajeDescuento);
                    }
                }
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltBoletaVentaDetalle.SetToolTip(label, label.Text);
        }
    }
}
