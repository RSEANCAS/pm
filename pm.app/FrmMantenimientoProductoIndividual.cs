using log4net.Repository.Hierarchy;
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
    public partial class FrmMantenimientoProductoIndividual : Form
    {
        int? codigoProductoIndividual;
        int? codigoProducto;
        int? codigoProveedor;
        string nroDocumentoIdentidadProveedor;
        int? codigoPersonalInspeccion;
        string nroDocumentoIdentidadPersonalInspeccion;

        UnidadMedidaBl unidadMedidaBl = new UnidadMedidaBl();
        ProductoIndividualBl productoIndividualBl = new ProductoIndividualBl();
        ProductoBl productoBl = new ProductoBl();
        ProveedorBl proveedorBl = new ProveedorBl();
        PersonalBl personalBl = new PersonalBl();

        public FrmMantenimientoProductoIndividual(int? codigoProductoIndividual = null)
        {
            InitializeComponent();
            this.codigoProductoIndividual = codigoProductoIndividual;
        }

        private void FrmMantenimientoProductoIndividual_Load(object sender, EventArgs e)
        {
            Text = !codigoProductoIndividual.HasValue ? "Nuevo Producto Individual" : "Modificar Producto Individual";
            ListarCombos();
            if (codigoProductoIndividual.HasValue)
            {
                CargarProductoIndividual();
            }
            txtNroDocIdentidadProveedor.LostFocus += TxtNroDocIdentidadProveedor_LostFocus;
            txtNroDocIdentidadPersonalInspeccion.LostFocus += TxtNroDocIdentidadPersonalInspeccion_LostFocus;
        }

        private void TxtNroDocIdentidadProveedor_LostFocus(object sender, EventArgs e)
        {
            btnBuscarProveedor_Click(btnBuscarProveedor, new EventArgs());
        }

        private void TxtNroDocIdentidadPersonalInspeccion_LostFocus(object sender, EventArgs e)
        {
            btnBuscarPersonalInspeccion_Click(btnBuscarPersonalInspeccion, new EventArgs());
        }

        void CargarProductoIndividual()
        {
            ProductoIndividualBe item = productoIndividualBl.ObtenerProductoIndividual(codigoProductoIndividual.Value);
            txtCodigoBarra.Text = item.CodigoBarra;
            txtNombre.Text = item.Nombre;
            CargarProducto(item.CodigoProducto);
            cbbCodigoUnidadMedida.SelectedValue = item.CodigoUnidadMedida;
            txtCodigoInicial.Text = item.CodigoInicial;
            txtPeso.Text = item.Peso.ToString("0.00");
            txtRollo.Text = item.Rollo.ToString("0.00");
            txtBulto.Text = item.Bulto.ToString("0.00");
            txtColor.Text = item.Color;
            dtpFechaEntrada.Value = item.FechaEntrada;
            CargarProveedor(item.CodigoProveedor);
            CargarPersonalInspeccion(item.CodigoPersonalInspeccion);
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

        void CargarProveedor(int? codigoProveedor)
        {
            ProveedorBe proveedor = codigoProveedor == null ? null : proveedorBl.ObtenerProveedor(codigoProveedor.Value);
            if (proveedor != null)
            {
                this.codigoProveedor = proveedor.CodigoProveedor;
                this.nroDocumentoIdentidadProveedor = proveedor.NroDocumentoIdentidad;
                txtNroDocIdentidadProveedor.Text = proveedor.NroDocumentoIdentidad;
                txtNombresProveedor.Text = proveedor.Nombres;
            }
            else
            {
                this.codigoProveedor = null;
                this.nroDocumentoIdentidadProveedor = null;
                txtNroDocIdentidadProveedor.Text = "";
                txtNombresProveedor.Text = "";
            }
        }

        void CargarPersonalInspeccion(int? codigoPersonalInspeccion)
        {
            PersonalBe personal = codigoPersonalInspeccion == null ? null : personalBl.ObtenerPersonal(codigoPersonalInspeccion.Value);
            if (personal != null)
            {
                this.codigoPersonalInspeccion = personal.CodigoPersonal;
                this.nroDocumentoIdentidadPersonalInspeccion = personal.NroDocumentoIdentidad;
                txtNroDocIdentidadPersonalInspeccion.Text = personal.NroDocumentoIdentidad;
                txtNombresPersonalInspeccion.Text = personal.Nombres;
            }
            else
            {
                this.codigoPersonalInspeccion = null;
                this.nroDocumentoIdentidadPersonalInspeccion = null;
                txtNroDocIdentidadPersonalInspeccion.Text = "";
                txtNombresPersonalInspeccion.Text = "";
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

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (nroDocumentoIdentidadProveedor == txtNroDocIdentidadProveedor.Text.Trim()) return;
            if (txtNroDocIdentidadProveedor.Text.Trim() == "") CargarProveedor(null);
            List<dynamic> listaColumnas = new List<dynamic>();
            listaColumnas.Add(new { Campo = "CodigoProveedor", NombreColumna = "CodigoProveedor", EsVisible = false, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = false });
            listaColumnas.Add(new { Campo = "NroDocumentoIdentidad", NombreColumna = "N° Doc. Identidad", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Nombres", NombreColumna = "Nombres", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Correo", NombreColumna = "Correo", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });

            string table = "dbo.Proveedor";
            DataGridViewColumn[] columns = listaColumnas.Select(x => {
                DataGridViewColumn column = x.TipoColumna;
                column.Name = $"dgvResultados_{x.Campo}";
                column.DataPropertyName = x.Campo;
                column.HeaderText = x.NombreColumna;
                column.Visible = x.EsVisible;
                return column;
            }).ToArray();
            string[] columnsFilter = listaColumnas.Where(x => x.EsFiltro).Select(x => (string)x.Campo).ToArray();

            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro("Buscar Proveedor", table, columns.Cast<DataGridViewColumn>().ToArray(), columnsFilter, typeof(ProveedorBe), txtNroDocIdentidadProveedor.Text.Trim());
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

        private void btnBuscarPersonalInspeccion_Click(object sender, EventArgs e)
        {
            if (nroDocumentoIdentidadPersonalInspeccion == txtNroDocIdentidadPersonalInspeccion.Text.Trim()) return;
            if (txtNroDocIdentidadPersonalInspeccion.Text.Trim() == "") CargarPersonalInspeccion(null);
            List<dynamic> listaColumnas = new List<dynamic>();
            listaColumnas.Add(new { Campo = "CodigoPersonal", NombreColumna = "CodigoPersonal", EsVisible = false, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = false });
            listaColumnas.Add(new { Campo = "NroDocumentoIdentidad", NombreColumna = "N° Doc. Identidad", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Nombres", NombreColumna = "Nombres", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });
            listaColumnas.Add(new { Campo = "Correo", NombreColumna = "Correo", EsVisible = true, TipoColumna = new DataGridViewTextBoxColumn(), EsFiltro = true });

            string table = "dbo.Personal";
            DataGridViewColumn[] columns = listaColumnas.Select(x => {
                DataGridViewColumn column = x.TipoColumna;
                column.Name = $"dgvResultados_{x.Campo}";
                column.DataPropertyName = x.Campo;
                column.HeaderText = x.NombreColumna;
                column.Visible = x.EsVisible;
                return column;
            }).ToArray();
            string[] columnsFilter = listaColumnas.Where(x => x.EsFiltro).Select(x => (string)x.Campo).ToArray();

            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro("Buscar Personal", table, columns.Cast<DataGridViewColumn>().ToArray(), columnsFilter, typeof(PersonalBe), txtNroDocIdentidadPersonalInspeccion.Text.Trim());
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarPersonalInspeccion(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarPersonalInspeccion(resultado.CodigoPersonal);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            ProductoIndividualBe registro = new ProductoIndividualBe();
            if (codigoProductoIndividual.HasValue) registro.CodigoProductoIndividual = codigoProductoIndividual.Value;
            registro.CodigoBarra = txtCodigoBarra.Text.Trim();
            registro.Nombre = txtNombre.Text.Trim();
            registro.CodigoProducto = codigoProducto.Value;
            registro.CodigoUnidadMedida = (int)cbbCodigoUnidadMedida.SelectedValue;
            registro.CodigoInicial = txtCodigoInicial.Text.Trim();
            registro.Metraje = decimal.Parse(txtMetraje.Text.Trim());
            registro.Peso = decimal.Parse(txtPeso.Text.Trim());
            registro.Rollo = decimal.Parse(txtRollo.Text.Trim());
            registro.Bulto = decimal.Parse(txtBulto.Text.Trim());
            registro.Color = txtColor.Text.Trim();
            registro.FechaEntrada = dtpFechaEntrada.Value;
            registro.CodigoBarraProveedor = txtCodigoBarraProveedor.Text.Trim();
            registro.CodigoProveedor = codigoProveedor.Value;
            registro.CodigoPersonalInspeccion = codigoPersonalInspeccion.Value;

            bool seGuardoRegistro = productoIndividualBl.GuardarProductoIndividual(registro);

            if (seGuardoRegistro)
            {
                DialogResult = MessageBox.Show("¡El registro se guardó correctamente!", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LimpiarErrores()
        {
            lblErrorCodigoBarra.Text = "";
            lblErrorNombre.Text = "";
            lblErrorProducto.Text = "";
            lblErrorCodigoUnidadMedida.Text = "";
            lblErrorCodigoInicial.Text = "";
            lblErrorMetraje.Text = "";
            lblErrorPeso.Text = "";
            lblErrorRollo.Text = "";
            lblErrorBulto.Text = "";
            lblErrorColor.Text = "";
            lblErrorFechaEntrada.Text = "";
            lblErrorCodigoBarraProveedor.Text = "";
            lblErrorProveedor.Text = "";
            lblErrorPersonalInspeccion.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            if(txtCodigoBarra.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorCodigoBarra.Text = "Debe ingresar codigo barra";
                SetToolTipError(lblErrorCodigoBarra);
            }

            if (txtNombre.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorNombre.Text = "Debe ingresar nombre";
                SetToolTipError(lblErrorNombre);
            }
            else
            {
                bool existeProductoIndividual = productoIndividualBl.ExisteProductoIndividual(txtNombre.Text.Trim(), codigoProductoIndividual);

                if (existeProductoIndividual)
                {
                    estaValidado = false;
                    lblErrorNombre.Text = $"El nombre ya existe";
                    SetToolTipError(lblErrorNombre);
                }
            }

            //if (txtNombre.Text.Trim() == "")
            //{
            //    estaValidado = false;
            //    lblErrorNombre.Text = "Debe ingresar nombre";
            //    SetToolTipError(lblErrorNombre);
            //}

            if(codigoProducto == null)
            {
                estaValidado = false;
                lblErrorProducto.Text = "Debe seleccionar producto";
                SetToolTipError(lblErrorProducto);
            }

            if (cbbCodigoUnidadMedida.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoUnidadMedida.Text = "Debe seleccionar unidad medida";
                SetToolTipError(lblErrorCodigoUnidadMedida);
            }

            if (txtCodigoInicial.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorCodigoInicial.Text = "Debe ingresar código inicial";
                SetToolTipError(lblErrorCodigoInicial);
            }

            if (txtMetraje.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorMetraje.Text = "Debe ingresar metraje";
                SetToolTipError(lblErrorMetraje);
            }
            else
            {
                decimal metraje = 0;

                if (!decimal.TryParse(txtMetraje.Text.Trim(), out metraje))
                {
                    estaValidado = false;
                    lblErrorMetraje.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorMetraje);
                }
            }

            if (txtPeso.Text.Trim() == "")
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

            if (txtRollo.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorRollo.Text = "Debe ingresar rollo";
                SetToolTipError(lblErrorRollo);
            }
            else
            {
                decimal rollo = 0;

                if (!decimal.TryParse(txtRollo.Text.Trim(), out rollo))
                {
                    estaValidado = false;
                    lblErrorRollo.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorRollo);
                }
            }

            if (txtBulto.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorBulto.Text = "Debe ingresar bulto";
                SetToolTipError(lblErrorBulto);
            }
            else
            {
                decimal bulto = 0;

                if (!decimal.TryParse(txtBulto.Text.Trim(), out bulto))
                {
                    estaValidado = false;
                    lblErrorBulto.Text = "Debe ingresar un valor numérico";
                    SetToolTipError(lblErrorBulto);
                }
            }

            if (txtColor.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorColor.Text = "Debe ingresar color";
                SetToolTipError(lblErrorColor);
            }

            if (txtCodigoBarraProveedor.Text.Trim() == "")
            {
                estaValidado = false;
                lblErrorCodigoBarraProveedor.Text = "Debe ingresar código barra proveedor";
                SetToolTipError(lblErrorCodigoBarraProveedor);
            }

            if (codigoProveedor == null)
            {
                estaValidado = false;
                lblErrorProveedor.Text = "Debe seleccionar proveedor";
                SetToolTipError(lblErrorProveedor);
            }

            if (codigoPersonalInspeccion == null)
            {
                estaValidado = false;
                lblErrorPersonalInspeccion.Text = "Debe seleccionar personal inspección";
                SetToolTipError(lblErrorPersonalInspeccion);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltProductoIndividual.SetToolTip(label, label.Text);
        }
    }
}
