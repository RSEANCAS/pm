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
    public class LetraDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<LetraBe> ListarLetraPorRef(int codigoTipoComprobanteRef, int codigoSerieRef, int numeroRef, SqlConnection cn)
        {
            List<LetraBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_listar_x_ref", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoTipoComprobanteRef", codigoTipoComprobanteRef.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoSerieRef", codigoSerieRef.GetNullable());
                    cmd.Parameters.AddWithValue("@numeroRef", numeroRef.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<LetraBe>();

                            while (dr.Read())
                            {
                                LetraBe item = new LetraBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoLetra = dr.GetData<int>("CodigoLetra");
                                item.Numero = dr.GetData<int>("Numero");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.FechaVencimiento = dr.GetData<DateTime>("FechaVencimiento");
                                item.CodigoTipoComprobanteRef = dr.GetData<int>("CodigoTipoComprobanteRef");
                                item.CodigoSerieRef = dr.GetData<int>("CodigoSerieRef");
                                item.NumeroRef = dr.GetData<int>("NumeroRef");
                                item.CodigoSerieGuia = dr.GetData<int>("CodigoSerieGuia");
                                item.NumeroGuia = dr.GetData<int>("NumeroGuia");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.CodigoBanco = dr.GetData<int>("CodigoBanco");
                                item.CodigoUnicoBanco = dr.GetData<string>("CodigoUnicoBanco");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.Monto = dr.GetData<decimal>("Monto");
                                item.Estado = dr.GetData<string>("Estado");
                                item.FlagCancelado = dr.GetData<bool>("FlagCancelado");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public bool GuardarLetra(LetraBe registro, SqlConnection cn, out int codigoLetra, out int numero)
        {
            codigoLetra = 0;
            numero = 0;
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@codigoLetra", Value = registro.CodigoLetra.GetNullable(), Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@numero", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output });
                    cmd.Parameters.AddWithValue("@fechaHoraEmision", registro.FechaHoraEmision.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaVencimiento", registro.FechaVencimiento.GetNullable());
                    cmd.Parameters.AddWithValue("@dias", registro.Dias.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoComprobanteRef", registro.CodigoTipoComprobanteRef.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoSerieRef", registro.CodigoSerieRef.GetNullable());
                    cmd.Parameters.AddWithValue("@numeroRef", registro.NumeroRef.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoSerieGuia", registro.CodigoSerieGuia.GetNullable());
                    cmd.Parameters.AddWithValue("@numeroGuia", registro.NumeroGuia.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCliente", registro.CodigoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoBanco", registro.CodigoBanco.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoUnicoBanco", registro.CodigoUnicoBanco.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMoneda", registro.CodigoMoneda.GetNullable());
                    cmd.Parameters.AddWithValue("@monto", registro.Monto.GetNullable());
                    cmd.Parameters.AddWithValue("@estado", registro.Estado.GetNullable());
                    cmd.Parameters.AddWithValue("@flagCancelado", registro.FlagCancelado.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;

                    if (seGuardo)
                    {
                        codigoLetra = (int)cmd.Parameters["@codigoLetra"].Value;
                        numero = (int)cmd.Parameters["@numero"].Value;
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool EliminarLetraPorRef(int codigoTipoComprobanteRef, int CodigoSerieRef, int numeroRef, string usuarioModi, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_eliminar_x_ref", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoTipoComprobanteRef", codigoTipoComprobanteRef.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoSerieRef", CodigoSerieRef.GetNullable());
                    cmd.Parameters.AddWithValue("@numeroRef", numeroRef.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", usuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas >= 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }
    }
}
