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
    public partial class FrmProducto : Form
    {
        ProductoBl productoBl = new ProductoBl();

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ListarComboEstado();
            BuscarProductos();
        }

        void ListarComboEstado()
        {
            List<Combo> listaCombo = Enum<EstadoProducto>.GetCollection().ToList();

            listaCombo.Insert(0, new Combo { Value = "-1", Text = "[Todos...]" });

            cbbEstado.DataSource = null;
            cbbEstado.DataSource = listaCombo;
        }

        void BuscarProductos()
        {
            string codigoProductoStr = txtFiltroCodigoProducto.Text.Trim();
            int outCodigoProducto = 0;
            bool codigoProductoIsNumber = int.TryParse(codigoProductoStr, out outCodigoProducto);
            int? codigoProducto = codigoProductoIsNumber ? (int?)outCodigoProducto : null;
            string nombres = txtFiltroNombres.Text.Trim();
            string color = txtFiltroColor.Text.Trim();
            int estadoInt = int.Parse(cbbEstado.SelectedValue.ToString());
            int? estado = estadoInt == -1 ? null : (int?)estadoInt;

            List<ProductoBe> resultados = productoBl.BuscarProducto(codigoProducto, nombres, color, estado);

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultados;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoProducto frm = new FrmMantenimientoProducto();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarProductos();
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

            int codigoProducto = (int)mitControl.Tag;

            FrmMantenimientoProducto frm = new FrmMantenimientoProducto(codigoProducto);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarProductos();
        }
    }
}
