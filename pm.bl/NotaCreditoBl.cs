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
    public class NotaCreditoBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        NotaCreditoDa notaCreditoDa = new NotaCreditoDa();
        NotaCreditoDetalleDa notaCreditoDetalleDa = new NotaCreditoDetalleDa();
        ProductoIndividualDa productoIndividualDa = new ProductoIndividualDa();
        UnidadMedidaDa unidadMedidaDa = new UnidadMedidaDa();

        public List<NotaCreditoBe> BuscarNotaCredito(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, int? codigoSerie, string numero, string nroDocIdentidadCliente, string nombresCliente, bool flagActivo)
        {
            List<NotaCreditoBe> resultados = null;

            try
            {
                cn.Open();
                resultados = notaCreditoDa.BuscarNotaCredito(fechaEmisionDesde, fechaEmisionHasta, codigoSerie, numero, nroDocIdentidadCliente, nombresCliente, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public NotaCreditoBe ObtenerNotaCredito(int codigoNotaCredito, bool withDetalle = false, bool withUnidadMedida = false)
        {
            NotaCreditoBe item = null;

            try
            {
                cn.Open();
                item = notaCreditoDa.ObtenerNotaCredito(codigoNotaCredito, cn);
                if (withDetalle)
                {
                    item.ListaNotaCreditoDetalle = notaCreditoDetalleDa.ListarNotaCreditoDetalle(codigoNotaCredito, cn);
                }

                if (withUnidadMedida)
                {
                    if (item.ListaNotaCreditoDetalle != null)
                    {
                        foreach (var detalle in item.ListaNotaCreditoDetalle)
                        {
                            if (withUnidadMedida) detalle.UnidadMedida = unidadMedidaDa.ObtenerUnidadMedida(detalle.CodigoUnidadMedida, cn);

                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool GuardarNotaCredito(NotaCreditoBe registro, out int nroComprobante, out string totalEnLetras)
        {
            nroComprobante = 0;
            totalEnLetras = null;
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    int codigoNotaCredito = 0;
                    seGuardo = notaCreditoDa.GuardarNotaCredito(registro, cn, out codigoNotaCredito, out nroComprobante, out totalEnLetras);
                    if (registro.ListaNotaCreditoDetalle != null && seGuardo)
                    {
                        foreach (NotaCreditoDetalleBe item in registro.ListaNotaCreditoDetalle)
                        {
                            if (item.CodigoNotaCredito == 0) item.CodigoNotaCredito = codigoNotaCredito;
                            seGuardo = notaCreditoDetalleDa.GuardarNotaCreditoDetalle(item, cn);
                            if (!seGuardo) break;
                            else seGuardo = productoIndividualDa.RegenerarProductoIndividual(item.CodigoProductoIndividual, item.Cantidad, registro.UsuarioModi, cn);
                        }
                    }

                    if (registro.ListaNotaCreditoDetalleEliminar != null && seGuardo)
                    {
                        foreach (int codigoNotaCreditoDetalle in registro.ListaNotaCreditoDetalleEliminar)
                        {
                            seGuardo = notaCreditoDetalleDa.EliminarNotaCreditoDetalle(codigoNotaCreditoDetalle, registro.UsuarioModi, cn);
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

        public bool GuardarEmisionNotaCredito(NotaCreditoBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = notaCreditoDa.GuardarEmisionNotaCredito(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
