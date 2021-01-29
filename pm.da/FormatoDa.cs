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
    public class FormatoDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<FormatoBe.Letra> ListarFormatoLetra(int[] codigosLetra, SqlConnection cn)
        {
            List<FormatoBe.Letra> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_formato_letra_masivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigosLetra", (codigosLetra == null ? null : string.Join(",", codigosLetra)).GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<FormatoBe.Letra>();

                            while (dr.Read())
                            {
                                FormatoBe.Letra item = new FormatoBe.Letra();
                                item.Numero = dr.GetData<int>("Numero");
                                item.FechaGiro = dr.GetData<DateTime>("FechaGiro");
                                item.LugarGiro = dr.GetData<string>("LugarGiro");
                                item.FechaVencimiento = dr.GetData<DateTime>("FechaVencimiento");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.Importe = dr.GetData<decimal>("Importe");
                                item.ImporteEnLetras = dr.GetData<string>("ImporteEnLetras");
                                item.RucCliente = dr.GetData<string>("RucCliente");
                                item.NombresCliente = dr.GetData<string>("NombresCliente");
                                item.DireccionCliente = dr.GetData<string>("DireccionCliente");
                                item.LocalidadCliente = dr.GetData<string>("LocalidadCliente");
                                item.TelefonoCliente = dr.GetData<string>("TelefonoCliente");
                                item.NroDocIdentidadAval = dr.GetData<string>("NroDocIdentidadAval");
                                item.NombresAval = dr.GetData<string>("NombresAval");
                                item.DireccionAval = dr.GetData<string>("DireccionAval");
                                item.LocalidadAval = dr.GetData<string>("LocalidadAval");
                                item.TelefonoAval = dr.GetData<string>("TelefonoAval");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public FormatoBe.Factura ObtenerFormatoFacturaVenta(int codigoFacturaVenta, SqlConnection cn)
        {
            FormatoBe.Factura item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_formato_facturaventa", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoFacturaVenta", codigoFacturaVenta.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new FormatoBe.Factura();

                            if (dr.Read())
                            {
                                item.Serie = dr.GetData<string>("Serie");
                                item.Correlativo = dr.GetData<int>("Correlativo");
                                item.CodigoTipoDocumentoIdentidadCliente = dr.GetData<int>("CodigoTipoDocumentoIdentidadCliente");
                                item.NombresCompletoCliente = dr.GetData<string>("NombresCompletoCliente");
                                item.NroDocumentoIdentidadCliente = dr.GetData<string>("NroDocumentoIdentidadCliente");
                                item.DireccionCliente = dr.GetData<string>("DireccionCliente");
                                item.CondicionPago = dr.GetData<string>("CondicionPago");
                                item.TelefonoCliente = dr.GetData<string>("TelefonoCliente");
                                item.AgenciaTransporte = dr.GetData<string>("AgenciaTransporte");
                                item.FechaEmision = dr.GetData<DateTime>("FechaEmision");
                                item.FechaVencimiento = dr.GetData<DateTime>("FechaVencimiento");
                                item.TipoCambio = dr.GetData<decimal>("TipoCambio");
                                item.NroPedido = dr.GetData<string>("NroPedido");
                                item.NroGuia = dr.GetData<string>("NroGuia");
                                item.OrdenCompra = dr.GetData<string>("OrdenCompra");
                                item.TotalGravada = dr.GetData<decimal>("TotalGravada");
                                item.TotalIGV = dr.GetData<decimal>("TotalIGV");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");
                                item.TotalPagar = dr.GetData<decimal>("TotalPagar");
                                item.TotalEnLetras = dr.GetData<string>("TotalEnLetras");
                                item.Hash = dr.GetData<string>("Hash");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public List<FormatoBe.FacturaDetalle> ListarFormatoFacturaVentaDetalle(int codigoFacturaVenta, SqlConnection cn)
        {
            List<FormatoBe.FacturaDetalle> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_formato_facturaventadetalle", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoFacturaVenta", codigoFacturaVenta.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<FormatoBe.FacturaDetalle>();

                            while (dr.Read())
                            {
                                FormatoBe.FacturaDetalle item = new FormatoBe.FacturaDetalle();
                                item.Codigo = dr.GetData<string>("Codigo");
                                item.Articulo = dr.GetData<string>("Articulo");
                                item.Cantidad = dr.GetData<decimal>("Cantidad");
                                item.Precio = dr.GetData<decimal>("Precio");
                                item.Importe = dr.GetData<decimal>("Importe");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public FormatoBe.Boleta ObtenerFormatoBoletaVenta(int codigoBoletaVenta, SqlConnection cn)
        {
            FormatoBe.Boleta item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_formato_boletaventa", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoBoletaVenta", codigoBoletaVenta.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new FormatoBe.Boleta();

                            if (dr.Read())
                            {
                                item.Serie = dr.GetData<string>("Serie");
                                item.Correlativo = dr.GetData<int>("Correlativo");
                                item.CodigoTipoDocumentoIdentidadCliente = dr.GetData<int>("CodigoTipoDocumentoIdentidadCliente");
                                item.NombresCompletoCliente = dr.GetData<string>("NombresCompletoCliente");
                                item.NroDocumentoIdentidadCliente = dr.GetData<string>("NroDocumentoIdentidadCliente");
                                item.DireccionCliente = dr.GetData<string>("DireccionCliente");
                                item.CondicionPago = dr.GetData<string>("CondicionPago");
                                item.TelefonoCliente = dr.GetData<string>("TelefonoCliente");
                                item.AgenciaTransporte = dr.GetData<string>("AgenciaTransporte");
                                item.FechaEmision = dr.GetData<DateTime>("FechaEmision");
                                item.FechaVencimiento = dr.GetData<DateTime>("FechaVencimiento");
                                item.TipoCambio = dr.GetData<decimal>("TipoCambio");
                                item.NroPedido = dr.GetData<string>("NroPedido");
                                item.NroGuia = dr.GetData<string>("NroGuia");
                                item.OrdenCompra = dr.GetData<string>("OrdenCompra");
                                item.TotalGravada = dr.GetData<decimal>("TotalGravada");
                                item.TotalIGV = dr.GetData<decimal>("TotalIGV");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");
                                item.TotalPagar = dr.GetData<decimal>("TotalPagar");
                                item.TotalEnLetras = dr.GetData<string>("TotalEnLetras");
                                item.Hash = dr.GetData<string>("Hash");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public List<FormatoBe.BoletaDetalle> ListarFormatoBoletaVentaDetalle(int codigoBoletaVenta, SqlConnection cn)
        {
            List<FormatoBe.BoletaDetalle> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_formato_boletaventadetalle", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoBoletaVenta", codigoBoletaVenta.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<FormatoBe.BoletaDetalle>();

                            while (dr.Read())
                            {
                                FormatoBe.BoletaDetalle item = new FormatoBe.BoletaDetalle();
                                item.Codigo = dr.GetData<string>("Codigo");
                                item.Articulo = dr.GetData<string>("Articulo");
                                item.Cantidad = dr.GetData<decimal>("Cantidad");
                                item.Precio = dr.GetData<decimal>("Precio");
                                item.Importe = dr.GetData<decimal>("Importe");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public FormatoBe.NotaCredito ObtenerFormatoNotaCredito(int codigoNotaCredito, SqlConnection cn)
        {
            FormatoBe.NotaCredito item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_formato_notacredito", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoNotaCredito", codigoNotaCredito.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new FormatoBe.NotaCredito();

                            if (dr.Read())
                            {
                                item.Serie = dr.GetData<string>("Serie");
                                item.Correlativo = dr.GetData<int>("Correlativo");
                                item.FechaEmision = dr.GetData<DateTime>("FechaEmision");
                                item.CodigoTipoDocumentoIdentidadCliente = dr.GetData<int>("CodigoTipoDocumentoIdentidadCliente");
                                item.NombresCompletoCliente = dr.GetData<string>("NombresCompletoCliente");
                                item.NroDocumentoIdentidadCliente = dr.GetData<string>("NroDocumentoIdentidadCliente");
                                item.DireccionCliente = dr.GetData<string>("DireccionCliente");
                                item.TipoComprobanteRef = dr.GetData<string>("TipoComprobanteRef");
                                item.SerieRef = dr.GetData<string>("SerieRef");
                                item.CorrelativoRef = dr.GetData<int>("CorrelativoRef");
                                item.FechaEmisionRef = dr.GetData<DateTime>("FechaEmisionRef");
                                item.NombreMoneda = dr.GetData<string>("NombreMoneda");
                                item.SimboloMoneda = dr.GetData<string>("SimboloMoneda");
                                item.Motivo = dr.GetData<string>("Motivo");
                                item.TotalGravada = dr.GetData<decimal>("TotalGravada");
                                item.TotalIGV = dr.GetData<decimal>("TotalIGV");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");
                                item.TotalPagar = dr.GetData<decimal>("TotalPagar");
                                item.TotalEnLetras = dr.GetData<string>("TotalEnLetras");
                                item.Hash = dr.GetData<string>("Hash");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public List<FormatoBe.NotaCreditoDetalle> ListarFormatoNotaCreditoDetalle(int codigoNotaCredito, SqlConnection cn)
        {
            List<FormatoBe.NotaCreditoDetalle> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_formato_notacreditodetalle", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoNotaCredito", codigoNotaCredito.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<FormatoBe.NotaCreditoDetalle>();

                            while (dr.Read())
                            {
                                FormatoBe.NotaCreditoDetalle item = new FormatoBe.NotaCreditoDetalle();
                                item.Codigo = dr.GetData<string>("Codigo");
                                item.Articulo = dr.GetData<string>("Articulo");
                                item.Cantidad = dr.GetData<decimal>("Cantidad");
                                item.Precio = dr.GetData<decimal>("Precio");
                                item.Importe = dr.GetData<decimal>("Importe");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public FormatoBe.NotaDebito ObtenerFormatoNotaDebito(int codigoNotaDebito, SqlConnection cn)
        {
            FormatoBe.NotaDebito item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_formato_notadebito", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoNotaDebito", codigoNotaDebito.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new FormatoBe.NotaDebito();

                            if (dr.Read())
                            {
                                item.Serie = dr.GetData<string>("Serie");
                                item.Correlativo = dr.GetData<int>("Correlativo");
                                item.FechaEmision = dr.GetData<DateTime>("FechaEmision");
                                item.CodigoTipoDocumentoIdentidadCliente = dr.GetData<int>("CodigoTipoDocumentoIdentidadCliente");
                                item.NombresCompletoCliente = dr.GetData<string>("NombresCompletoCliente");
                                item.NroDocumentoIdentidadCliente = dr.GetData<string>("NroDocumentoIdentidadCliente");
                                item.DireccionCliente = dr.GetData<string>("DireccionCliente");
                                item.TipoComprobanteRef = dr.GetData<string>("TipoComprobanteRef");
                                item.SerieRef = dr.GetData<string>("SerieRef");
                                item.CorrelativoRef = dr.GetData<int>("CorrelativoRef");
                                item.FechaEmisionRef = dr.GetData<DateTime>("FechaEmisionRef");
                                item.NombreMoneda = dr.GetData<string>("NombreMoneda");
                                item.SimboloMoneda = dr.GetData<string>("SimboloMoneda");
                                item.Motivo = dr.GetData<string>("Motivo");
                                item.TotalGravada = dr.GetData<decimal>("TotalGravada");
                                item.TotalIGV = dr.GetData<decimal>("TotalIGV");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");
                                item.TotalPagar = dr.GetData<decimal>("TotalPagar");
                                item.TotalEnLetras = dr.GetData<string>("TotalEnLetras");
                                item.Hash = dr.GetData<string>("Hash");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public List<FormatoBe.NotaDebitoDetalle> ListarFormatoNotaDebitoDetalle(int codigoNotaDebito, SqlConnection cn)
        {
            List<FormatoBe.NotaDebitoDetalle> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_formato_notadebitodetalle", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoNotaDebito", codigoNotaDebito.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<FormatoBe.NotaDebitoDetalle>();

                            while (dr.Read())
                            {
                                FormatoBe.NotaDebitoDetalle item = new FormatoBe.NotaDebitoDetalle();
                                item.Codigo = dr.GetData<string>("Codigo");
                                item.Articulo = dr.GetData<string>("Articulo");
                                item.Cantidad = dr.GetData<decimal>("Cantidad");
                                item.Precio = dr.GetData<decimal>("Precio");
                                item.Importe = dr.GetData<decimal>("Importe");

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
