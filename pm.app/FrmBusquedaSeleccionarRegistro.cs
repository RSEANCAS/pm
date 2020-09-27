using pm.bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace pm.app
{
    public partial class FrmBusquedaSeleccionarRegistro : RadForm
    {
        dynamic _Resultado;
        public dynamic Resultado { get { return _Resultado; } }
        string table, columns, columnsFilter;
        Type type;

        CommonBl commonBl = new CommonBl();

        public FrmBusquedaSeleccionarRegistro(string title, string table, DataGridViewColumn[] columns, string[] columnsFilter, Type type, string filtroBusqueda = "")
        {
            InitializeComponent();
            Text = title;
            this.table = table;
            this.columns = string.Join($",{Environment.NewLine}", columns.Select(x => x.DataPropertyName).ToArray());
            this.columnsFilter = string.Join($" or{Environment.NewLine}", columnsFilter.Select(x => $"{x} like '%{{0}}%'").ToArray());
            txtFiltroBusqueda.Text = (filtroBusqueda ?? "").Trim();
            this.type = type;
            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.Columns.AddRange(columns);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FrmBusquedaSeleccionarRegistro_Load(object sender, EventArgs e)
        {
            Buscar(true);
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvResultados.CurrentRow.Index;

            _Resultado = dgvResultados.Rows[rowIndex].DataBoundItem;
            DialogResult = DialogResult.OK;
            Close();
            
        }

        void Buscar(bool retornarRegistro = false)
        {
            string busqueda = txtFiltroBusqueda.Text.Trim();

            string where = string.Format(columnsFilter, busqueda);

            List<dynamic> lista = commonBl.BuscarQuery(table, columns, where);

            if (lista != null)
            {
                lista = lista.Cast<ExpandoObject>().Select(x =>
                {
                    var obj = Activator.CreateInstance(type);

                    foreach(var item in x.ToList())
                    {
                        PropertyInfo[] props = type.GetProperties();
                        props.Where(y => y.Name == item.Key).First().SetValue(obj, item.Value);
                    }

                    return obj;
                }).ToList();
            }

            if(retornarRegistro && lista != null)
            {
                if(lista.Count == 1)
                {
                    _Resultado = lista[0];
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }

            dgvResultados.DataSource = null;
            dgvResultados.DataSource = lista;
        }
    }
}
