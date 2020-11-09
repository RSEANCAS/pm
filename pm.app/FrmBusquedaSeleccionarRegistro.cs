using pm.be;
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
        string table, columns, columnsFilter, where;
        Type type;
        ControlBusquedaBe controlBusqueda = null;

        CommonBl commonBl = new CommonBl();

        //public FrmBusquedaSeleccionarRegistro(string title, string table, DataGridViewColumn[] columns, string[] columnsFilter, string where, Type type, string filtroBusqueda = "")
        //{
        //    InitializeComponent();
        //    Text = title;
        //    this.table = table;
        //    this.columns = string.Join($",{Environment.NewLine}", columns.Select(x => $"{x.Tag.ToString()} [{x.DataPropertyName}]").ToArray());
        //    this.columnsFilter = string.Join($" or{Environment.NewLine}", columnsFilter.Select(x => $"{x} like '%{{0}}%'").ToArray());
        //    this.where = where;
        //    txtFiltroBusqueda.Text = (filtroBusqueda ?? "").Trim();
        //    this.type = type;
        //    dgvResultados.AutoGenerateColumns = false;
        //    dgvResultados.Columns.AddRange(columns);
        //}

        public FrmBusquedaSeleccionarRegistro(ControlBusquedaBe item, string filtroBusqueda = "")
        {
            InitializeComponent();

            Assembly asm = typeof(BaseAuditoria).Assembly;
            DataGridViewColumn[] columns = item.ListaControlBusquedaColumna.Select(x =>
            {
                Assembly asmForms = typeof(DataGridViewColumn).Assembly;
                Type t = asmForms.GetType(x.TipoColumna);
                dynamic typeColumn = Activator.CreateInstance(t);

                DataGridViewColumn column = typeColumn;
                column.Width = x.Ancho;
                column.Name = $"dgvResultados_{x.NombreAtributo}";
                column.DataPropertyName = x.NombreAtributo;
                column.HeaderText = x.Titulo;
                column.Visible = x.EsVisible;
                column.Tag = x.CampoBD;
                if (x.Formato != null) column.DefaultCellStyle.Format = x.Formato;
                return column;
            }).ToArray();
            string[] columnsFilter = item.ListaControlBusquedaColumna.Where(x => x.EsFiltro).Select(x => (string)x.NombreAtributo).ToArray();

            Text = item.TituloFormulario;
            this.table = item.FromTables;
            this.columns = string.Join($",{Environment.NewLine}", columns.Select(x => $"{x.Tag.ToString()} [{x.DataPropertyName}]").ToArray());
            this.columnsFilter = string.Join($" or{Environment.NewLine}", columnsFilter.Select(x => $"{x} like '%{{0}}%'").ToArray());
            this.where = item.WhereMain;
            txtFiltroBusqueda.Text = (filtroBusqueda ?? "").Trim();
            this.type = asm.GetType(item.TipoObjeto);
            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.Columns.AddRange(columns.Cast<DataGridViewColumn>().ToArray());
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

            string whereColumnsFilter = string.Format(columnsFilter, busqueda);

            List<dynamic> lista = commonBl.BuscarQuery(table, columns, whereColumnsFilter, where);

            if (lista != null)
            {
                lista = lista.Cast<ExpandoObject>().Select(x =>
                {
                    var obj = Activator.CreateInstance(type);

                    foreach(var item in x.ToList())
                    {
                        PropertyInfo[] props = type.GetProperties();
                        props.Where(y => y.Name == item.Key).First().SetValue(obj, DBNull.Value.Equals(item.Value) ? null : item.Value);
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
