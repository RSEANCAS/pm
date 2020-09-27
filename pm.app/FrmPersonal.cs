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
using Telerik.WinControls.UI;
using static pm.enums.Enums;

namespace pm.app
{
    public partial class FrmPersonal : RadForm
    {
        PersonalBl personalBl = new PersonalBl();

        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            ListarComboEstado();
            BuscarPersonal();
        }

        void ListarComboEstado()
        {
            List<Combo> listaCombo = Enum<EstadoPersonal>.GetCollection().ToList();

            listaCombo.Insert(0, new Combo { Value = "-1", Text = "[Todos...]" });

            cbbEstado.DataSource = null;
            cbbEstado.DataSource = listaCombo;
        }

        void BuscarPersonal()
        {
            string nroDocumentoIdentidad = txtFiltroNroDocIdentidad.Text.Trim();
            string nombres = txtFiltroNombres.Text.Trim();
            string correo = txtFiltroCorreo.Text.Trim();
            string nombreArea = txtFiltroNombreArea.Text.Trim();
            int estadoInt = int.Parse(cbbEstado.SelectedValue.ToString());
            int? estado = estadoInt == -1 ? null : (int?)estadoInt;
            bool flagActivo = chkActivo.Checked;

            List<PersonalBe> resultados = personalBl.BuscarPersonal(nroDocumentoIdentidad, nombres, correo, nombreArea, estado, flagActivo);

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultados;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPersonal();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoPersonal frm = new FrmMantenimientoPersonal();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarPersonal();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                //int estado = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_Estado"].Value;
                int codigoPersonal = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoPersonal"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoPersonal;

                //if (estado == 0) 
                m.MenuItems.Add(mitEditar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoPersonal = (int)mitControl.Tag;

            FrmMantenimientoPersonal frm = new FrmMantenimientoPersonal(codigoPersonal);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarPersonal();
        }
    }
}
