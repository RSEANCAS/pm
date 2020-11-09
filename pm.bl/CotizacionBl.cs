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
    public class CotizacionBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        CotizacionDa cotizacionDa = new CotizacionDa();
        CotizacionDetalleDa cotizacionDetalleDa = new CotizacionDetalleDa();

        public List<CotizacionBe> BuscarCotizacion(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, string numero, string nroDocIdentidadCliente, string nombresCliente, bool flagActivo)
        {
            List<CotizacionBe> resultados = null;

            try
            {
                cn.Open();
                resultados = cotizacionDa.BuscarCotizacion(fechaEmisionDesde, fechaEmisionHasta, numero, nroDocIdentidadCliente, nombresCliente, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public CotizacionBe ObtenerCotizacion(int codigoCotizacion, bool withDetalle = false)
        {
            CotizacionBe item = null;

            try
            {
                cn.Open();
                item = cotizacionDa.ObtenerCotizacion(codigoCotizacion, cn);
                if (withDetalle) item.ListaCotizacionDetalle = cotizacionDetalleDa.ListarCotizacionDetalle(codigoCotizacion, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool GuardarCotizacion(CotizacionBe registro)
        {
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    int codigoCotizacion = 0, nroComprobante = 0;
                    seGuardo = cotizacionDa.GuardarCotizacion(registro, cn, out codigoCotizacion, out nroComprobante);
                    if (registro.ListaCotizacionDetalle != null && seGuardo)
                    {
                        foreach (CotizacionDetalleBe item in registro.ListaCotizacionDetalle)
                        {
                            if (item.CodigoCotizacion == 0) item.CodigoCotizacion = codigoCotizacion;
                            seGuardo = cotizacionDetalleDa.GuardarCotizacionDetalle(item, cn);
                            if (!seGuardo) break;
                        }
                    }

                    if (registro.ListaCotizacionDetalleEliminar != null && seGuardo)
                    {
                        foreach (int codigoCotizacionDetalle in registro.ListaCotizacionDetalleEliminar)
                        {
                            seGuardo = cotizacionDetalleDa.EliminarCotizacionDetalle(codigoCotizacionDetalle, registro.UsuarioModi, cn);
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
