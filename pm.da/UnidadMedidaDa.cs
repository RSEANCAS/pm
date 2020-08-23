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
    public class UnidadMedidaDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<UnidadMedidaBe> BuscarUnidadMedida(string descripcion, bool flagActivo, SqlConnection cn)
        {
            List<UnidadMedidaBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_unidadmedida_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@descripcion", descripcion.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<UnidadMedidaBe>();

                            while (dr.Read())
                            {
                                UnidadMedidaBe item = new UnidadMedidaBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoUnidadMedida = dr.GetData<int>("CodigoUnidadMedida");
                                item.Descripcion = dr.GetData<string>("Descripcion");
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

        public UnidadMedidaBe ObtenerUnidadMedida(int codigoUnidadMedida, SqlConnection cn)
        {
            UnidadMedidaBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_unidadmedida_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoUnidadMedida", codigoUnidadMedida.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new UnidadMedidaBe();

                            if (dr.Read())
                            {
                                item.CodigoUnidadMedida = dr.GetData<int>("CodigoUnidadMedida");
                                item.Descripcion = dr.GetData<string>("Descripcion");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool ExisteUnidadMedida(string descripcion, int? codigoUnidadMedida, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_unidadmedida_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@descripcion", descripcion.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoUnidadMedida", codigoUnidadMedida.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarUnidadMedida(UnidadMedidaBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_unidadmedida_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoUnidadMedida", registro.CodigoUnidadMedida.GetNullable());
                    cmd.Parameters.AddWithValue("@descripcion", registro.Descripcion.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarFlagActivoUnidadMedida(UnidadMedidaBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_unidadmedida_cambiar_flagactivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoUnidadMedida", registro.CodigoUnidadMedida.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", registro.FlagActivo.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public List<UnidadMedidaBe> ListarComboUnidadMedida(SqlConnection cn)
        {
            List<UnidadMedidaBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_unidadmedida_listar_combo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            lista = new List<UnidadMedidaBe>();

                            while (dr.Read())
                            {
                                UnidadMedidaBe item = new UnidadMedidaBe();
                                item.CodigoUnidadMedida = dr.GetData<int>("CodigoUnidadMedida");
                                item.Descripcion = dr.GetData<string>("Descripcion");
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
