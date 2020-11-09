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
    public class ConfiguracionValorDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConfiguracionValorBe ObtenerConfiguracionValor(SqlConnection cn)
        {
            ConfiguracionValorBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_configuracionvalor_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new ConfiguracionValorBe();

                            if (dr.Read())
                            {
                                item.CodigoUsuario = dr.GetData<int?>("CodigoUsuario");
                                item.CodigoTipoComprobanteGuiaRemision = dr.GetData<int?>("CodigoTipoComprobanteGuiaRemision");
                                item.CodigoTransportistaGuiaRemision = dr.GetData<int?>("CodigoTransportistaGuiaRemision");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool GuardarConfiguracionValor(ConfiguracionValorBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_configuracionvalor_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoUsuario", registro.CodigoUsuario.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoComprobanteGuiaRemision", registro.CodigoTipoComprobanteGuiaRemision.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTransportistaGuiaRemision", registro.CodigoTransportistaGuiaRemision.GetNullable());
                    //cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }
    }
}
