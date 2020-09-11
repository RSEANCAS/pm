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
    public class FacturaVentaBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        FacturaVentaDa facturaVentaDa = new FacturaVentaDa();
        FacturaVentaDetalleDa facturaVentaDetalleDa = new FacturaVentaDetalleDa();

        public List<FacturaVentaBe> BuscarFacturaVenta(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, int? codigoSerie, string numero, string nroDocIdentidadCliente, string nombresCliente, bool flagActivo)
        {
            List<FacturaVentaBe> resultados = null;

            try
            {
                cn.Open();
                resultados = facturaVentaDa.BuscarFacturaVenta(fechaEmisionDesde, fechaEmisionHasta, codigoSerie, numero, nroDocIdentidadCliente, nombresCliente, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public FacturaVentaBe ObtenerFacturaVenta(int codigoFacturaVenta, bool withDetalle = false)
        {
            FacturaVentaBe item = null;

            try
            {
                cn.Open();
                item = facturaVentaDa.ObtenerFacturaVenta(codigoFacturaVenta, cn);
                if (withDetalle)
                {
                    item.ListaFacturaVentaDetalle = facturaVentaDetalleDa.ListarFacturaVentaDetalle(codigoFacturaVenta, cn);
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool GuardarFacturaVenta(FacturaVentaBe registro)
        {
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    int codigoFacturaVenta = 0, nroComprobante = 0;
                    seGuardo = facturaVentaDa.GuardarFacturaVenta(registro, cn, out codigoFacturaVenta, out nroComprobante);
                    if (registro.ListaFacturaVentaDetalle != null && seGuardo)
                    {
                        foreach (FacturaVentaDetalleBe item in registro.ListaFacturaVentaDetalle)
                        {
                            if (item.CodigoFacturaVenta == 0) item.CodigoFacturaVenta = codigoFacturaVenta;
                            seGuardo = facturaVentaDetalleDa.GuardarFacturaVentaDetalle(item, cn);
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
