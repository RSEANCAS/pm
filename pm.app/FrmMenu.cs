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
    public partial class FrmMenu : RadForm
    {
        MenuBl menuBl = new MenuBl();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            BuscarMenues();
        }

        void BuscarMenues()
        {
            string nombre = txtFiltroNombre.Text.Trim();
            string formulario = txtFiltroFormulario.Text.Trim();
            bool flagActivo = chkActivo.Checked;

            List<MenuBe> resultados = menuBl.BuscarMenu(nombre, formulario, flagActivo);

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultados;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarMenues();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoMenu frm = new FrmMantenimientoMenu();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarMenues();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagActivo = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagActivo"].Value;
                int codigoMenu = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoMenu"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoMenu;

                MenuItem mitToggleActivar = new MenuItem(flagActivo ? "Inactivar" : "Activar", mitToggleActivar_Click);
                mitToggleActivar.Tag = new { CodigoMenu = codigoMenu, FlagActivo = flagActivo };

                if (flagActivo) m.MenuItems.Add(mitEditar);
                m.MenuItems.Add(mitToggleActivar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoMenu = (int)mitControl.Tag;

            FrmMantenimientoMenu frm = new FrmMantenimientoMenu(codigoMenu);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarMenues();
        }

        private void mitToggleActivar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;
            dynamic data = (object)mitControl.Tag;

            DialogResult dr = MessageBox.Show($"¿Estás seguro que deseas {(data.FlagActivo ? "Inactivar" : "Activar")} el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MenuBe registro = new MenuBe();
                registro.CodigoMenu = data.CodigoMenu;
                registro.FlagActivo = !data.FlagActivo;
                bool seGuardo = menuBl.CambiarFlagActivoMenu(registro);
                if (seGuardo)
                {
                    MessageBox.Show($"Se cambió el estado del registro a {(registro.FlagActivo ? "Activo" : "Inactivo")}", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarMenues();
                }
                else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
