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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using static pm.enums.Enums;

namespace pm.app
{
    public partial class FrmLetra : RadForm
    {
        LetraBl letraBl = new LetraBl();

        public FrmLetra()
        {
            InitializeComponent();
        }

        private void FrmLetra_Load(object sender, EventArgs e)
        {
            dtpFiltroFechaEmisionDesde.Value = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
            ListarComboEstado();
            BuscarFacturasVenta();
        }

        void ListarComboEstado()
        {
            List<Combo> listaCombo = Enum<EstadoLetra>.GetCollection().ToList();

            listaCombo.Insert(0, new Combo { Value = "-1", Text = "[Todos...]" });

            cbbEstado.DataSource = null;
            cbbEstado.DataSource = listaCombo;
        }

        void BuscarFacturasVenta()
        {
            DateTime fechaEmisionDesde = dtpFiltroFechaEmisionDesde.Value;
            DateTime fechaEmisionHasta = dtpFiltroFechaEmisionHasta.Value;
            string nroComprobante = txtFiltroNroComprobante.Text.Trim();
            string nroDocIdentidadCliente = txtFiltroNroDocIdentidadCliente.Text.Trim();
            string nombresCliente = txtFiltroNombresCliente.Text.Trim();
            int? estado = cbbEstado.SelectedValue.ToString() == "-1" ? null : (int?)int.Parse(cbbEstado.SelectedValue.ToString());
            bool flagActivo = chkActivo.Checked;

            List<LetraBe> resultados = letraBl.BuscarLetra(fechaEmisionDesde, fechaEmisionHasta, nroComprobante, nroDocIdentidadCliente, nombresCliente, estado, flagActivo);

            List<dynamic> resultadosDynamic = resultados == null ? null : resultados.Select(x => {
                dynamic row = new { x.Fila, x.CodigoLetra, x.CodigoUnicoBanco, x.CodigoBanco, NombreBanco = x.Banco == null ? "" : x.Banco.Nombre, NombreTipoComprobanteRef = x.TipoComprobanteRef.Nombre, x.SerialSerieComprobanteRef, x.NroComprobanteComprobanteRef, x.SerialSerieGuiaRemision, x.NroComprobanteGuiaRemision, x.FechaHoraEmision, FechaEmision = x.FechaHoraEmision.ToString("dd/MM/yyyy"), FechaVencimiento = x.FechaVencimiento.ToString("dd/MM/yyyy"), x.Dias, DiasPorVencer = x.FechaVencimiento < DateTime.Now ? 0 : (x.FechaVencimiento - DateTime.Now).Days, DiasDeVencido = x.FechaVencimiento > DateTime.Now ? 0 : (DateTime.Now - x.FechaVencimiento).Days > 9 ? 9 : (DateTime.Now - x.FechaVencimiento).Days, DescripcionTipoDocumentoIdentidadCliente = x.Cliente.TipoDocumentoIdentidad.Descripcion, NroDocumentoIdentidadCliente = x.Cliente.NroDocumentoIdentidad, NombresCliente = x.Cliente.Nombres, x.StrMoneda, x.Monto, x.Estado, x.StrEstado, x.FlagActivo, x.FlagCancelado };
                return row;
            }).ToList();

            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = resultadosDynamic;

            lblResultados.Text = (resultados == null) ? "No se encontraron resultados" : $"Se {(resultados.Count == 1 ? "encontró" : "encontraron")} {resultados.Count} {(resultados.Count == 1 ? "resultado" : "resultados")}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarFacturasVenta();
        }

        private void dgvResultados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvResultados.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow == -1) return;

                bool flagActivo = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagActivo"].Value;
                bool flagCancelado = (bool)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_FlagCancelado"].Value;
                int codigoLetra = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_CodigoLetra"].Value;
                int estado = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_Estado"].Value;
                int diasPorVencer = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_DiasPorVencer"].Value;
                int diasDeVencido = (int)dgvResultados.Rows[currentMouseOverRow].Cells["dgvResultados_DiasDeVencido"].Value;
                dynamic letraDynamic = (dynamic)dgvResultados.Rows[currentMouseOverRow].DataBoundItem;
                DateTime fechaVencimiento = DateTime.ParseExact(letraDynamic.FechaVencimiento, "dd/MM/yyyy", Thread.CurrentThread.CurrentCulture);
                LetraBe letra = new LetraBe
                {
                    CodigoLetra = letraDynamic.CodigoLetra,
                    CodigoBanco = letraDynamic.CodigoBanco,
                    CodigoUnicoBanco = letraDynamic.CodigoUnicoBanco,
                    Estado = letraDynamic.Estado
                };

