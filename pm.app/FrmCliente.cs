using pm.be;
using pm.bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pm.app
{
    public partial class FrmCliente : Form
    {
        ClienteBl clienteBl = new ClienteBl();

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        void BuscarClientes()
        {
            string nroDocumentoIdentidad = txtFiltroNroDocIdentidad.Text.Trim();
            string nombres = txtFiltroNombres.Text.Trim();
            string direccion = txtFiltroDireccion.Text.Trim();
            string correo = txtFiltroCorreo.Text.Trim();
            string contacto = txtFiltroContacto.Text.Trim();
            string areaContacto = txtFiltroAreaContacto.Text.Trim();
            bool flagActivo = chkActivo.Checked;

            List<ClienteBe> resultados = clienteBl.BuscarCliente(nroDocumentoIdentidad, nombres, direccion, correo, contacto, areaContacto, flagActivo);

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultados;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoCliente frm = new FrmMantenimientoCliente();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarClientes();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagActivo = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagActivo"].Value;
                int codigoCliente = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoCliente"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoCliente;

                MenuItem mitToggleActivar = new MenuItem(flagActivo ? "Inactivar" : "Activar", mitToggleActivar_Click);
                mitToggleActivar.Tag = new { CodigoCliente = codigoCliente, FlagActivo = flagActivo };

                if(flagActivo) m.MenuItems.Add(mitEditar);
                m.MenuItems.Add(mitToggleActivar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoCliente = (int)mitControl.Tag;

            FrmMantenimientoCliente frm = new FrmMantenimientoCliente(codigoCliente);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarClientes();
        }

        private void mitToggleActivar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;
            dynamic data = (object)mitControl.Tag;

            DialogResult dr = MessageBox.Show($"¿Estás seguro que deseas {(data.FlagActivo ? "Inactivar" : "Activar")} el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                ClienteBe registro = new ClienteBe();
                registro.CodigoCliente = data.CodigoCliente;
                registro.FlagActivo = !data.FlagActivo;
                bool seGuardo = clienteBl.CambiarFlagActivoCliente(registro);
                if (seGuardo)
                {
                    MessageBox.Show($"Se cambió el estado del registro a {(registro.FlagActivo ? "Activo" : "Inactivo")}", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarClientes();
                }
                else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
