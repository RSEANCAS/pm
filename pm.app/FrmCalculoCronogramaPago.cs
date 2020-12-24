using pm.be;
using pm.bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using static pm.enums.Enums;

namespace pm.app
{
    public partial class FrmCalculoCronogramaPago : RadForm
    {
        DateTime fechaHoraEmision;
        int cantidadLetrasCredito;
        int cantidadDiasXDefecto = 30;
        decimal totalImporte;
        List<LetraBe> _Lista = new List<LetraBe>();

        int? codigoAval, codigoDistritoAval;
        string nombrePaisAval, nombreDepartamentoAval, nombreProvinciaAval, nombreDistritoAval;
        string nroDocumentoIdentidadAval;

        ClienteBl clienteBl = new ClienteBl();
        ControlBusquedaBl controlBusquedaBl = new ControlBusquedaBl();

        public List<LetraBe> Lista { get { return _Lista; } }

        public FrmCalculoCronogramaPago(DateTime fechaHoraEmision, int cantidadLetrasCredito, decimal totalImporte, List<LetraBe> listaLetra)
        {
            InitializeComponent();
            this.fechaHoraEmision = fechaHoraEmision;
            this.cantidadLetrasCredito = cantidadLetrasCredito;
            this.totalImporte = totalImporte;
            _Lista = listaLetra;
        }

        private void FrmCalculoCronogramaPago_Load(object sender, EventArgs e)
        {
            txtImporteFactura.Text = totalImporte.ToString("0.00");
            dgvResultados.AutoGenerateColumns = false;

            if (_Lista == null)
            {
                decimal cuota = totalImporte / cantidadLetrasCredito;

                DateTime fechaPagoActual = fechaHoraEmision;
                for (int i = 0; i < cantidadLetrasCredito; i++)
                {
                    var item = new LetraBe
                    {
                        Fila = i + 1,
                        Dias = cantidadDiasXDefecto,
                        FechaHoraEmision = fechaHoraEmision,
                        FechaVencimiento = fechaPagoActual,
                        Monto = cuota,
                        Estado = (int)EstadoLetra.PorAsignarBanco
                    };

                    fechaPagoActual = fechaPagoActual.AddDays(cantidadDiasXDefecto);

                    _Lista = _Lista ?? new List<LetraBe>();
                    _Lista.Add(item);
                }
            }

            ListarCronograma();
        }

        void ListarCronograma()
        {
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = _Lista;

            //for (int i = 0; i < dgvResultados.RowCount; i++)
            //{
            //    dgvResultados["dgvResultados_Dias", i].ReadOnly = false;
            //    dgvResultados["dgvResultados_Monto", i].ReadOnly = false;
            //}
            CalcularTotalLetras();
        }

        void CalcularTotalLetras()
        {
            decimal total = _Lista.Sum(x => x.Monto);
            txtImporteTotalLetras.Text = total.ToString("0.00");
        }

        private void dgvResultados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dgvResultados[e.ColumnIndex, e.RowIndex].ReadOnly) return;

