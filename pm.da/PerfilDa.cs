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
    public class PerfilDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<PerfilBe> ListarPerfilPorUsuario(int codigoUsuario, SqlConnection cn)
        {
            List<PerfilBe> lista = null;

            try
            {
                using(SqlCommand cmd = new SqlCommand("dbo.usp_perfil_listar_x_usuario", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoUsuario", codigoUsuario);

                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            lista = new List<PerfilBe>();

                            while (dr.Read())
                            {
                                PerfilBe item = new PerfilBe();
                                item.CodigoPerfil = dr.GetData<int>("CodigoPerfil");
                                item.Nombre = dr.GetData<string>("Nombre");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");

                                lista.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return lista;
        }
    }
}
