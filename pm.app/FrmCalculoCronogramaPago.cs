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

namespace pm.app
{
    public partial class FrmCalculoCronogramaPago : RadForm
    {
        DateTime fechaHoraEmision;
        int cantidadLetrasCredito;
        int cantidadDiasXDefecto = 30;
        decimal totalImporte;
        List<LetraBe> _Lista = new List<LetraBe>();
        public List<LetraBe> Lista { get { return _Lista; } }

        BancoBl bancoBl = new BancoBl();

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
                        Monto = cuota
                    };

                    fechaPagoActual = fechaPagoActual.AddDays(cantidadDiasXDefecto);

                    _Lista = _Lista ?? new List<LetraBe>();
                    _Lista.Add(item);
                }
            }

            ListarCronograma();
        }

        void ListarCombos()
        {
            ListarComboBanco();
        }

        void ListarComboBanco()
        {
            List<BancoBe> listaCombo = bancoBl.ListarComboBanco();
            listaCombo = listaCombo ?? new List<BancoBe>();
            listaCombo.Insert(0, new BancoBe { CodigoBanco = -1, Nombre = "[Seleccione...]" });

            cbbCodigoBanco.DataSource = null;
            cbbCodigoBanco.DataSource = listaCombo;
        }

        void ListarCronograma()
        {
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = _Lista;

            for (int i = 0; i < dgvResultados.RowCount; i++)
            {
                dgvResultados["dgvResultados_Dias", i].ReadOnly = false;
            }
        }

        private void dgvResultados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dgvResultados[e.ColumnIndex, e.RowIndex].ReadOnly) return;

            var item = (LetraBe)dgvResultados.Rows[e.RowIndex].DataBoundItem;
            int indexItem = _Lista.IndexOf(item);

            string valorEditado = dgvResultados[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();
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

            ListarCronograma();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool estaValidado = ValidarFormulario();

            if (!estaValidado) return;

            DialogResult = DialogResult.Yes;
        }

        void LimpiarErrores()
        {
            lblErrorCodigoBanco.Text = "";
        }

        bool ValidarFormulario()
        {
            bool estaValidado = true;

            LimpiarErrores();


            if (cbbCodigoBanco.SelectedIndex == 0)
            {
                estaValidado = false;
                lblErrorCodigoBanco.Text = "Debe seleccionar un banco";
                SetToolTipError(lblErrorCodigoBanco);
            }

            return estaValidado;
        }

        void SetToolTipError(Label label)
        {
            tltCalculoCronogramaPago.SetToolTip(label, label.Text);
        }
    }
}