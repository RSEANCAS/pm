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
using Telerik.WinControls.UI;

namespace pm.app
{
    public partial class FrmFormatoCompartido : RadForm
    {
        ReportDataSource[] reportDataSources;
        string formatoRdlc;
        string nombreArchivo;

        public FrmFormatoCompartido(ReportDataSource[] reportDataSources, string formatoRdlc, string nombreArchivo = null)
        {
            InitializeComponent();
            this.reportDataSources = reportDataSources;
            this.formatoRdlc = formatoRdlc;
            this.nombreArchivo = nombreArchivo;
            this.Text = nombreArchivo;
        }

        private void FrmFormatoCompartido_Load(object sender, EventArgs e)
        {
            rpvReporte.LocalReport.ReportEmbeddedResource = $"pm.app.App_Data.rdlc.{formatoRdlc}.rdlc";
            rpvReporte.LocalReport.DataSources.Clear();
            if (reportDataSources != null) foreach (var item in reportDataSources) rpvReporte.LocalReport.DataSources.Add(item);
            if (!string.IsNullOrEmpty(this.nombreArchivo)) rpvReporte.LocalReport.DisplayName = nombreArchivo;

            this.rpvReporte.RefreshReport();
        }
    }
}
