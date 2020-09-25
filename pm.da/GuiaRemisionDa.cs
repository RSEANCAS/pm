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
    public class GuiaRemisionDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<GuiaRemisionBe> BuscarGuiaRemision(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, int? codigoSerie, string numero, string nroDocIdentidadCliente, string nombresCliente, bool flagActivo, SqlConnection cn)
        {
            List<GuiaRemisionBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_guiaremision_buscar", cn))
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
                            resultados = new List<GuiaRemisionBe>();

                            while (dr.Read())
                            {
                                GuiaRemisionBe item = new GuiaRemisionBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoGuiaRemision = dr.GetData<int>("CodigoGuiaRemision");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.FechaHoraTraslado = dr.GetData<DateTime>("FechaHoraTraslado");
                                item.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.TipoComprobante = new TipoComprobanteBe();
                                item.TipoComprobante.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.TipoComprobante.Nombre = dr.GetData<string>("NombreTipoComprobante");
                                item.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.Serie = new SerieBe();
                                item.Serie.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.Serie.Serial = dr.GetData<string>("SerialSerie");
                                item.NroComprobante = dr.GetData<int>("NroComprobante");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.DescripcionTipoDocumentoIdentidadCliente = dr.GetData<string>("DescripcionTipoDocumentoIdentidadCliente");
                                item.NroDocumentoIdentidadCliente = dr.GetData<string>("NroDocumentoIdentidadCliente");
                                item.Cliente = new ClienteBe();
                                item.Cliente.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.Cliente.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadCliente");
                                item.Cliente.TipoDocumentoIdentidad = new TipoDocumentoIdentidadBe();
                                item.Cliente.TipoDocumentoIdentidad.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadCliente");
                                item.Cliente.TipoDocumentoIdentidad.Descripcion = dr.GetData<string>("DescripcionTipoDocumentoIdentidadCliente");
                                item.Cliente.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidadCliente");
                                item.Cliente.Nombres = dr.GetData<string>("NombresCliente");
                                item.Cliente.FlagActivo = dr.GetData<bool>("FlagActivoCliente");
                                item.CodigoMotivoTraslado = dr.GetData<int>("CodigoMotivoTraslado");
                                item.MotivoTraslado = new MotivoTrasladoBe();
                                item.MotivoTraslado.CodigoMotivoTraslado = dr.GetData<int>("CodigoMotivoTraslado");
                                item.MotivoTraslado.Descripcion = dr.GetData<string>("DescripcionMotivoTraslado");
                                item.CodigoTransportista = dr.GetData<int>("CodigoTransportista");
                                item.DescripcionTipoDocumentoIdentidadTransportista = dr.GetData<string>("DescripcionTipoDocumentoIdentidadTransportista");
                                item.NroDocumentoIdentidadTransportista = dr.GetData<string>("NroDocumentoIdentidadTransportista");
                                item.Transportista = new ProveedorBe();
                                item.Transportista.CodigoProveedor = dr.GetData<int>("CodigoTransportista");
                                item.Transportista.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadTransportista");
                                item.Transportista.TipoDocumentoIdentidad = new TipoDocumentoIdentidadBe();
                                item.Transportista.TipoDocumentoIdentidad.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadTransportista");
                                item.Transportista.TipoDocumentoIdentidad.Descripcion = dr.GetData<string>("DescripcionTipoDocumentoIdentidadTransportista");
                                item.Transportista.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidadTransportista");
                                item.Transportista.Nombres = dr.GetData<string>("NombresTransportista");
                                item.Transportista.FlagActivo = dr.GetData<bool>("FlagActivoTransportista");
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

        public GuiaRemisionBe ObtenerGuiaRemision(int codigoGuiaRemision, SqlConnection cn)
        {
            GuiaRemisionBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_guiaremision_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoGuiaRemision", codigoGuiaRemision.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new GuiaRemisionBe();

                            if (dr.Read())
                            {
                                item.CodigoGuiaRemision = dr.GetData<int>("CodigoGuiaRemision");
                                item.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.NroComprobante = dr.GetData<int>("NroComprobante");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.FechaHoraTraslado = dr.GetData<DateTime>("FechaHoraTraslado");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.DireccionCliente = dr.GetData<string>("DireccionCliente");
                                item.NombrePaisCliente = dr.GetData<string>("NombrePaisCliente");
                                item.NombreDepartamentoCliente = dr.GetData<string>("NombreDepartamentoCliente");
                                item.NombreProvinciaCliente = dr.GetData<string>("NombreProvinciaCliente");
                                item.NombreDistritoCliente = dr.GetData<string>("NombreDistritoCliente");
                                item.CodigoDistritoCliente = dr.GetData<int>("CodigoDistritoCliente");
                                item.CodigoMotivoTraslado = dr.GetData<int>("CodigoMotivoTraslado");
                                item.CodigoTransportista = dr.GetData<int>("CodigoTransportista");
                                item.DireccionTransportista = dr.GetData<string>("DireccionTransportista");
                                item.NombrePaisTransportista = dr.GetData<string>("NombrePaisTransportista");
                                item.NombreDepartamentoTransportista = dr.GetData<string>("NombreDepartamentoTransportista");
                                item.NombreProvinciaTransportista = dr.GetData<string>("NombreProvinciaTransportista");
                                item.NombreDistritoTransportista = dr.GetData<string>("NombreDistritoTransportista");
                                item.CodigoDistritoTransportista = dr.GetData<int>("CodigoDistritoTransportista");
                                item.MarcaVehiculoTransportista = dr.GetData<string>("MarcaVehiculoTransportista");
                                item.PlacaVehiculoTransportista = dr.GetData<string>("PlacaVehiculoTransportista");
                                item.LicenciaConducirTransportista = dr.GetData<string>("LicenciaConducirTransportista");
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

        public bool GuardarGuiaRemision(GuiaRemisionBe registro, SqlConnection cn, out int codigoGuiaRemision, out int nroComprobante)
        {
            codigoGuiaRemision = 0;
            nroComprobante = 0;
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_guiaremision_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@codigoGuiaRemision", Value = registro.CodigoGuiaRemision.GetNullable(), Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@codigoTipoComprobante", registro.CodigoTipoComprobante.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoSerie", registro.CodigoSerie.GetNullable());
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@nroComprobante", Value = registro.NroComprobante.GetNullable(), SqlDbType = SqlDbType.Int, Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@fechaHoraEmision", registro.FechaHoraEmision.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaHoraTraslado", registro.FechaHoraTraslado.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCliente", registro.CodigoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@direccionCliente", registro.DireccionCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombrePaisCliente", registro.NombrePaisCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreDepartamentoCliente", registro.NombreDepartamentoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreProvinciaCliente", registro.NombreProvinciaCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreDistritoCliente", registro.NombreDistritoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoDistritoCliente", registro.CodigoDistritoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMotivoTraslado", registro.CodigoMotivoTraslado.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTransportista", registro.CodigoTransportista.GetNullable());
                    cmd.Parameters.AddWithValue("@direccionTransportista", registro.DireccionTransportista.GetNullable());
                    cmd.Parameters.AddWithValue("@nombrePaisTransportista", registro.NombrePaisTransportista.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreDepartamentoTransportista", registro.NombreDepartamentoTransportista.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreProvinciaTransportista", registro.NombreProvinciaTransportista.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreDistritoTransportista", registro.NombreDistritoTransportista.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoDistritoTransportista", registro.CodigoDistritoTransportista.GetNullable());
                    cmd.Parameters.AddWithValue("@marcaVehiculoTransportista", registro.MarcaVehiculoTransportista.GetNullable());
                    cmd.Parameters.AddWithValue("@placaVehiculoTransportista", registro.PlacaVehiculoTransportista.GetNullable());
                    cmd.Parameters.AddWithValue("@licenciaConducirTransportista", registro.LicenciaConducirTransportista.GetNullable());
                    cmd.Parameters.AddWithValue("@flagEmitido", registro.FlagEmitido.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;

                    if (seGuardo)
                    {
                        codigoGuiaRemision = (int)cmd.Parameters["@codigoGuiaRemision"].Value;
                        nroComprobante = (int)cmd.Parameters["@nroComprobante"].Value;
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }
    }
}
