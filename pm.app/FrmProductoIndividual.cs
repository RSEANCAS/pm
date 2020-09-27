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
    public partial class FrmProductoIndividual : RadForm
    {
        ProductoIndividualBl productoIndividualBl = new ProductoIndividualBl();

        public FrmProductoIndividual()
        {
            InitializeComponent();
        }

        private void FrmProductoIndividual_Load(object sender, EventArgs e)
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
            string codigoInicial = txtFiltroCodigoInicial.Text.Trim();
            string color = txtFiltroColor.Text.Trim();
            string nroDocumentoIdentidadProveedor = txtFiltroNroDocIdentidadProveedor.Text.Trim();
            string nombresProveedor = txtFiltroNombresProveedor.Text.Trim();
            DateTime fechaEntradaDesde = dtpFechaEntradaDesde.Value;
            DateTime fechaEntradaHasta = dtpFechaEntradaHasta.Value;
            string nroDocumentoIdentidadPersonalInspeccion = txtFiltroNroDocIdentidadPersonal.Text.Trim();
            string nombresPersonalInspeccion = txtFiltroNombresPersonal.Text.Trim();

            List<ProductoIndividualBe> resultados = productoIndividualBl.BuscarProductoIndividual(codigoProductoIndividual, codigoBarra, codigoProducto, nombre, codigoInicial, color, nroDocumentoIdentidadProveedor, nombresProveedor, fechaEntradaDesde, fechaEntradaHasta, nroDocumentoIdentidadPersonalInspeccion, nombresPersonalInspeccion);

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
            FrmMantenimientoProductoIndividual frm = new FrmMantenimientoProductoIndividual();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarProductosIndividuales();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                //int estado = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_Estado"].Value;
                int codigoProducto = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoProducto"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoProducto;

                //if (estado == 0) 
                m.MenuItems.Add(mitEditar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoProductoIndividual = (int)mitControl.Tag;

            FrmMantenimientoProductoIndividual frm = new FrmMantenimientoProductoIndividual(codigoProductoIndividual);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarProductosIndividuales();
        }
    }
}
