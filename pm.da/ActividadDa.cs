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
    public class ActividadDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ActividadBe> BuscarActividad(string nombre, bool flagActivo, SqlConnection cn)
        {
            List<ActividadBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_actividad_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<ActividadBe>();

                            while (dr.Read())
                            {
                                ActividadBe item = new ActividadBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoActividad = dr.GetData<int>("CodigoActividad");
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

        public ActividadBe ObtenerActividad(int codigoActividad, SqlConnection cn)
        {
            ActividadBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_actividad_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoActividad", codigoActividad.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new ActividadBe();

                            if (dr.Read())
                            {
                                item.CodigoActividad = dr.GetData<int>("CodigoActividad");
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

        public bool ExisteActividad(string nombre, int? codigoActividad, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_actividad_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoActividad", codigoActividad.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarActividad(ActividadBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_actividad_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoActividad", registro.CodigoActividad.GetNullable());
                    cmd.Parameters.AddWithValue("@nombre", registro.Nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarFlagActivoActividad(ActividadBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_actividad_cambiar_flagactivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoActividad", registro.CodigoActividad.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", registro.FlagActivo.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public List<ActividadBe> ListarComboActividad(SqlConnection cn)
        {
            List<ActividadBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_actividad_listar_combo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            lista = new List<ActividadBe>();

                            while (dr.Read())
                            {
                                ActividadBe item = new ActividadBe();
                                item.CodigoActividad = dr.GetData<int>("CodigoActividad");
                                item.Nombre = dr.GetData<string>("Nombre");

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
