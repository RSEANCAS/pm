﻿using pm.be;
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
    public class FacturaVentaBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        FacturaVentaDa facturaVentaDa = new FacturaVentaDa();
        FacturaVentaDetalleDa facturaVentaDetalleDa = new FacturaVentaDetalleDa();
        SerieDa serieDa = new SerieDa();
        LetraDa letraDa = new LetraDa();
        ProductoIndividualDa productoIndividualDa = new ProductoIndividualDa();
        UnidadMedidaDa unidadMedidaDa = new UnidadMedidaDa();

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

        public FacturaVentaBe ObtenerFacturaVenta(int codigoFacturaVenta, bool withDetalle = false, bool withLetra = false, bool withSerie = false, bool withUnidadMedida = false)
        {
            FacturaVentaBe item = null;

            try
            {
                cn.Open();
                item = facturaVentaDa.ObtenerFacturaVenta(codigoFacturaVenta, cn);
                if (withSerie) item.Serie = serieDa.ObtenerSerie(item.CodigoSerie, cn);
                if (withDetalle) item.ListaFacturaVentaDetalle = facturaVentaDetalleDa.ListarFacturaVentaDetalle(codigoFacturaVenta, cn);
                if (withLetra) item.ListaLetra = letraDa.ListarLetraPorRef((int)TipoComprobante.Factura, item.CodigoSerie, item.NroComprobante, cn);
                if (withUnidadMedida)
                {
                    if (item.ListaFacturaVentaDetalle != null)
                    {
                        foreach(var detalle in item.ListaFacturaVentaDetalle)
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

        public bool GuardarFacturaVenta(FacturaVentaBe registro, out int nroComprobante, out string totalEnLetras)
        {
            nroComprobante = 0;
            totalEnLetras = null;
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    int codigoFacturaVenta = 0;
                    seGuardo = facturaVentaDa.GuardarFacturaVenta(registro, cn, out codigoFacturaVenta, out nroComprobante, out totalEnLetras);
                    if (registro.ListaFacturaVentaDetalle != null && seGuardo)
                    {
                        foreach (FacturaVentaDetalleBe item in registro.ListaFacturaVentaDetalle)
                        {
                            if (item.CodigoFacturaVenta == 0) item.CodigoFacturaVenta = codigoFacturaVenta;
                            seGuardo = facturaVentaDetalleDa.GuardarFacturaVentaDetalle(item, cn);
                            if (!seGuardo) break;
                            else seGuardo = productoIndividualDa.RegenerarProductoIndividual(item.CodigoProductoIndividual, item.Cantidad, registro.UsuarioModi, cn);
                        }
                    }

                    if (registro.ListaFacturaVentaDetalleEliminar != null && seGuardo)
                    {
                        foreach (int codigoFacturaVentaDetalle in registro.ListaFacturaVentaDetalleEliminar)
                        {
                            seGuardo = facturaVentaDetalleDa.EliminarFacturaVentaDetalle(codigoFacturaVentaDetalle, registro.UsuarioModi, cn);
                            if (!seGuardo) break;
                        }
                    }

                    if(registro.ListaLetra != null && seGuardo)
                    {
                        int codigoTipoComprobanteRef = (int)Enums.TipoComprobante.Factura;

                        if (registro.CodigoFacturaVenta != 0) seGuardo = letraDa.EliminarLetraPorRef(codigoTipoComprobanteRef, codigoFacturaVenta, registro.UsuarioModi, cn);

                        foreach (LetraBe item in registro.ListaLetra)
                        {
                            item.CodigoTipoComprobanteRef = codigoTipoComprobanteRef;
                            item.CodigoComprobanteRef = codigoFacturaVenta;
                            item.CodigoGuiaRemision = registro.CodigoGuiaRemision;
                            item.CodigoCliente = registro.CodigoCliente;
                            item.CodigoMoneda = registro.CodigoMoneda;


                            int codigoLetra = 0, numeroLetra = 0;

                            seGuardo = letraDa.GuardarLetra(item, cn, out codigoLetra, out numeroLetra);
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

        public bool GuardarEmisionFacturaVenta(FacturaVentaBe registro)
        {
            bool seGuardo = false;

            try
            {
                    cn.Open();
                    seGuardo = facturaVentaDa.GuardarEmisionFacturaVenta(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
