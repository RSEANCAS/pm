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

namespace pm.app
{
    public partial class FrmComprobanteCompraDetalleProductoIndividual : RadForm
    {
        List<ProductoIndividualBe> _Detalle;
        ComprobanteCompraDetalleBe comprobanteCompraDetalle;

        ProductoIndividualBl productoIndividualBl = new ProductoIndividualBl();

        public List<ProductoIndividualBe> Detalle { get { return _Detalle; } }

        public FrmComprobanteCompraDetalleProductoIndividual(ComprobanteCompraDetalleBe comprobanteCompraDetalle, List<ProductoIndividualBe> detalle)
        {
            InitializeComponent();
            _Detalle = detalle ?? new List<ProductoIndividualBe>();
            this.comprobanteCompraDetalle = comprobanteCompraDetalle;
        }

        private void FrmComprobanteCompraDetalleProductoIndividual_Load(object sender, EventArgs e)
        {
            BuscarProductosIndividuales();
        }

        void BuscarProductosIndividuales()
        {
            string codigoProductoIndividualStr = txtFiltroCodigoProductoIndividual.Text.Trim();
            int outCodigoProductoIndividual = 0;
            bool codigoProductoIndividualIsNumber = int.TryParse(codigoProductoIndividualStr, out outCodigoProductoIndividual);
            int? codigoProductoIndividual = codigoProductoIndividualIsNumber ? (int?)outCodigoProductoIndividual : null;

            string codigoBarra = txtFiltroCodigoBarra.Text.Trim();

            string codigoProductoStr = txtFiltroCodigoProducto.Text.Trim();
            int outCodigoProducto = 0;
            bool codigoProductoIsNumber = int.TryParse(codigoProductoStr, out outCodigoProducto);
            int? codigoProducto = codigoProductoIsNumber ? (int?)outCodigoProducto : null;

            string nombre = txtFiltroNombre.Text.Trim();
            string color = txtFiltroColor.Text.Trim();

            List<ProductoIndividualBe> resultados = Detalle.Where(x =>
            (x.CodigoProductoIndividual == codigoProductoIndividual || codigoProductoIndividual == null) &&
            (x.CodigoBarra.ToLower().Contains(codigoBarra.ToLower()) || string.IsNullOrEmpty(codigoBarra)) &&
            (x.CodigoProducto == codigoProducto || codigoProducto == null) &&
            (x.Nombre.ToLower().Contains(nombre.ToLower()) || string.IsNullOrEmpty(nombre)) &&
            (x.Color.ToLower().Contains(color.ToLower()) || string.IsNullOrEmpty(color))
            ).ToList();

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultados;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProductosIndividuales();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Detalle.Count == comprobanteCompraDetalle.Cantidad)
            {
                MessageBox.Show($"Sólo puede ingresar máximo {comprobanteCompraDetalle.Cantidad} registros", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmMantenimientoProductoIndividual frm = new FrmMantenimientoProductoIndividual(null, comprobanteCompraDetalle);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _Detalle.Add(frm.ProductoIndividual);
                _Detalle = _Detalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                BuscarProductosIndividuales();
            }
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                int codigoProductoIndividual = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoProductoIndividual"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoProductoIndividual;

                //if (estado == 0) 
                m.MenuItems.Add(mitEditar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoProductoIndividual = (int)mitControl.Tag;
            int indexData = Detalle.FindIndex(x => x.CodigoProductoIndividual == codigoProductoIndividual);
            var item = Detalle.Find(x => x.CodigoProductoIndividual == codigoProductoIndividual);

            FrmMantenimientoProductoIndividual frm = new FrmMantenimientoProductoIndividual(codigoProductoIndividual, comprobanteCompraDetalle, item);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _Detalle[indexData] = frm.ProductoIndividual;
                //_Detalle.Add(frm.ProductoIndividual);
                _Detalle = _Detalle.Select((x, i) => { x.Fila = i + 1; return x; }).ToList();
                BuscarProductosIndividuales();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            DialogResult = DialogResult.OK;
        }

        void LimpiarErrores()
        {
            lblErrorDetalle.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltListaProductoIndividual.SetToolTip(label, label.Text);
        }
    }
}
