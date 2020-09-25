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
    public class MotivoTrasladoDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<MotivoTrasladoBe> ListarComboMotivoTraslado(SqlConnection cn)
        {
            List<MotivoTrasladoBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_motivotraslado_listar_combo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            lista = new List<MotivoTrasladoBe>();

                            while (dr.Read())
                            {
                                MotivoTrasladoBe item = new MotivoTrasladoBe();
                                item.CodigoMotivoTraslado = dr.GetData<int>("CodigoMotivoTraslado");
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

        public List<MotivoTrasladoBe> BuscarMotivoTraslado(string descripcion, bool flagActivo, SqlConnection cn)
        {
            List<MotivoTrasladoBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_motivotraslado_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@descripcion", descripcion.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<MotivoTrasladoBe>();

                            while (dr.Read())
                            {
                                MotivoTrasladoBe item = new MotivoTrasladoBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoMotivoTraslado = dr.GetData<int>("CodigoMotivoTraslado");
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

        public MotivoTrasladoBe ObtenerMotivoTraslado(int codigoMotivoTraslado, SqlConnection cn)
        {
            MotivoTrasladoBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_motivotraslado_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoMotivoTraslado", codigoMotivoTraslado.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new MotivoTrasladoBe();

                            if (dr.Read())
                            {
                                item.CodigoMotivoTraslado = dr.GetData<int>("CodigoMotivoTraslado");
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

        public bool ExisteMotivoTraslado(string descripcion, int? codigoMotivoTraslado, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_motivotraslado_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@descripcion", descripcion.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMotivoTraslado", codigoMotivoTraslado.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarMotivoTraslado(MotivoTrasladoBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_motivotraslado_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoMotivoTraslado", registro.CodigoMotivoTraslado.GetNullable());
                    cmd.Parameters.AddWithValue("@descripcion", registro.Descripcion.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarFlagActivoMotivoTraslado(MotivoTrasladoBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_motivotraslado_cambiar_flagactivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoMotivoTraslado", registro.CodigoMotivoTraslado.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", registro.FlagActivo.GetNullable());
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
