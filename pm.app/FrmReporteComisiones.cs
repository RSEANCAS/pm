using Microsoft.Reporting.WinForms;
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
using Telerik.WinControls.UI;

namespace pm.app
{
    public partial class FrmReporteComisiones : RadForm
    {
        ReporteBl reporteBl = new ReporteBl();

        public FrmReporteComisiones()
        {
            InitializeComponent();
        }

        private void FrmReporteComisiones_Load(object sender, EventArgs e)
        {
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpFiltroFechaDesde.Value;
            DateTime fechaHasta = dtpFiltroFechaHasta.Value;
            string nroDocumentoIdentidadPersonal = txtFiltroNroDocIdentidadPersonal.Text.Trim();
            string nombresPersonal = txtFiltroNombresPersonal.Text.Trim();

            var dsReporteData = reporteBl.ReporteComision(fechaDesde, fechaHasta, nroDocumentoIdentidadPersonal, nombresPersonal);

            rpvReporte.LocalReport.SetParameters(new ReportParameter[] {
                new ReportParameter("FechaDesde", fechaDesde.ToString("dd/MM/yyyy")),
                new ReportParameter("FechaHasta", fechaHasta.ToString("dd/MM/yyyy"))
            });
            rpvReporte.LocalReport.DataSources.Clear();
            rpvReporte.LocalReport.DataSources.Add(new ReportDataSource("dsReporteData", dsReporteData ?? new List<ReporteBe.Comision>()));
            rpvReporte.RefreshReport();
        }
    }
}
