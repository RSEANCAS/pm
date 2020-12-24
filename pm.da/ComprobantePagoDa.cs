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
    public class ComprobantePagoDa
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ComprobantePagoBe> BuscarComprobantePago(DateTime? fechaPagoDesde, DateTime? fechaPagoHasta, int? codigoSerie, string nroComprobante, string nroDocIdentidadCliente, string nombresCliente, bool flagAnulado, SqlConnection cn)
        {
            List<ComprobantePagoBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantepago_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaPagoDesde", fechaPagoDesde.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaPagoHasta", fechaPagoHasta.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoSerie", codigoSerie.GetNullable());
                    cmd.Parameters.AddWithValue("@nroComprobante", nroComprobante.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidadCliente", nroDocIdentidadCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombresCliente", nombresCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@flagAnulado", flagAnulado.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<ComprobantePagoBe>();

                            while (dr.Read())
                            {
                                ComprobantePagoBe item = new ComprobantePagoBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoComprobantePago = dr.GetData<int>("CodigoComprobantePago");
                                item.FechaHoraPago = dr.GetData<DateTime>("FechaHoraPago");
                                item.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.Serie = new SerieBe();
                                item.Serie.Serial = dr.GetData<string>("SerialSerie");
                                item.NroComprobante = dr.GetData<int>("NroComprobante");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
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
                                item.Descripcion = dr.GetData<string>("Descripcion");
                                item.Monto = dr.GetData<decimal>("Monto");
                                item.FlagAnulado = dr.GetData<bool>("FlagAnulado");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public ComprobantePagoBe ObtenerComprobantePago(int codigoComprobantePago, SqlConnection cn)
        {
            ComprobantePagoBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantepago_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoComprobantePago", codigoComprobantePago.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new ComprobantePagoBe();

                            if (dr.Read())
                            {
                                item.CodigoComprobantePago = dr.GetData<int>("CodigoComprobantePago");
                                item.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.NroComprobante = dr.GetData<int>("NroComprobante");
                                item.FechaHoraPago = dr.GetData<DateTime>("FechaHoraPago");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.Descripcion = dr.GetData<string>("Descripcion");
                                item.Monto = dr.GetData<decimal>("Monto");
                                item.FlagAnulado = dr.GetData<bool>("FlagAnulado");
                                item.FlagEliminado = dr.GetData<bool>("FlagEliminado");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool CambiarFlagAnuladoComprobantePago(ComprobantePagoBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantepago_cambiar_flaganulado", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoComprobantePago", registro.CodigoComprobantePago.GetNullable());
                    cmd.Parameters.AddWithValue("@flagAnulado", registro.FlagAnulado.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool GuardarComprobantePago(ComprobantePagoBe registro, SqlConnection cn, out int codigoComprobantePago, out int nroComprobante)
        {
            codigoComprobantePago = 0;
            nroComprobante = 0;
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantepago_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@codigoComprobantePago", Value = registro.CodigoComprobantePago.GetNullable(), Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@fechaHoraPago", registro.FechaHoraPago.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoSerie", registro.CodigoSerie.GetNullable());
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@nroComprobante", Value = registro.NroComprobante.GetNullable(), Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@codigoMoneda", registro.CodigoMoneda.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCliente", registro.CodigoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@descripcion", registro.CodigoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@monto", registro.Monto.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;

                    if (seGuardo)
                    {
                        codigoComprobantePago = (int)cmd.Parameters["@codigoComprobantePago"].Value;
                        nroComprobante = (int)cmd.Parameters["@nroComprobante"].Value;
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }
    }
}
