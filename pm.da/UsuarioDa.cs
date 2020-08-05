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
    public class UsuarioDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UsuarioBe ObtenerUsuarioPorNombre(string nombre, SqlConnection cn)
        {
            UsuarioBe usuario = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_usuario_obtener_x_nombre", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre);

                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            usuario = new UsuarioBe();
                            if (dr.Read())
                            {
                                usuario.CodigoUsuario = dr.GetData<int>("CodigoUsuario");
                                usuario.Nombre = dr.GetData<string>("Nombre");
                                usuario.Contraseña = dr.GetData<byte[]>("Contraseña");
                                usuario.CodigoPersonal = dr.GetData<int>("CodigoPersonal");
                            }
                        }
                    }
                }
            }
            catch(Exception ex) { log.Error(ex.Message); }

            return usuario;
        }
    }
}
