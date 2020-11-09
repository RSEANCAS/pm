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
    public partial class FrmMotivoNota : RadForm
    {
        MotivoNotaBl motivoNotaBl = new MotivoNotaBl();

        public FrmMotivoNota()
        {
            InitializeComponent();
        }

        private void FrmMotivoNota_Load(object sender, EventArgs e)
        {
            BuscarMotivosNota();
        }

        void BuscarMotivosNota()
        {
            string nombre = txtFiltroDescripcion.Text.Trim();
            bool flagActivo = chkActivo.Checked;

            List<MotivoNotaBe> resultados = motivoNotaBl.BuscarMotivoNota(nombre, flagActivo);

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultados;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarMotivosNota();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoMotivoNota frm = new FrmMantenimientoMotivoNota();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarMotivosNota();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagActivo = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagActivo"].Value;
                int codigoMotivoNota = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoMotivoNota"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoMotivoNota;

                MenuItem mitToggleActivar = new MenuItem(flagActivo ? "Inactivar" : "Activar", mitToggleActivar_Click);
                mitToggleActivar.Tag = new { CodigoMotivoNota = codigoMotivoNota, FlagActivo = flagActivo };

                if (flagActivo) m.MenuItems.Add(mitEditar);
                m.MenuItems.Add(mitToggleActivar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoMotivoNota = (int)mitControl.Tag;

            FrmMantenimientoMotivoNota frm = new FrmMantenimientoMotivoNota(codigoMotivoNota);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarMotivosNota();
        }

        private void mitToggleActivar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;
            dynamic data = (object)mitControl.Tag;

            DialogResult dr = MessageBox.Show($"¿Estás seguro que deseas {(data.FlagActivo ? "Inactivar" : "Activar")} el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MotivoNotaBe registro = new MotivoNotaBe();
                registro.CodigoMotivoNota = data.CodigoMotivoNota;
                registro.FlagActivo = !data.FlagActivo;
                bool seGuardo = motivoNotaBl.CambiarFlagActivoMotivoNota(registro);
                if (seGuardo)
                {
                    MessageBox.Show($"Se cambió el estado del registro a {(registro.FlagActivo ? "Activo" : "Inactivo")}", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarMotivosNota();
                }
                else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
