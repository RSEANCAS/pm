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
    public class SerieDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<SerieBe> ListarComboSerie(int codigoTipoComprobante, SqlConnection cn)
        {
            List<SerieBe> lista = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_serie_listar_combo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoTipoComprobante", codigoTipoComprobante);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            lista = new List<SerieBe>();

                            while (dr.Read())
                            {
                                SerieBe item = new SerieBe();
                                item.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.Serial = dr.GetData<string>("Serial");
                                item.ValorInicial = dr.GetData<int>("ValorInicial");
                                item.ValorFinal = dr.GetData<int>("ValorFinal");
                                item.ValorActual = dr.GetData<int>("ValorActual");
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

        public List<SerieBe> BuscarSerie(string serial, int? codigoTipoComprobante, bool flagActivo, SqlConnection cn)
        {
            List<SerieBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_serie_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@serial", serial.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoComprobante", codigoTipoComprobante.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<SerieBe>();

                            while (dr.Read())
                            {
                                SerieBe item = new SerieBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.TipoComprobante = new TipoComprobanteBe();
                                item.TipoComprobante.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.TipoComprobante.Nombre = dr.GetData<string>("NombreTipoComprobante");
                                item.Serial = dr.GetData<string>("Serial");
                                item.ValorInicial = dr.GetData<int>("ValorInicial");
                                item.ValorFinal = dr.GetData<int>("ValorFinal");
                                item.ValorActual = dr.GetData<int>("ValorActual");
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

        public SerieBe ObtenerSerie(int codigoSerie, SqlConnection cn)
        {
            SerieBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_serie_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoSerie", codigoSerie.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new SerieBe();

                            if (dr.Read())
                            {
                                item.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.Serial = dr.GetData<string>("Serial");
                                item.ValorInicial = dr.GetData<int>("ValorInicial");
                                item.ValorFinal = dr.GetData<int>("ValorFinal");
                                item.ValorActual = dr.GetData<int>("ValorActual");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool ExisteSerie(string serial, int codigoTipoComprobante, int? codigoSerie, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_serie_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@serial", serial.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoComprobante", codigoTipoComprobante.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoSerie", codigoSerie.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarSerie(SerieBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_serie_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoSerie", registro.CodigoSerie.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoComprobante", registro.CodigoTipoComprobante.GetNullable());
                    cmd.Parameters.AddWithValue("@serial", registro.Serial.GetNullable());
                    cmd.Parameters.AddWithValue("@valorInicial", registro.ValorInicial.GetNullable());
                    cmd.Parameters.AddWithValue("@valorFinal", registro.ValorFinal.GetNullable());
                    cmd.Parameters.AddWithValue("@valorActual", registro.ValorActual.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarFlagActivoSerie(SerieBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_serie_cambiar_flagactivo", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoSerie", registro.CodigoSerie.GetNullable());
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
