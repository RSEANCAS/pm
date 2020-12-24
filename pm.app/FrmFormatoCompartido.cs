using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pm.app
{
    public partial class FrmFormatoCompartido : Form
    {
        ReportDataSource[] reportDataSources;
        string formatoRdlc;

        public FrmFormatoCompartido(ReportDataSource[] reportDataSources, string formatoRdlc)
        {
            InitializeComponent();
            this.reportDataSources = reportDataSources;
            this.formatoRdlc = formatoRdlc;
        }

        private void FrmFormatoCompartido_Load(object sender, EventArgs e)
        {
            rpvReporte.LocalReport.ReportEmbeddedResource = $"pm.app.App_Data.rdlc.{formatoRdlc}.rdlc";
            rpvReporte.LocalReport.DataSources.Clear();
            if (reportDataSources != null) foreach (var item in reportDataSources) rpvReporte.LocalReport.DataSources.Add(item);
            
            this.rpvReporte.RefreshReport();
        }
    }
}
