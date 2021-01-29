using pm.be;
using pm.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.da
{
    public class ReporteDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ReporteBe.Comision> ReporteComision(DateTime fechaDesde, DateTime fechaHasta, string nroDocumentoIdentidadPersonal, string nombresPersonal, SqlConnection cn)
        {
            List<ReporteBe.Comision> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_reporte_comision", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidadPersonal", nroDocumentoIdentidadPersonal.GetNullable());
                    cmd.Parameters.AddWithValue("@nombresPersonal", nombresPersonal.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<ReporteBe.Comision>();

                            while (dr.Read())
                            {
                                ReporteBe.Comision item = new ReporteBe.Comision();
                                item.NombrePersonal = dr.GetData<string>("NombrePersonal");
                                item.TipoPersonal = dr.GetData<string>("TipoPersonal");
                                item.PorcentajeComision = dr.GetData<decimal>("PorcentajeComision");
                                item.CantidadVentas = dr.GetData<int>("CantidadVentas");
                                item.TotalVentasSinIgv = dr.GetData<decimal>("TotalVentasSinIgv");
                                item.TotalVentasConIgv = dr.GetData<decimal>("TotalVentasConIgv");
                                item.TotalComision = dr.GetData<decimal>("TotalComision");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }
    }
}
