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
    public class ComprobanteCompraBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ComprobanteCompraDa comprobanteCompraDa = new ComprobanteCompraDa();
        ComprobanteCompraDetalleDa comprobanteCompraDetalleDa = new ComprobanteCompraDetalleDa();
        ProductoIndividualDa productoIndividualDa = new ProductoIndividualDa();

        public List<ComprobanteCompraBe> BuscarComprobanteCompra(DateTime? fechaCompraDesde, DateTime? fechaCompraHasta, string serie, string numero, string nroDocIdentidadCliente, string nombresCliente, bool flagActivo)
        {
            List<ComprobanteCompraBe> resultados = null;

            try
            {
                cn.Open();
                resultados = comprobanteCompraDa.BuscarComprobanteCompra(fechaCompraDesde, fechaCompraHasta, serie, numero, nroDocIdentidadCliente, nombresCliente, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public ComprobanteCompraBe ObtenerComprobanteCompra(int codigoComprobanteCompra, bool withDetalle = false, bool withProductoIndividual = false)
        {
            ComprobanteCompraBe item = null;

            try
            {
                cn.Open();
                item = comprobanteCompraDa.ObtenerComprobanteCompra(codigoComprobanteCompra, cn);
                if (withDetalle) item.ListaComprobanteCompraDetalle = comprobanteCompraDetalleDa.ListarComprobanteCompraDetalle(codigoComprobanteCompra, cn);
                if (withProductoIndividual) item.ListaProductoIndividual = productoIndividualDa.ListarProductoIndividualPorComprobanteCompra(codigoComprobanteCompra, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool GuardarComprobanteCompra(ComprobanteCompraBe registro)
        {
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    int codigoComprobanteCompra = 0, nroComprobante = 0;
                    seGuardo = comprobanteCompraDa.GuardarComprobanteCompra(registro, cn, out codigoComprobanteCompra, out nroComprobante);
                    if (registro.ListaComprobanteCompraDetalle != null && seGuardo)
                    {
                        foreach (ComprobanteCompraDetalleBe item in registro.ListaComprobanteCompraDetalle)
                        {
                            if (item.CodigoComprobanteCompra == 0) item.CodigoComprobanteCompra = codigoComprobanteCompra;
                            if (!seGuardo) break;
                            seGuardo = comprobanteCompraDetalleDa.GuardarComprobanteCompraDetalle(item, cn);
                            if (!seGuardo) break;
                        }
                    }

                    if (registro.ListaComprobanteCompraDetalleEliminar != null && seGuardo)
                    {
                        foreach (int codigoComprobanteCompraDetalle in registro.ListaComprobanteCompraDetalleEliminar)
                        {
                            seGuardo = comprobanteCompraDetalleDa.EliminarComprobanteCompraDetalle(codigoComprobanteCompraDetalle, registro.UsuarioModi, cn);
                            if (!seGuardo) break;
                        }
                    }

                    if(registro.ListaProductoIndividual != null && seGuardo)
                    {
                        foreach(ProductoIndividualBe productoIndividual in registro.ListaProductoIndividual)
                        {
                            productoIndividual.CodigoComprobanteCompra = codigoComprobanteCompra;
                            int codigoProductoIndividual = 0;
                            seGuardo = productoIndividualDa.GuardarProductoIndividual(productoIndividual, out codigoProductoIndividual, cn);
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
