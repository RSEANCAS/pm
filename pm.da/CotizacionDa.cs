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
    public class CotizacionDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<CotizacionBe> BuscarCotizacion(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, string numero, string nroDocIdentidadCliente, string nombresCliente, bool flagActivo, SqlConnection cn)
        {
            List<CotizacionBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_cotizacion_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaEmisionDesde", fechaEmisionDesde.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaEmisionHasta", fechaEmisionHasta.GetNullable());
                    cmd.Parameters.AddWithValue("@numero", numero.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidadCliente", nroDocIdentidadCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombresCliente", nombresCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<CotizacionBe>();

                            while (dr.Read())
                            {
                                CotizacionBe item = new CotizacionBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoCotizacion = dr.GetData<int>("CodigoCotizacion");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.NroComprobante = dr.GetData<int>("NroComprobante");
                                item.NroPedido = dr.GetData<string>("NroPedido");
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
                                item.CodigoVendedor = dr.GetData<int>("CodigoVendedor");
                                item.Vendedor = new PersonalBe();
                                item.Vendedor.CodigoPersonal = dr.GetData<int>("CodigoVendedor");
                                item.Vendedor.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadVendedor");
                                item.Vendedor.TipoDocumentoIdentidad = new TipoDocumentoIdentidadBe();
                                item.Vendedor.TipoDocumentoIdentidad.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadVendedor");
                                item.Vendedor.TipoDocumentoIdentidad.Descripcion = dr.GetData<string>("DescripcionTipoDocumentoIdentidadVendedor");
                                item.Vendedor.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidadVendedor");
                                item.Vendedor.Nombres = dr.GetData<string>("NombresVendedor");
                                item.Vendedor.FlagActivo = dr.GetData<bool>("FlagActivoVendedor");
                                item.NroDocumentoIdentidadVendedor = dr.GetData<string>("NroDocumentoIdentidadVendedor");
                                item.DescripcionTipoDocumentoIdentidadVendedor = dr.GetData<string>("DescripcionTipoDocumentoIdentidadVendedor");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");
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

        public CotizacionBe ObtenerCotizacion(int codigoCotizacion, SqlConnection cn)
        {
            CotizacionBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_cotizacion_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoCotizacion", codigoCotizacion.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new CotizacionBe();

                            if (dr.Read())
                            {
                                item.CodigoCotizacion = dr.GetData<int>("CodigoCotizacion");
                                item.NroComprobante = dr.GetData<int>("NroComprobante");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.NroPedido = dr.GetData<string>("NroPedido");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.CodigoVendedor = dr.GetData<int>("CodigoVendedor");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool GuardarCotizacion(CotizacionBe registro, SqlConnection cn, out int codigoCotizacion, out int nroComprobante)
        {
            codigoCotizacion = 0;
            nroComprobante = 0;
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_cotizacion_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@codigoCotizacion", Value = registro.CodigoCotizacion.GetNullable(), Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@nroComprobante", Value = registro.NroComprobante.GetNullable(), SqlDbType = SqlDbType.Int, Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@fechaHoraEmision", registro.FechaHoraEmision.GetNullable());
                    cmd.Parameters.AddWithValue("@nroPedido", registro.NroPedido.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCliente", registro.CodigoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoVendedor", registro.CodigoVendedor.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMoneda", registro.CodigoMoneda.GetNullable());
                    cmd.Parameters.AddWithValue("@totalImporte", registro.TotalImporte.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;

                    if (seGuardo)
                    {
                        codigoCotizacion = (int)cmd.Parameters["@codigoCotizacion"].Value;
                        nroComprobante = (int)cmd.Parameters["@nroComprobante"].Value;
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }
    }
}
