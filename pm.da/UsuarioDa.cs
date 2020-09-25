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

        public List<UsuarioBe> BuscarUsuario(string nombre, string nroDocumentoIdentidadPersonal, string nombresPersonal, string correoPersonal, bool flagActivo, SqlConnection cn)
        {
            List<UsuarioBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_usuario_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidadPersonal", nroDocumentoIdentidadPersonal.GetNullable());
                    cmd.Parameters.AddWithValue("@nombresPersonal", nombresPersonal.GetNullable());
                    cmd.Parameters.AddWithValue("@correoPersonal", correoPersonal.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<UsuarioBe>();

                            while (dr.Read())
                            {
                                UsuarioBe item = new UsuarioBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoUsuario = dr.GetData<int>("CodigoUsuario");
                                item.Nombre = dr.GetData<string>("Nombre");
                                item.CodigoPersonal = dr.GetData<int>("CodigoPersonal");
                                item.Personal = new PersonalBe();
                                item.Personal.CodigoPersonal = dr.GetData<int>("CodigoPersonal");
                                item.Personal.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadPersonal");
                                item.Personal.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidadPersonal");
                                item.Personal.Nombres = dr.GetData<string>("NombresPersonal");
                                item.Personal.Correo = dr.GetData<string>("CorreoPersonal");
                                item.Personal.CodigoArea = dr.GetData<int>("CodigoAreaPersonal");
                                item.Personal.FlagActivo = dr.GetData<bool>("FlagActivoPersonal");
                                item.Personal.Estado = dr.GetData<int>("EstadoPersonal");
                                item.FlagCambiarContraseña = dr.GetData<bool>("FlagCambiarContraseña");
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

        public UsuarioBe ObtenerUsuario(int codigoUsuario, SqlConnection cn)
        {
            UsuarioBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_usuario_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoUsuario", codigoUsuario.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new UsuarioBe();

                            if (dr.Read())
                            {
                                item.CodigoUsuario = dr.GetData<int>("CodigoUsuario");
                                item.Nombre = dr.GetData<string>("Nombre");
                                item.CodigoPersonal = dr.GetData<int>("CodigoPersonal");
                                item.FlagCambiarContraseña = dr.GetData<bool>("FlagCambiarContraseña");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool ExisteUsuario(string nombre, int? codigoUsuario, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_usuario_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoUsuario", codigoUsuario.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarUsuario(UsuarioBe registro, SqlConnection cn, out int codigoUsuario)
        {
            codigoUsuario = 0;
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_usuario_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@codigoUsuario", Value = registro.CodigoUsuario.GetNullable(), Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@nombre", registro.Nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@contraseña", registro.Contraseña.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoPersonal", registro.CodigoPersonal.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;

                    if (seGuardo) codigoUsuario = (int)cmd.Parameters["@codigoUsuario"].Value;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarFlagActivoUsuario(UsuarioBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_usuario_cambiar_flagactivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoUsuario", registro.CodigoUsuario.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", registro.FlagActivo.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

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
                                usuario.FlagCambiarContraseña = dr.GetData<bool>("FlagCambiarContraseña");
                                usuario.FlagActivo = dr.GetData<bool>("FlagActivo");
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
