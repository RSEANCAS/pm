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
    public partial class FrmActividad : RadForm
    {
        ActividadBl actividadBl = new ActividadBl();

        public FrmActividad()
        {
            InitializeComponent();
        }

        private void FrmActividad_Load(object sender, EventArgs e)
        {
            BuscarActividades();
        }

        void BuscarActividades()
        {
            string nombre = txtFiltroNombre.Text.Trim();
            bool flagActivo = chkActivo.Checked;

            List<ActividadBe> resultados = actividadBl.BuscarActividad(nombre, flagActivo);

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultados;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarActividades();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoActividad frm = new FrmMantenimientoActividad();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarActividades();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagActivo = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagActivo"].Value;
                int codigoActividad = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoActividad"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoActividad;

                MenuItem mitToggleActivar = new MenuItem(flagActivo ? "Inactivar" : "Activar", mitToggleActivar_Click);
                mitToggleActivar.Tag = new { CodigoActividad = codigoActividad, FlagActivo = flagActivo };

                if (flagActivo) m.MenuItems.Add(mitEditar);
                m.MenuItems.Add(mitToggleActivar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoActividad = (int)mitControl.Tag;

            FrmMantenimientoActividad frm = new FrmMantenimientoActividad(codigoActividad);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarActividades();
        }

        private void mitToggleActivar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;
            dynamic data = (object)mitControl.Tag;

            DialogResult dr = MessageBox.Show($"¿Estás seguro que deseas {(data.FlagActivo ? "Inactivar" : "Activar")} el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                ActividadBe registro = new ActividadBe();
                registro.CodigoActividad = data.CodigoActividad;
                registro.FlagActivo = !data.FlagActivo;
                bool seGuardo = actividadBl.CambiarFlagActivoActividad(registro);
                if (seGuardo)
                {
                    MessageBox.Show($"Se cambió el estado del registro a {(registro.FlagActivo ? "Activo" : "Inactivo")}", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarActividades();
                }
                else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