            var item = (LetraBe)dgvResultados.Rows[e.RowIndex].DataBoundItem;
            int indexItem = _Lista.IndexOf(item);
            string valorEditado = dgvResultados[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();

            string columnName = dgvResultados.Columns[e.ColumnIndex].Name;
            if (columnName == "dgvResultados_Dias")
            {
                int cantidadDias = 0;

                if (!int.TryParse(valorEditado, out cantidadDias))
                {
                    MessageBox.Show("Debe ingresar un valor numérico entero", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _Lista[indexItem].Dias = cantidadDias;

                DateTime ultimaFecha = fechaHoraEmision;

                for (int i = indexItem; i < _Lista.Count; i++)
                {
                    if (i > 0) ultimaFecha = (DateTime)(dgvResultados["dgvResultados_FechaVencimiento", i - 1].Value);
                    ultimaFecha = ultimaFecha.AddDays(_Lista[i].Dias);
                    _Lista[i].FechaVencimiento = ultimaFecha;
                }
            }
            else if (columnName == "dgvResultados_Monto")
            {
                decimal monto = 0;

                if (!decimal.TryParse(valorEditado, out monto))
                {
                    MessageBox.Show("Debe ingresar un valor numérico entero", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _Lista[indexItem].Monto = monto;
            }

            ListarCronograma();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            decimal sumaMonto = _Lista.Sum(x => Math.Round(x.Monto, 2));

            if(sumaMonto != totalImporte)
            {
                MessageBox.Show($"La suma de los montos es ({sumaMonto}) y debe ser igual a {totalImporte}", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Lista = _Lista.Select(x =>
            {
                x.FlagAval = chkTieneAval.Checked;
                if (x.FlagAval)
                {
                    x.CodigoAval = codigoAval;
                    x.DireccionAval = txtDireccionAval.Text.Trim();
                    x.NombrePaisAval = nombrePaisAval;
                    x.NombreDepartamentoAval = nombreDepartamentoAval;
                    x.NombreProvinciaAval = nombreProvinciaAval;
                    x.NombreDistritoAval = nombreDistritoAval;
                    x.CodigoDistritoAval = codigoDistritoAval.Value;
                }
                return x;
            }).ToList();

            DialogResult = DialogResult.Yes;
        }

        private void chkTieneAval_CheckedChanged(object sender, EventArgs e)
        {
            gpbAval.Enabled = chkTieneAval.Checked;
            if (!chkTieneAval.Checked) CargarAval(null);
        }

        private void btnBuscarAval_Click(object sender, EventArgs e)
        {
            if (nroDocumentoIdentidadAval == txtNroDocumentoIdentidadAval.Text.Trim()) return;
            if (txtNroDocumentoIdentidadAval.Text.Trim() == "") CargarAval(null);
            string formulario = this.GetType().FullName;
            string control = ((Control)sender).Name;
            ControlBusquedaBe item = controlBusquedaBl.ObtenerControlBusqueda(formulario, control, true);
            if (item == null) return;
            FrmBusquedaSeleccionarRegistro frm = new FrmBusquedaSeleccionarRegistro(item, txtNroDocumentoIdentidadAval.Text.Trim());
            frm.ShowInTaskbar = false;
            frm.BringToFront();
            DialogResult dr = frm.ShowDialog();
            CargarAval(null);
            if (dr == DialogResult.OK)
            {
                dynamic resultado = frm.Resultado;
                CargarAval(resultado.CodigoCliente);
            }
        }

        void CargarAval(int? codigoAval)
        {
            ClienteBe aval = codigoAval == null ? null : clienteBl.ObtenerCliente(codigoAval.Value);
            if (aval != null)
            {
                this.codigoAval = aval.CodigoCliente;
                this.nroDocumentoIdentidadAval = aval.NroDocumentoIdentidad;
                cbbCodigoTipoDocumentoIdentidadAval.SelectedValue = aval.CodigoTipoDocumentoIdentidad;
                txtNroDocumentoIdentidadAval.Text = aval.NroDocumentoIdentidad;
                txtNombresAval.Text = aval.Nombres;
                txtCorreoAval.Text = aval.Correo;
                txtDireccionAval.Text = aval.Direccion;
                if (aval.Distrito != null)
                {
                    codigoDistritoAval = aval.CodigoDistrito;
                    nombrePaisAval = aval.Distrito.Provincia.Departamento.Pais.ToString();
                    nombreDepartamentoAval = aval.Distrito.Provincia.Departamento.ToString();
                    nombreProvinciaAval = aval.Distrito.Provincia.ToString();
                    nombreDistritoAval = aval.Distrito.ToString();
                    txtUbicacionAval.Text = $"{aval.Distrito.Provincia.Departamento.Pais} - {aval.Distrito.Provincia.Departamento} - {aval.Distrito.Provincia} - {aval.Distrito}";
                }
            }
            else
            {
                this.codigoAval = null;
                this.nroDocumentoIdentidadAval = null;
                if (cbbCodigoTipoDocumentoIdentidadAval.Items.Count > 0)cbbCodigoTipoDocumentoIdentidadAval.SelectedIndex = 0;
                txtNroDocumentoIdentidadAval.Text = "";
                txtNombresAval.Text = "";
                txtCorreoAval.Text = "";
                txtDireccionAval.Text = "";
                txtUbicacionAval.Text = "";
            }
        }
    }
}