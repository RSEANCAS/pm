
using pm.be;
using pm.da;
using pm.enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static pm.enums.Enums;

namespace pm.bl
{
    public class GuiaRemisionBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        GuiaRemisionDa guiaRemisionDa = new GuiaRemisionDa();
        GuiaRemisionDetalleDa guiaRemisionDetalleDa = new GuiaRemisionDetalleDa();
        LetraDa letraDa = new LetraDa();

        public List<GuiaRemisionBe> BuscarGuiaRemision(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, int? codigoSerie, string numero, string nroDocIdentidadCliente, string nombresCliente, bool flagActivo)
        {
            List<GuiaRemisionBe> resultados = null;

            try
            {
                cn.Open();
                resultados = guiaRemisionDa.BuscarGuiaRemision(fechaEmisionDesde, fechaEmisionHasta, codigoSerie, numero, nroDocIdentidadCliente, nombresCliente, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public GuiaRemisionBe ObtenerGuiaRemision(int codigoGuiaRemision, bool withDetalle = false)
        {
            GuiaRemisionBe item = null;

            try
            {
                cn.Open();
                item = guiaRemisionDa.ObtenerGuiaRemision(codigoGuiaRemision, cn);
                if (withDetalle) item.ListaGuiaRemisionDetalle = guiaRemisionDetalleDa.ListarGuiaRemisionDetalle(codigoGuiaRemision, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool GuardarGuiaRemision(GuiaRemisionBe registro)
        {
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    int codigoGuiaRemision = 0, nroComprobante = 0;
                    seGuardo = guiaRemisionDa.GuardarGuiaRemision(registro, cn, out codigoGuiaRemision, out nroComprobante);
                    if (registro.ListaGuiaRemisionDetalle != null && seGuardo)
                    {
                        foreach (GuiaRemisionDetalleBe item in registro.ListaGuiaRemisionDetalle)
                        {
                            if (item.CodigoGuiaRemision == 0) item.CodigoGuiaRemision = codigoGuiaRemision;
                            seGuardo = guiaRemisionDetalleDa.GuardarGuiaRemisionDetalle(item, cn);
                            if (!seGuardo) break;
                        }
                    }

                    if (registro.ListaGuiaRemisionDetalleEliminar != null && seGuardo)
                    {
                        foreach (int codigoGuiaRemisionDetalle in registro.ListaGuiaRemisionDetalleEliminar)
                        {
                            seGuardo = guiaRemisionDetalleDa.EliminarGuiaRemisionDetalle(codigoGuiaRemisionDetalle, registro.UsuarioModi, cn);
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
