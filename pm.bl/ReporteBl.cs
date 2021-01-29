using pm.be;
using pm.da;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.bl
{
    public class ReporteBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ReporteDa reporteDa = new ReporteDa();

        public List<ReporteBe.Comision> ReporteComision(DateTime fechaDesde, DateTime fechaHasta, string nroDocumentoIdentidadPersonal, string nombresPersonal)
        {
            List<ReporteBe.Comision> resultados = null;

            try
            {
                cn.Open();
                resultados = reporteDa.ReporteComision(fechaDesde, fechaHasta, nroDocumentoIdentidadPersonal, nombresPersonal, cn);
            }
            catch (Exception ex) { log.Error(ex); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }
    }
}
