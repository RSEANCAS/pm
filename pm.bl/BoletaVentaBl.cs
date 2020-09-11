using pm.be;
using pm.da;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace pm.bl
{
    public class BoletaVentaBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        BoletaVentaDa boletaVentaDa = new BoletaVentaDa();
        BoletaVentaDetalleDa boletaVentaDetalleDa = new BoletaVentaDetalleDa();

        public List<BoletaVentaBe> BuscarBoletaVenta(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, int? codigoSerie, string numero, string nroDocIdentidadCliente, string nombresCliente, bool flagActivo)
        {
            List<BoletaVentaBe> resultados = null;

            try
            {
                cn.Open();
                resultados = boletaVentaDa.BuscarBoletaVenta(fechaEmisionDesde, fechaEmisionHasta, codigoSerie, numero, nroDocIdentidadCliente, nombresCliente, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public BoletaVentaBe ObtenerBoletaVenta(int codigoBoletaVenta, bool withDetalle = false)
        {
            BoletaVentaBe item = null;

            try
            {
                cn.Open();
                item = boletaVentaDa.ObtenerBoletaVenta(codigoBoletaVenta, cn);
                if (withDetalle)
                {
                    item.ListaBoletaVentaDetalle = boletaVentaDetalleDa.ListarBoletaVentaDetalle(codigoBoletaVenta, cn);
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool GuardarBoletaVenta(BoletaVentaBe registro)
        {
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    int codigoBoletaVenta = 0, nroComprobante = 0;
                    seGuardo = boletaVentaDa.GuardarBoletaVenta(registro, cn, out codigoBoletaVenta, out nroComprobante);
                    if (registro.ListaBoletaVentaDetalle != null && seGuardo)
                    {
                        foreach (BoletaVentaDetalleBe item in registro.ListaBoletaVentaDetalle)
                        {
                            if (item.CodigoBoletaVenta == 0) item.CodigoBoletaVenta = codigoBoletaVenta;
                            seGuardo = boletaVentaDetalleDa.GuardarBoletaVentaDetalle(item, cn);
                            if (!seGuardo) break;
                        }
                    }
                    if (seGuardo) scope.Complete();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
