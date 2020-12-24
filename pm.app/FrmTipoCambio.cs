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
    public partial class FrmTipoCambio : RadForm
    {
        TipoCambioBl tipoCambioBl = new TipoCambioBl();

        public FrmTipoCambio()
        {
            InitializeComponent();
        }

        private void FrmTipoCambio_Load(object sender, EventArgs e)
        {
            BuscarMotivosNota();
        }

        void BuscarMotivosNota()
        {
            DateTime fechaCambioDesde = dtpFiltroFechaDesde.Value;
            DateTime fechaCambioHasta = dtpFiltroFechaHasta.Value;

            List<TipoCambioBe> resultados = tipoCambioBl.BuscarTipoCambio(fechaCambioDesde, fechaCambioHasta);

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
            FrmMantenimientoTipoCambio frm = new FrmMantenimientoTipoCambio();
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

                int codigoTipoCambio = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoTipoCambio"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoTipoCambio;

                m.MenuItems.Add(mitEditar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoTipoCambio = (int)mitControl.Tag;

            FrmMantenimientoTipoCambio frm = new FrmMantenimientoTipoCambio(codigoTipoCambio);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarMotivosNota();
        }
    }
}
