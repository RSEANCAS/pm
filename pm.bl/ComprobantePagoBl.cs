using pm.be;
using pm.da;
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
    public class ComprobantePagoBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ComprobantePagoDa comprobantePagoDa = new ComprobantePagoDa();
        ComprobantePagoDetalleDa comprobantePagoDetalleDa = new ComprobantePagoDetalleDa();
        BoletaVentaDa boletaVentaDa = new BoletaVentaDa();
        FacturaVentaDa facturaVentaDa = new FacturaVentaDa();
        LetraDa letraDa = new LetraDa();

        public List<ComprobantePagoBe> BuscarComprobantePago(DateTime? fechaPagoDesde, DateTime? fechaPagoHasta, int? codigoSerie, string nroComprobante, string nroDocIdentidadCliente, string nombresCliente, bool flagAnulado)
        {
            List<ComprobantePagoBe> resultados = null;

            try
            {
                cn.Open();
                resultados = comprobantePagoDa.BuscarComprobantePago(fechaPagoDesde, fechaPagoHasta, codigoSerie, nroComprobante, nroDocIdentidadCliente, nombresCliente, flagAnulado, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public ComprobantePagoBe ObtenerComprobantePago(int codigoComprobantePago, bool withDetalle = false, bool withProductoIndividual = false)
        {
            ComprobantePagoBe item = null;

            try
            {
                cn.Open();
                item = comprobantePagoDa.ObtenerComprobantePago(codigoComprobantePago, cn);
                if (withDetalle) item.ListaComprobantePagoDetalle = comprobantePagoDetalleDa.ListarComprobantePagoDetalle(codigoComprobantePago, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool CambiarFlagAnuladoComprobantePago(ComprobantePagoBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = comprobantePagoDa.CambiarFlagAnuladoComprobantePago(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool GuardarComprobantePago(ComprobantePagoBe registro)
        {
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    int codigoComprobantePago = 0, nroComprobante = 0;
                    seGuardo = comprobantePagoDa.GuardarComprobantePago(registro, cn, out codigoComprobantePago, out nroComprobante);
                    if (registro.ListaComprobantePagoDetalle != null && seGuardo)
                    {
                        foreach (ComprobantePagoDetalleBe item in registro.ListaComprobantePagoDetalle)
                        {
                            if (item.CodigoComprobantePago == 0) item.CodigoComprobantePago = codigoComprobantePago;
                            if (!seGuardo) break;
                            seGuardo = comprobantePagoDetalleDa.GuardarComprobantePagoDetalle(item, cn);
                            if (!seGuardo) break;
                            TipoDocumentoPago tipoDocumentoPago = (TipoDocumentoPago)item.CodigoTipoDocumentoPago;
                            switch (tipoDocumentoPago)
                            {
                                case TipoDocumentoPago.Factura:
                                    FacturaVentaBe documentoPagoFactura = new FacturaVentaBe
                                    {
                                        CodigoFacturaVenta = item.CodigoDocumentoPago,
                                        FlagCancelado = true,
                                        UsuarioModi = item.UsuarioModi
                                    };
                                    seGuardo = facturaVentaDa.CambiarFlagCanceladoFacturaVenta(documentoPagoFactura, cn);
                                    break;
                                case TipoDocumentoPago.Boleta:
                                    BoletaVentaBe documentoPagoBoleta = new BoletaVentaBe
                                    {
                                        CodigoBoletaVenta = item.CodigoDocumentoPago,
                                        FlagCancelado = true,
                                        UsuarioModi = item.UsuarioModi
                                    };
                                    seGuardo = boletaVentaDa.CambiarFlagCanceladoBoletaVenta(documentoPagoBoleta, cn);
                                    break;
                                case TipoDocumentoPago.Letra:
                                    LetraBe letra = letraDa.ObtenerLetra(item.CodigoDocumentoPago, cn);
                                    bool porRenovar = item.ImportePagar < letra.Total;

                                    if (!porRenovar)
                                    {
                                        int codigoLetraInicial = letra.CodigoLetraInicial.HasValue ? letra.CodigoLetraInicial.Value : letra.CodigoLetra;
                                        var listaLetrasPorCancelar = letraDa.ListarLetraPorCodigoLetraInicial(codigoLetraInicial, cn);

                                        if(listaLetrasPorCancelar != null)
                                        {
                                            foreach (var letraPorCancelar in listaLetrasPorCancelar)
                                            {
                                                LetraBe documentoPagoLetra = new LetraBe
                                                {
                                                    CodigoLetra = letraPorCancelar.CodigoLetra,
                                                    FlagCancelado = true,
                                                    UsuarioModi = letraPorCancelar.UsuarioModi
                                                };
                                                seGuardo = letraDa.CambiarFlagCanceladoLetra(documentoPagoLetra, cn);
                                                if (!seGuardo) break;
                                            }
                                        }
                                    }
                                    
                                    if(seGuardo && porRenovar)
                                    {
                                        letra.Estado = (int)EstadoLetra.Renovada;
                                        letra.UsuarioModi = registro.UsuarioModi;
                                        seGuardo = letraDa.CambiarEstadoLetra(letra, cn);

                                        if (!seGuardo) break;

                                        LetraBe nuevaLetra = new LetraBe
                                        {
                                            FechaHoraEmision = letra.FechaHoraEmision,
                                            FechaVencimiento = letra.FechaVencimiento.AddMonths(1),
                                            Dias = (letra.FechaVencimiento.AddMonths(1) - letra.FechaVencimiento).Days,
                                            CodigoTipoComprobanteRef = letra.CodigoTipoComprobanteRef,
                                            CodigoComprobanteRef = letra.CodigoComprobanteRef,
                                            CodigoSerieComprobanteRef = letra.CodigoSerieComprobanteRef,
                                            NroComprobanteComprobanteRef = letra.NroComprobanteComprobanteRef,
                                            CodigoGuiaRemision = letra.CodigoGuiaRemision,
                                            CodigoSerieGuiaRemision = letra.CodigoSerieGuiaRemision,
                                            NroComprobanteGuiaRemision = letra.NroComprobanteGuiaRemision,
                                            CodigoCliente = letra.CodigoCliente,
                                            CodigoBanco = letra.CodigoBanco,
                                            CodigoUnicoBanco = letra.CodigoUnicoBanco,
                                            CodigoMoneda = letra.CodigoMoneda,
                                            Monto = letra.Monto - item.MontoPagar,
                                            Mora = letra.Mora - item.MoraPagar,
                                            Protesto = letra.Protesto - item.ProtestoPagar,
                                            Estado = (int)EstadoLetra.Pendiente,
                                            CodigoLetraPadre = letra.CodigoLetra,
                                            CodigoLetraInicial = letra.CodigoLetraInicial.HasValue ? letra.CodigoLetraInicial.Value : letra.CodigoLetra,
                                            FlagAval = letra.FlagAval,
                                            CodigoAval = letra.CodigoAval,
                                            DireccionAval = letra.DireccionAval,
                                            NombrePaisAval = letra.NombrePaisAval,
                                            NombreDepartamentoAval = letra.NombreDepartamentoAval,
                                            NombreProvinciaAval = letra.NombreProvinciaAval,
                                            CodigoDistritoAval = letra.CodigoDistritoAval,
                                            NombreDistritoAval = letra.NombreDistritoAval,
                                            FlagCancelado = letra.FlagCancelado,
                                            FlagActivo = letra.FlagActivo,
                                            FlagEliminado = letra.FlagEliminado
                                        };

                                        int nuevoCodigoLetra = 0, nuevoNumeroLetra = 0;
                                        seGuardo = letraDa.GuardarLetra(nuevaLetra, cn, out nuevoCodigoLetra, out nuevoNumeroLetra);
                                        if (!seGuardo) break;
                                    }
                                    break;
                            }
                            if (!seGuardo) break;
                        }
                    }

                    if (registro.ListaComprobantePagoDetalleEliminar != null && seGuardo)
                    {
                        foreach (int codigoComprobantePagoDetalle in registro.ListaComprobantePagoDetalleEliminar)
                        {
                            seGuardo = comprobantePagoDetalleDa.EliminarComprobantePagoDetalle(codigoComprobantePagoDetalle, registro.UsuarioModi, cn);
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
