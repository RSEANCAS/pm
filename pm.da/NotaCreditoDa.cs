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
    public class NotaCreditoDa
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<NotaCreditoBe> BuscarNotaCredito(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, int? codigoSerie, string numero, string nroDocIdentidadCliente, string nombresCliente, bool flagActivo, SqlConnection cn)
        {
            List<NotaCreditoBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_notacredito_buscar", cn))
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
                            resultados = new List<NotaCreditoBe>();

                            while (dr.Read())
                            {
                                NotaCreditoBe item = new NotaCreditoBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoNotaCredito = dr.GetData<int>("CodigoNotaCredito");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
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
                                item.CodigoMotivoNota = dr.GetData<int>("CodigoMotivoNota");
                                item.MotivoNota = new MotivoNotaBe();
                                item.MotivoNota.CodigoMotivoNota = dr.GetData<int>("CodigoMotivoNota");
                                item.MotivoNota.Descripcion = dr.GetData<string>("DescripcionMotivoNota");
                                item.CodigoTipoComprobanteRef = dr.GetData<int>("CodigoTipoComprobanteRef");
                                item.TipoComprobanteRef = new TipoComprobanteBe();
                                item.TipoComprobanteRef.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobanteRef");
                                item.TipoComprobanteRef.Nombre = dr.GetData<string>("NombreTipoComprobanteRef");
                                item.CodigoComprobanteRef = dr.GetData<int>("CodigoComprobanteRef");
                                item.ComprobanteRef = new BaseComprobante();
                                item.ComprobanteRef.CodigoSerie = dr.GetData<int>("CodigoSerieComprobanteRef");
                                item.ComprobanteRef.Serie = new SerieBe();
                                item.ComprobanteRef.Serie.CodigoSerie = dr.GetData<int>("CodigoSerieComprobanteRef");
                                item.ComprobanteRef.Serie.Serial = dr.GetData<string>("SerialSerieComprobanteRef");
                                item.ComprobanteRef.NroComprobante = dr.GetData<int>("NroComprobanteComprobanteRef");
                                item.ComprobanteRef.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmisionComprobanteRef");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");

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

        public NotaCreditoBe ObtenerNotaCredito(int codigoNotaCredito, SqlConnection cn)
        {
            NotaCreditoBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_notacredito_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoNotaCredito", codigoNotaCredito.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new NotaCreditoBe();

                            if (dr.Read())
                            {
                                item.CodigoNotaCredito = dr.GetData<int>("CodigoNotaCredito");
                                item.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.NroComprobante = dr.GetData<int>("NroComprobante");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.DireccionCliente = dr.GetData<string>("DireccionCliente");
                                item.NombrePaisCliente = dr.GetData<string>("NombrePaisCliente");
                                item.NombreDepartamentoCliente = dr.GetData<string>("NombreDepartamentoCliente");
                                item.NombreProvinciaCliente = dr.GetData<string>("NombreProvinciaCliente");
                                item.NombreDistritoCliente = dr.GetData<string>("NombreDistritoCliente");
                                item.CodigoDistritoCliente = dr.GetData<int>("CodigoDistritoCliente");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.CodigoMotivoNota = dr.GetData<int>("CodigoMotivoNota");
                                item.CodigoTipoComprobanteRef = dr.GetData<int>("CodigoTipoComprobanteRef");
                                item.CodigoComprobanteRef = dr.GetData<int>("CodigoComprobanteRef");
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

        public bool GuardarNotaCredito(NotaCreditoBe registro, SqlConnection cn, out int codigoNotaCredito, out int nroComprobante)
        {
            codigoNotaCredito = 0;
            nroComprobante = 0;
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_notacredito_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@codigoNotaCredito", Value = registro.CodigoNotaCredito.GetNullable(), Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@codigoSerie", registro.CodigoSerie.GetNullable());
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@nroComprobante", Value = registro.NroComprobante.GetNullable(), SqlDbType = SqlDbType.Int, Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@fechaHoraEmision", registro.FechaHoraEmision.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCliente", registro.CodigoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@direccionCliente", registro.DireccionCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombrePaisCliente", registro.NombrePaisCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreDepartamentoCliente", registro.NombreDepartamentoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreProvinciaCliente", registro.NombreProvinciaCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreDistritoCliente", registro.NombreDistritoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoDistritoCliente", registro.CodigoDistritoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMoneda", registro.CodigoMoneda.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoComprobanteRef", registro.CodigoTipoComprobanteRef.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoComprobanteRef", registro.CodigoComprobanteRef.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMotivoNota", registro.CodigoMotivoNota.GetNullable());
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
                    cmd.Parameters.AddWithValue("@flagEmitido", registro.FlagEmitido.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;

                    if (seGuardo)
                    {
                        codigoNotaCredito = (int)cmd.Parameters["@codigoNotaCredito"].Value;
                        nroComprobante = (int)cmd.Parameters["@nroComprobante"].Value;
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }
    }
}
