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

namespace pm.app
{
    public partial class FrmMantenimientoGuiaRemisionDetalle : Form
    {
        public List<GuiaRemisionDetalleBe> ListaDetalleInicial { get; set; }
        public List<GuiaRemisionDetalleBe> ListaDetalleActual { get; set; }
        GuiaRemisionDetalleBe _Detalle;
        public GuiaRemisionDetalleBe Detalle { get { return _Detalle; } }
        int? codigoProducto, codigoProductoIndividual;
        string codigoBarraProductoIndividual;

        UnidadMedidaBl unidadMedidaBl = new UnidadMedidaBl();

        ProductoBl productoBl = new ProductoBl();
        ProductoIndividualBl productoIndividualBl = new ProductoIndividualBl();

        public FrmMantenimientoGuiaRemisionDetalle(GuiaRemisionDetalleBe item = null)
        {
            InitializeComponent();
            _Detalle = item;
        }

        private void FrmMantenimientoGuiaRemisionDetalle_Load(object sender, EventArgs e)
        {
            Text = Detalle == null ? "Agregar Registro" : "Modificar Registro";
            ListarCombos();
            if (Detalle != null)
            {
                CargarGuiaRemisionDetalle();
            }
        }

        void CargarGuiaRemisionDetalle()
        {
            CargarProducto(Detalle.CodigoProducto);
            CargarProductoIndividual(Detalle.CodigoProductoIndividual);
            cbbCodigoUnidadMedida.SelectedValue = Detalle.CodigoUnidadMedida;
            txtCantidad.Text = Detalle.Cantidad.ToString("0.00");
            cbbCodigoUnidadMedidaPeso.SelectedValue = Detalle.CodigoUnidadMedidaPeso;
            txtPeso.Text = Detalle.Peso.ToString("0.00");
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
                if (productoIndividual.CodigoProducto != codigoProducto) CargarProducto(productoIndividual.CodigoProducto);
                this.codigoProductoIndividual = productoIndividual.CodigoProductoIndividual;
                this.codigoBarraProductoIndividual = productoIndividual.CodigoBarra;
                txtCodigoBarraProductoIndividual.Text = productoIndividual.CodigoBarra;
                txtNombreProductoIndividual.Text = productoIndividual.Nombre;
                cbbCodigoUnidadMedida.SelectedValue = productoIndividual.CodigoUnidadMedida;
                txtCantidad.Text = productoIndividual.Metraje.ToString("0.00");
            }
            else
            {
                this.codigoProductoIndividual = null;
                this.codigoBarraProductoIndividual = null;
                txtCodigoBarraProductoIndividual.Text = "";
                txtNombreProductoIndividual.Text = "";
                cbbCodigoUnidadMedida.SelectedIndex = 0;
                txtCantidad.Text = "0.00";
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
            cbbCodigoUnidadMedida.DataSource = listaCombo.Select(x => x).ToList();

            cbbCodigoUnidadMedidaPeso.DataSource = null;
            cbbCodigoUnidadMedidaPeso.DataSource = listaCombo.Select(x => x).ToList();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            _Detalle = _Detalle ?? new GuiaRemisionDetalleBe();

            _Detalle.CodigoGuiaRemisionDetalle = 0;
            _Detalle.Detalle = codigoProductoIndividual.HasValue ? txtNombreProductoIndividual.Text.Trim() : txtNombreProducto.Text.Trim();
            _Detalle.CodigoProducto = codigoProducto.Value;
            _Detalle.Producto = new ProductoBe { Nombre = txtNombreProducto.Text.Trim() };
            _Detalle.CodigoProductoIndividual = codigoProductoIndividual.Value;
            _Detalle.ProductoIndividual = new ProductoIndividualBe { Nombre = txtNombreProductoIndividual.Text.Trim() };
            _Detalle.CodigoUnidadMedida = (int)cbbCodigoUnidadMedida.SelectedValue;
            _Detalle.UnidadMedida = new UnidadMedidaBe { Descripcion = cbbCodigoUnidadMedida.SelectedText };
            _Detalle.Cantidad = decimal.Parse(txtCantidad.Text.Trim());
            _Detalle.CodigoUnidadMedidaPeso = (int)cbbCodigoUnidadMedidaPeso.SelectedValue;
            _Detalle.UnidadMedidaPeso = new UnidadMedidaBe { Descripcion = cbbCodigoUnidadMedidaPeso.SelectedText };
            _Detalle.Peso = decimal.Parse(txtPeso.Text.Trim());

            DialogResult = DialogResult.OK;
            Close();
        }

        void LimpiarErrores()
        {
            lblErrorProducto.Text = "";
            lblErrorProductoIndividual.Text = "";
            lblErrorUnidadMedida.Text = "";
            lblErrorCantidad.Text = "";
            lblErrorUnidadMedidaPeso.Text = "";
            lblErrorPeso.Text = "";
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
                ListaDetalleActual = ListaDetalleActual ?? new List<GuiaRemisionDetalleBe>();

                int? codigoGuiaRemisionDetalle = Detalle == null ? null : (int?)Detalle.CodigoGuiaRemisionDetalle;

                bool existeProductoIndividual = ListaDetalleActual.Count(x => x.CodigoProductoIndividual == codigoProductoIndividual && x.CodigoGuiaRemisionDetalle != codigoGuiaRemisionDetalle) > 0;

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

            if (cbbCodigoUnidadMedidaPeso.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorUnidadMedidaPeso.Text = "Debe seleccionar una unidad medida peso";
                SetToolTipError(lblErrorUnidadMedidaPeso);
            }

            if (string.IsNullOrEmpty(txtPeso.Text.Trim()))
            {
                estaValidado = false;
                lblErrorPeso.Text = "Debe ingresar peso";
                SetToolTipError(lblErrorPeso);
            }
            else
            {
                decimal peso = 0;

                if (!decimal.TryParse(txtPeso.Text.Trim(), out peso))
                {
                    estaValidado = false;
                    lblErrorPeso.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorPeso);
                }
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltGuiaRemisionDetalle.SetToolTip(label, label.Text);
        }
    }
}
