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
    public class FacturaVentaDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<FacturaVentaBe> BuscarFacturaVenta(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, int? codigoSerie, string numero, string nroDocIdentidadCliente, string nombresCliente, bool flagActivo, SqlConnection cn)
        {
            List<FacturaVentaBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_facturaventa_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaEmisionDesde", fechaEmisionDesde.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaEmisionHasta", fechaEmisionHasta.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoSerie", codigoSerie.GetNullable());
                    cmd.Parameters.AddWithValue("@numero", numero.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidadCliente", nroDocIdentidadCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombresCliente", nombresCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<FacturaVentaBe>();

                            while (dr.Read())
                            {
                                FacturaVentaBe item = new FacturaVentaBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoFacturaVenta = dr.GetData<int>("CodigoFacturaVenta");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.FechaHoraVencimiento = dr.GetData<DateTime>("FechaHoraVencimiento");
                                item.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.Serie = new SerieBe();
                                item.Serie.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.Serie.Serial = dr.GetData<string>("SerialSerie");
                                item.NroComprobante = dr.GetData<int>("NroComprobante");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.Cliente = new ClienteBe();
                                item.Cliente.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.Cliente.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadCliente");
                                item.Cliente.TipoDocumentoIdentidad = new TipoDocumentoIdentidadBe();
                                item.Cliente.TipoDocumentoIdentidad.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadCliente");
                                item.Cliente.TipoDocumentoIdentidad.Descripcion = dr.GetData<string>("DescripcionTipoDocumentoIdentidadCliente");
                                item.Cliente.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidadCliente");
                                item.Cliente.Nombres = dr.GetData<string>("NombresCliente");
                                item.Cliente.FlagActivo = dr.GetData<bool>("FlagActivoCliente");
                                item.NroDocumentoIdentidadCliente = dr.GetData<string>("NroDocumentoIdentidadCliente");
                                item.DescripcionTipoDocumentoIdentidadCliente = dr.GetData<string>("DescripcionTipoDocumentoIdentidadCliente");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");
                                item.CodigoGuiaRemision = dr.GetData<int?>("CodigoGuiaRemision");
                                if (item.CodigoGuiaRemision.HasValue)
                                {
                                    item.GuiaRemision = new GuiaRemisionBe();
                                    item.GuiaRemision.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobanteGuiaRemision");
                                    item.GuiaRemision.TipoComprobante = new TipoComprobanteBe();
                                    item.GuiaRemision.TipoComprobante.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobanteGuiaRemision");
                                    item.GuiaRemision.TipoComprobante.Nombre = dr.GetData<string>("NombreTipoComprobanteGuiaRemision");
                                    item.GuiaRemision.CodigoSerie = dr.GetData<int>("CodigoSerieGuiaRemision");
                                    item.GuiaRemision.Serie = new SerieBe();
                                    item.GuiaRemision.Serie.CodigoSerie = dr.GetData<int>("CodigoSerieGuiaRemision");
                                    item.GuiaRemision.Serie.Serial = dr.GetData<string>("SerialSerieGuiaRemision");
                                    item.GuiaRemision.NroComprobante = dr.GetData<int>("NroComprobanteGuiaRemision");
                                    item.GuiaRemision.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmisionGuiaRemision");
                                }
                                item.CodigoCotizacion = dr.GetData<int?>("CodigoCotizacion");
                                if (item.CodigoCotizacion.HasValue)
                                {
                                    item.Cotizacion = new CotizacionBe();
                                    item.Cotizacion.NroComprobante = dr.GetData<int>("NroComprobanteCotizacion");
                                    item.Cotizacion.NroPedido = dr.GetData<string>("NroPedidoCotizacion");
                                    item.Cotizacion.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmisionCotizacion");
                                }
                                item.FlagEmitido = dr.GetData<bool>("FlagEmitido");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public FacturaVentaBe ObtenerFacturaVenta(int codigoFacturaVenta, SqlConnection cn)
        {
            FacturaVentaBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_facturaventa_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoFacturaVenta", codigoFacturaVenta.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new FacturaVentaBe();

                            if (dr.Read())
                            {
                                item.CodigoFacturaVenta = dr.GetData<int>("CodigoFacturaVenta");
                                item.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.NroComprobante = dr.GetData<int>("NroComprobante");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.FechaHoraVencimiento = dr.GetData<DateTime>("FechaHoraVencimiento");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.DireccionCliente = dr.GetData<string>("DireccionCliente");
                                item.NombrePaisCliente = dr.GetData<string>("NombrePaisCliente");
                                item.NombreDepartamentoCliente = dr.GetData<string>("NombreDepartamentoCliente");
                                item.NombreProvinciaCliente = dr.GetData<string>("NombreProvinciaCliente");
                                item.NombreDistritoCliente = dr.GetData<string>("NombreDistritoCliente");
                                item.CodigoDistritoCliente = dr.GetData<int>("CodigoDistritoCliente");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.CodigoMetodoPago = dr.GetData<int>("CodigoMetodoPago");
                                item.CantidadLetrasCredito = dr.GetData<int>("CantidadLetrasCredito");
                                item.TotalOperacionGravada = dr.GetData<decimal>("TotalOperacionGravada");
                                item.TotalOperacionInafecta = dr.GetData<decimal>("TotalOperacionInafecta");
                                item.TotalOperacionExonerada = dr.GetData<decimal>("TotalOperacionExonerada");
                                item.TotalOperacionExportacion = dr.GetData<decimal>("TotalOperacionExportacion");
                                item.TotalOperacionGratuita = dr.GetData<decimal>("TotalOperacionGratuita");
                                item.TotalIgv = dr.GetData<decimal>("TotalIgv");
                                item.TotalIsc = dr.GetData<decimal>("TotalIsc");
                                item.TotalOtrosCargos = dr.GetData<decimal>("TotalOtrosCargos");
                                item.TotalOtrosTributos = dr.GetData<decimal>("TotalOtrosTributos");
                                item.TotalIcbper = dr.GetData<decimal>("TotalIcbper");
                                item.TotalDescuentoDetallado = dr.GetData<decimal>("TotalDescuentoDetallado");
                                item.TotalPorcentajeDescuentoGlobal = dr.GetData<decimal>("TotalPorcentajeDescuentoGlobal");
                                item.TotalDescuentoGlobal = dr.GetData<decimal>("TotalDescuentoGlobal");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");
                                item.TotalPercepcion = dr.GetData<decimal>("TotalPercepcion");
                                item.TotalPagar = dr.GetData<decimal>("TotalPagar");
                                item.FlagEmitido = dr.GetData<bool>("FlagEmitido");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool CambiarFlagCanceladoFacturaVenta(FacturaVentaBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_facturaventa_cambiar_flagcancelado", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoFacturaVenta", registro.CodigoFacturaVenta.GetNullable());
                    cmd.Parameters.AddWithValue("@flagCancelado", registro.FlagCancelado.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool GuardarFacturaVenta(FacturaVentaBe registro, SqlConnection cn, out int codigoFacturaVenta, out int nroComprobante)
        {
            codigoFacturaVenta = 0;
            nroComprobante = 0;
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_facturaventa_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@codigoFacturaVenta", Value = registro.CodigoFacturaVenta.GetNullable(), Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@codigoSerie", registro.CodigoSerie.GetNullable());
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@nroComprobante", Value = registro.NroComprobante.GetNullable(), SqlDbType = SqlDbType.Int, Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@fechaHoraEmision", registro.FechaHoraEmision.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaHoraVencimiento", registro.FechaHoraVencimiento.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCliente", registro.CodigoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@direccionCliente", registro.DireccionCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombrePaisCliente", registro.NombrePaisCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreDepartamentoCliente", registro.NombreDepartamentoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreProvinciaCliente", registro.NombreProvinciaCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreDistritoCliente", registro.NombreDistritoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoDistritoCliente", registro.CodigoDistritoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMoneda", registro.CodigoMoneda.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMetodoPago", registro.CodigoMetodoPago.GetNullable());
                    cmd.Parameters.AddWithValue("@cantidadLetrasCredito", registro.CantidadLetrasCredito.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOperacionGravada", registro.TotalOperacionGravada.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOperacionInafecta", registro.TotalOperacionInafecta.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOperacionExonerada", registro.TotalOperacionExonerada.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOperacionExportacion", registro.TotalOperacionExportacion.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOperacionGratuita", registro.TotalOperacionGratuita.GetNullable());
                    cmd.Parameters.AddWithValue("@totalValorVenta", registro.TotalValorVenta.GetNullable());
                    cmd.Parameters.AddWithValue("@totalIgv", registro.TotalIgv.GetNullable());
                    cmd.Parameters.AddWithValue("@totalIsc", registro.TotalIsc.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOtrosCargos", registro.TotalOtrosCargos.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOtrosTributos", registro.TotalOtrosTributos.GetNullable());
                    cmd.Parameters.AddWithValue("@totalIcbper", registro.TotalIcbper.GetNullable());
                    cmd.Parameters.AddWithValue("@totalDescuentoDetallado", registro.TotalDescuentoDetallado.GetNullable());
                    cmd.Parameters.AddWithValue("@totalPorcentajeDescuentoGlobal", registro.TotalPorcentajeDescuentoGlobal.GetNullable());
                    cmd.Parameters.AddWithValue("@totalDescuentoGlobal", registro.TotalDescuentoGlobal.GetNullable());
                    cmd.Parameters.AddWithValue("@totalPrecioVenta", registro.TotalPrecioVenta.GetNullable());
                    cmd.Parameters.AddWithValue("@totalImporte", registro.TotalImporte.GetNullable());
                    cmd.Parameters.AddWithValue("@totalPercepcion", registro.TotalPercepcion.GetNullable());
                    cmd.Parameters.AddWithValue("@totalPagar", registro.TotalPagar.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoGuiaRemision", registro.CodigoGuiaRemision.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCotizacion", registro.CodigoCotizacion.GetNullable());
                    cmd.Parameters.AddWithValue("@flagEmitido", registro.FlagEmitido.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;

                    if (seGuardo)
                    {
                        codigoFacturaVenta = (int)cmd.Parameters["@codigoFacturaVenta"].Value;
                        nroComprobante = (int)cmd.Parameters["@nroComprobante"].Value;
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }
    }
}
