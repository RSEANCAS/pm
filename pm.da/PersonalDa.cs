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
    public class PersonalDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<PersonalBe> BuscarPersonal(string nroDocumentoIdentidad, string nombres, string correo, string nombreArea, int? estado, bool flagActivo, SqlConnection cn)
        {
            List<PersonalBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_personal_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidad", nroDocumentoIdentidad.GetNullable());
                    cmd.Parameters.AddWithValue("@nombres", nombres.GetNullable());
                    cmd.Parameters.AddWithValue("@correo", correo.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreArea", nombreArea.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());
                    cmd.Parameters.AddWithValue("@estado", estado.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<PersonalBe>();

                            while (dr.Read())
                            {
                                PersonalBe item = new PersonalBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoPersonal = dr.GetData<int>("CodigoPersonal");
                                item.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidad");
                                item.TipoDocumentoIdentidad = new TipoDocumentoIdentidadBe();
                                item.TipoDocumentoIdentidad.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidad");
                                item.TipoDocumentoIdentidad.Descripcion = dr.GetData<string>("DescripcionTipoDocumentoIdentidad");
                                item.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidad");
                                item.Nombres = dr.GetData<string>("Nombres");
                                item.Correo = dr.GetData<string>("Correo");
                                item.CodigoArea = dr.GetData<int>("CodigoArea");
                                item.Area = new AreaBe();
                                item.Area.CodigoArea = dr.GetData<int>("CodigoArea");
                                item.Area.Nombre = dr.GetData<string>("NombreArea");
                                item.Area.FlagActivo = dr.GetData<bool>("FlagActivoArea");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                                item.Estado = dr.GetData<int>("Estado");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public PersonalBe ObtenerPersonal(int codigoPersonal, SqlConnection cn)
        {
            PersonalBe personal = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_personal_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoPersonal", codigoPersonal);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            personal = new PersonalBe();
                            if (dr.Read())
                            {
                                personal.CodigoPersonal = dr.GetData<int>("CodigoPersonal");
                                personal.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidad");
                                personal.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidad");
                                personal.Nombres = dr.GetData<string>("Nombres");
                                personal.Correo = dr.GetData<string>("Correo");
                                personal.CodigoArea = dr.GetData<int>("CodigoArea");
                                personal.FlagActivo = dr.GetData<bool>("FlagActivo");
                                personal.Estado = dr.GetData<int>("Estado");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return personal;
        }

        public bool ExistePersonal(string nombre, int? codigoPersonal, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_personal_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoPersonal", codigoPersonal.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarPersonal(PersonalBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_personal_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoPersonal", registro.CodigoPersonal.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoDocumentoIdentidad", registro.CodigoTipoDocumentoIdentidad.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidad", registro.NroDocumentoIdentidad.GetNullable());
                    cmd.Parameters.AddWithValue("@nombres", registro.Nombres.GetNullable());
                    cmd.Parameters.AddWithValue("@correo", registro.Correo.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoArea", registro.CodigoArea.GetNullable());
                    cmd.Parameters.AddWithValue("@estado", registro.Estado.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarFlagActivoPersonal(PersonalBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_personal_cambiar_flagactivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoPersonal", registro.CodigoPersonal.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", registro.FlagActivo.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarEstadoPersonal(PersonalBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_personal_cambiar_estado", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoPersonal", registro.CodigoPersonal.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", registro.Estado.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }
    }
}
