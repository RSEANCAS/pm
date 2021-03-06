﻿using pm.be;
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
    public class NotaDebitoBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        NotaDebitoDa notaDebitoDa = new NotaDebitoDa();
        NotaDebitoDetalleDa notaDebitoDetalleDa = new NotaDebitoDetalleDa();
        ProductoIndividualDa productoIndividualDa = new ProductoIndividualDa();
        UnidadMedidaDa unidadMedidaDa = new UnidadMedidaDa();

        public List<NotaDebitoBe> BuscarNotaDebito(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, int? codigoSerie, string numero, string nroDocIdentidadCliente, string nombresCliente, bool flagActivo)
        {
            List<NotaDebitoBe> resultados = null;

            try
            {
                cn.Open();
                resultados = notaDebitoDa.BuscarNotaDebito(fechaEmisionDesde, fechaEmisionHasta, codigoSerie, numero, nroDocIdentidadCliente, nombresCliente, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public NotaDebitoBe ObtenerNotaDebito(int codigoNotaDebito, bool withDetalle = false, bool withUnidadMedida = false)
        {
            NotaDebitoBe item = null;

            try
            {
                cn.Open();
                item = notaDebitoDa.ObtenerNotaDebito(codigoNotaDebito, cn);
                if (withDetalle)
                {
                    item.ListaNotaDebitoDetalle = notaDebitoDetalleDa.ListarNotaDebitoDetalle(codigoNotaDebito, cn);
                }
                if (withUnidadMedida)
                {
                    if (item.ListaNotaDebitoDetalle != null)
                    {
                        foreach (var detalle in item.ListaNotaDebitoDetalle)
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

        public bool GuardarNotaDebito(NotaDebitoBe registro, out int nroComprobante, out string totalEnLetras)
        {
            nroComprobante = 0;
            totalEnLetras = null;
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    int codigoNotaDebito = 0;
                    seGuardo = notaDebitoDa.GuardarNotaDebito(registro, cn, out codigoNotaDebito, out nroComprobante, out totalEnLetras);
                    if (registro.ListaNotaDebitoDetalle != null && seGuardo)
                    {
                        foreach (NotaDebitoDetalleBe item in registro.ListaNotaDebitoDetalle)
                        {
                            if (item.CodigoNotaDebito == 0) item.CodigoNotaDebito = codigoNotaDebito;
                            seGuardo = notaDebitoDetalleDa.GuardarNotaDebitoDetalle(item, cn);
                            if (!seGuardo) break;
                            else seGuardo = productoIndividualDa.RegenerarProductoIndividual(item.CodigoProductoIndividual, item.Cantidad, registro.UsuarioModi, cn);
                        }
                    }

                    if (registro.ListaNotaDebitoDetalleEliminar != null && seGuardo)
                    {
                        foreach (int codigoNotaDebitoDetalle in registro.ListaNotaDebitoDetalleEliminar)
                        {
                            seGuardo = notaDebitoDetalleDa.EliminarNotaDebitoDetalle(codigoNotaDebitoDetalle, registro.UsuarioModi, cn);
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

        public bool GuardarEmisionNotaDebito(NotaDebitoBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = notaDebitoDa.GuardarEmisionNotaDebito(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
