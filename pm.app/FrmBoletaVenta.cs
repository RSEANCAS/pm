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
using static pm.enums.Enums;

namespace pm.app
{
    public partial class FrmBoletaVenta : Form
    {
        BoletaVentaBl boletaVentaBl = new BoletaVentaBl();
        SerieBl serieBl = new SerieBl();

        public FrmBoletaVenta()
        {
            InitializeComponent();
        }

        private void FrmBoletaVenta_Load(object sender, EventArgs e)
        {
            dtpFiltroFechaEmisionDesde.Value = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
            ListarComboSerie();
            BuscarBoletasVenta();
        }

        void ListarComboSerie()
        {
            List<SerieBe> listaCombo = serieBl.ListarComboSerie((int)TipoComprobante.Boleta) ?? new List<SerieBe>();

            listaCombo.Insert(0, new SerieBe { CodigoSerie = -1, Serial = "[Todos...]" });

            cbbFiltroCodigoSerie.DataSource = null;
            cbbFiltroCodigoSerie.DataSource = listaCombo;
        }

        void BuscarBoletasVenta()
        {
            DateTime fechaEmisionDesde = dtpFiltroFechaEmisionDesde.Value;
            DateTime fechaEmisionHasta = dtpFiltroFechaEmisionHasta.Value;
            int codigoSerieInt = (int)cbbFiltroCodigoSerie.SelectedValue;
            int? codigoSerie = codigoSerieInt == -1 ? null : (int?)codigoSerieInt;
            string nroComprobante = txtFiltroNroComprobante.Text.Trim();
            string nroDocIdentidadCliente = txtFiltroNroDocIdentidadCliente.Text.Trim();
            string nombresCliente = txtFiltroNombresCliente.Text.Trim();
            bool flagActivo = chkActivo.Checked;

            List<BoletaVentaBe> resultados = boletaVentaBl.BuscarBoletaVenta(fechaEmisionDesde, fechaEmisionHasta, codigoSerie, nroComprobante, nroDocIdentidadCliente, nombresCliente, flagActivo);

            List<dynamic> resultadosDynamic = resultados == null ? null : resultados.Select(x => {
                dynamic row = new { x.Fila, x.Serie, x.FechaHoraEmision, FechaEmision = x.FechaHoraEmision.ToString("dd/MM/yyyy"), x.FechaHoraVencimiento, FechaVencimiento = x.FechaHoraVencimiento.ToString("dd/MM/yyyy"), DescripcionTipoDocumentoIdentidadCliente = x.Cliente.TipoDocumentoIdentidad.Descripcion, NroDocumentoIdentidadCliente = x.Cliente.NroDocumentoIdentidad, NombresCliente = x.Cliente.Nombres, x.TotalImporte, x.FlagEmitido, x.FlagActivo };
                return row;
            }).ToList();

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultados;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarBoletasVenta();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMantenimientoBoletaVenta frm = new FrmMantenimientoBoletaVenta();
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarBoletasVenta();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagActivo = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagActivo"].Value;
                bool flagEmitido = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagEmitido"].Value;
                int codigoBoletaVenta = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoBoletaVenta"].Value;

                ContextMenu m = new ContextMenu();
                MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                mitEditar.Tag = codigoBoletaVenta;

                //MenuItem mitToggleActivar = new MenuItem(flagActivo ? "Inactivar" : "Activar", mitToggleActivar_Click);
                //mitToggleActivar.Tag = new { CodigoCliente = codigoCliente, FlagActivo = flagActivo };

                if (flagActivo && !flagEmitido) m.MenuItems.Add(mitEditar);
                //m.MenuItems.Add(mitToggleActivar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoBoletaVenta = (int)mitControl.Tag;

            FrmMantenimientoBoletaVenta frm = new FrmMantenimientoBoletaVenta(codigoBoletaVenta);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarBoletasVenta();
        }

        //private void mitToggleActivar_Click(object sender, EventArgs e)
        //{
        //    MenuItem mitControl = (MenuItem)sender;
        //    dynamic data = (object)mitControl.Tag;

        //    DialogResult dr = MessageBox.Show($"¿Estás seguro que deseas {(data.FlagActivo ? "Inactivar" : "Activar")} el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (dr == DialogResult.Yes)
        //    {
        //        ClienteBe registro = new ClienteBe();
        //        registro.CodigoCliente = data.CodigoCliente;
        //        registro.FlagActivo = !data.FlagActivo;
        //        bool seGuardo = boletaVentaBl.CambiarFlagActivoCliente(registro);
        //        if (seGuardo)
        //        {
        //            MessageBox.Show($"Se cambió el estado del registro a {(registro.FlagActivo ? "Activo" : "Inactivo")}", "¡Bien hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            BuscarClientes();
        //        }
        //        else MessageBox.Show("¡Ocurrió un error! Contáctese con el administrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
