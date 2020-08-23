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

        public List<PerfilBe> BuscarPerfil(string nombre, bool flagActivo, SqlConnection cn)
        {
            List<PerfilBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_perfil_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<PerfilBe>();

                            while (dr.Read())
                            {
                                PerfilBe item = new PerfilBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoPerfil = dr.GetData<int>("CodigoPerfil");
                                item.Nombre = dr.GetData<string>("Nombre");
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

        public PerfilBe ObtenerPerfil(int codigoPerfil, SqlConnection cn)
        {
            PerfilBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_perfil_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoPerfil", codigoPerfil.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new PerfilBe();

                            if (dr.Read())
                            {
                                item.CodigoPerfil = dr.GetData<int>("CodigoPerfil");
                                item.Nombre = dr.GetData<string>("Nombre");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool ExistePerfil(string nombre, int? codigoPerfil, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_perfil_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoPerfil", codigoPerfil.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarPerfil(PerfilBe registro, SqlConnection cn, out int codigoPerfil)
        {
            codigoPerfil = 0;
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_perfil_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@codigoPerfil", Value = registro.CodigoPerfil.GetNullable(), Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@nombre", registro.Nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;

                    if (seGuardo) codigoPerfil = (int)cmd.Parameters["@codigoPerfil"].Value;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarFlagActivoPerfil(PerfilBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_perfil_cambiar_flagactivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoPerfil", registro.CodigoPerfil.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", registro.FlagActivo.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

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

        public List<PerfilBe> ListarPerfilDefaultPorUsuario(int? codigoUsuario, SqlConnection cn)
        {
            List<PerfilBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_perfil_listar_default_x_usuario", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoUsuario", codigoUsuario.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
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
                                item.Check = dr.GetData<bool>("Check");

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
