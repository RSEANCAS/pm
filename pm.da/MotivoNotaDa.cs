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
    public class MotivoNotaDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<MotivoNotaBe> ListarComboMotivoNota(int codigoTipoComprobante, SqlConnection cn)
        {
            List<MotivoNotaBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_motivonota_listar_combo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoTipoComprobante", codigoTipoComprobante);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            lista = new List<MotivoNotaBe>();

                            while (dr.Read())
                            {
                                MotivoNotaBe item = new MotivoNotaBe();
                                item.CodigoMotivoNota = dr.GetData<int>("CodigoMotivoNota");
                                item.Descripcion = dr.GetData<string>("Descripcion");
                                item.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.CodigoSunat = dr.GetData<string>("CodigoSunat");
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

        public List<MotivoNotaBe> BuscarMotivoNota(string descripcion, bool flagActivo, SqlConnection cn)
        {
            List<MotivoNotaBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_motivonota_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@descripcion", descripcion.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<MotivoNotaBe>();

                            while (dr.Read())
                            {
                                MotivoNotaBe item = new MotivoNotaBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoMotivoNota = dr.GetData<int>("CodigoMotivoNota");
                                item.Descripcion = dr.GetData<string>("Descripcion");
                                item.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.TipoComprobante = new TipoComprobanteBe();
                                item.TipoComprobante.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.TipoComprobante.Nombre = dr.GetData<string>("NombreTipoComprobante");
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

        public MotivoNotaBe ObtenerMotivoNota(int codigoMotivoNota, SqlConnection cn)
        {
            MotivoNotaBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_motivonota_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoMotivoNota", codigoMotivoNota.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new MotivoNotaBe();

                            if (dr.Read())
                            {
                                item.CodigoMotivoNota = dr.GetData<int>("CodigoMotivoNota");
                                item.Descripcion = dr.GetData<string>("Descripcion");
                                item.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool ExisteMotivoNota(string descripcion, int codigoTipoComprobante, int? codigoMotivoNota, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_motivonota_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@descripcion", descripcion.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoComprobante", codigoTipoComprobante.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMotivoNota", codigoMotivoNota.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarMotivoNota(MotivoNotaBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_motivonota_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoMotivoNota", registro.CodigoMotivoNota.GetNullable());
                    cmd.Parameters.AddWithValue("@descripcion", registro.Descripcion.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoComprobante", registro.CodigoTipoComprobante.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarFlagActivoMotivoNota(MotivoNotaBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_motivonota_cambiar_flagactivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoMotivoNota", registro.CodigoMotivoNota.GetNullable());
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
