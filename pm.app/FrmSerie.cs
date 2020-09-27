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
    public partial class FrmSerie : RadForm
    {
        SerieBl serieBl = new SerieBl();
        TipoComprobanteBl tipoComprobanteBl = new TipoComprobanteBl();

        public FrmSerie()
        {
            InitializeComponent();
        }

        private void FrmSerie_Load(object sender, EventArgs e)
        {
            ListarComboTipoComprobante();
            BuscarSeries();
        }

        void ListarComboTipoComprobante()
        {
            List<TipoComprobanteBe> listaCombo = tipoComprobanteBl.ListarComboTipoComprobante() ?? new List<TipoComprobanteBe>();

            listaCombo.Insert(0, new TipoComprobanteBe { CodigoTipoComprobante = -1, Nombre = "[Todos...]" });

            cbbFiltroCodigoTipoComprobante.DataSource = null;
            cbbFiltroCodigoTipoComprobante.DataSource = listaCombo;
        }

        void BuscarSeries()
        {
            string serial = txtFiltroSerial.Text.Trim();
            int codigoTipoComprobanteInt = (int)cbbFiltroCodigoTipoComprobante.SelectedValue;
            int? codigoTipoComprobante = codigoTipoComprobanteInt == -1 ? null : (int?)codigoTipoComprobanteInt;
            bool flagActivo = chkActivo.Checked;

            List<SerieBe> resultados = serieBl.BuscarSerie(serial, codigoTipoComprobante, flagActivo);

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultados;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarSeries();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoSerie frm = new FrmMantenimientoSerie();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarSeries();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagActivo = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagActivo"].Value;
                int codigoSerie = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoSerie"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoSerie;

                MenuItem mitToggleActivar = new MenuItem(flagActivo ? "Inactivar" : "Activar", mitToggleActivar_Click);
                mitToggleActivar.Tag = new { CodigoSerie = codigoSerie, FlagActivo = flagActivo };

                if (flagActivo) m.MenuItems.Add(mitEditar);
                m.MenuItems.Add(mitToggleActivar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoSerie = (int)mitControl.Tag;

            FrmMantenimientoSerie frm = new FrmMantenimientoSerie(codigoSerie);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarSeries();
        }

        private void mitToggleActivar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;
            dynamic data = (object)mitControl.Tag;

            DialogResult dr = MessageBox.Show($"¿Estás seguro que deseas {(data.FlagActivo ? "Inactivar" : "Activar")} el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SerieBe registro = new SerieBe();
                registro.CodigoSerie = data.CodigoSerie;
                registro.FlagActivo = !data.FlagActivo;
                bool seGuardo = serieBl.CambiarFlagActivoSerie(registro);
                if (seGuardo)
                {
                    MessageBox.Show($"Se cambió el estado del registro a {(registro.FlagActivo ? "Activo" : "Inactivo")}", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarSeries();
                }
                else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
