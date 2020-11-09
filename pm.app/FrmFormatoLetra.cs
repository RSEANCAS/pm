using Microsoft.Reporting.WinForms;
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
    public partial class FrmFormatoLetra : RadForm
    {
        int[] codigosLetra;

        FormatoBl formatoBl = new FormatoBl();

        public FrmFormatoLetra(int[] codigosLetra)
        {
            InitializeComponent();
            this.codigosLetra = codigosLetra;
        }

        private void FrmFormatoLetra_Load(object sender, EventArgs e)
        {
            var data = formatoBl.ListarFormatoLetra(codigosLetra);

            ReportDataSource rds = new ReportDataSource("dsReporte", data);

            rpvReporte.LocalReport.DataSources.Clear();
            rpvReporte.LocalReport.DataSources.Add(rds);
            this.rpvReporte.RefreshReport();
        }
    }
}