                ContextMenu m = new ContextMenu();
                //MenuItem mitEditar = new MenuItem("Editar", mitEditar_Click);
                //mitEditar.Tag = codigoLetra;

                //MenuItem mitToggleActivar = new MenuItem(flagActivo ? "Inactivar" : "Activar", mitToggleActivar_Click);
                //mitToggleActivar.Tag = new { CodigoCliente = codigoCliente, FlagActivo = flagActivo };

                if (flagActivo && !flagCancelado && dgvResultados.SelectedRows.Count == 1)
                {
                    MenuItem mitAsignarBanco = new MenuItem("Asignar Banco", mitAsignarBanco_Click);
                    mitAsignarBanco.Tag = letra;

                    MenuItem mitRetirar = new MenuItem("Retirar", mitRetirar_Click);
                    mitRetirar.Tag = letra;

                    MenuItem mitProtestar = new MenuItem("Protestar", mitProtestar_Click);
                    mitProtestar.Tag = letra;

                    MenuItem mitPagar = new MenuItem("Pagar", mitPagar_Click);
                    mitPagar.Tag = letra;

                    switch ((EstadoLetra)estado)
                    {
                        case EstadoLetra.PorAsignarBanco:
                            m.MenuItems.Add(mitAsignarBanco);
                            break;
                        case EstadoLetra.Pendiente:
                            if (DateTime.Now <= fechaVencimiento) m.MenuItems.Add(mitRetirar);
                            if (fechaVencimiento < DateTime.Now) m.MenuItems.Add(mitProtestar);
                            if (DateTime.Now <= fechaVencimiento.AddDays(9)) m.MenuItems.Add(mitPagar);
                            break;
                        default:
                            break;
                    }
                    //m.MenuItems.Add(mitEditar);
                }

                if (dgvResultados.SelectedRows.Count >= 1)
                {
                    MenuItem mitVerFormato = new MenuItem("Ver Formato", mitVerFormato_Click);
                    mitVerFormato.Tag = letra;
                    m.MenuItems.Add(mitVerFormato);
                }
                //m.MenuItems.Add(mitToggleActivar);

                m.Show(dgvResultados, new Point(e.X, e.Y));
            }
        }

        private void mitEditar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int codigoLetra = (int)mitControl.Tag;

            //FrmMantenimientoLetra frm = new FrmMantenimientoLetra(codigoLetra);
            //FrmMantenimientoLetra frm = new FrmMantenimientoLetra(codigoLetra);
            //frm.ShowInTaskbar = false;
            //frm.BringToFront();
            //DialogResult dr = frm.ShowDialog();
            //if (dr == DialogResult.OK) BuscarFacturasVenta();
        }

        private void mitAsignarBanco_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            LetraBe obj = (LetraBe)mitControl.Tag;

            FrmLetraAsignarBanco frm = new FrmLetraAsignarBanco(obj);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarFacturasVenta();
        }

        private void mitRetirar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            LetraBe obj = (LetraBe)mitControl.Tag;

            FrmLetraAsignarBanco frm = new FrmLetraAsignarBanco(obj);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarFacturasVenta();
        }

        private void mitProtestar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            LetraBe obj = (LetraBe)mitControl.Tag;

            FrmLetraAsignarBanco frm = new FrmLetraAsignarBanco(obj);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarFacturasVenta();
        }

        private void mitPagar_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            LetraBe obj = (LetraBe)mitControl.Tag;

            FrmLetraAsignarBanco frm = new FrmLetraAsignarBanco(obj);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK) BuscarFacturasVenta();
        }

        private void mitVerFormato_Click(object sender, EventArgs e)
        {
            MenuItem mitControl = (MenuItem)sender;

            int[] codigosLetra = dgvResultados.SelectedRows.Cast<DataGridViewRow>().Select(x => (int)((dynamic)x.DataBoundItem).CodigoLetra).ToArray();

            FrmFormatoLetra frm = new FrmFormatoLetra(codigosLetra);
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            frm.ShowDialog();
            //DialogResult dr = frm.ShowDialog();
            //if (dr == DialogResult.OK) BuscarFacturasVenta();
        }
    }
}
