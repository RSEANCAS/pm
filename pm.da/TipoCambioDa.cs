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
    public class TipoCambioDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<TipoCambioBe> BuscarTipoCambio(DateTime? fechaCambioDesde, DateTime? fechaCambioHasta, SqlConnection cn)
        {
            List<TipoCambioBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_tipocambio_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaCambioDesde", fechaCambioDesde.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaCambioHasta", fechaCambioHasta.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<TipoCambioBe>();

                            while (dr.Read())
                            {
                                TipoCambioBe item = new TipoCambioBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoTipoCambio = dr.GetData<int>("CodigoTipoCambio");
                                item.FechaCambio = dr.GetData<DateTime>("FechaCambio");
                                item.ValorCompra = dr.GetData<decimal>("ValorCompra");
                                item.ValorVenta = dr.GetData<decimal>("ValorVenta");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public TipoCambioBe ObtenerTipoCambio(int codigoTipoCambio, SqlConnection cn)
        {
            TipoCambioBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_tipocambio_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoTipoCambio", codigoTipoCambio.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new TipoCambioBe();

                            if (dr.Read())
                            {
                                item.CodigoTipoCambio = dr.GetData<int>("CodigoTipoCambio");
                                item.FechaCambio = dr.GetData<DateTime>("FechaCambio");
                                item.ValorCompra = dr.GetData<decimal>("ValorCompra");
                                item.ValorVenta = dr.GetData<decimal>("ValorVenta");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public TipoCambioBe ObtenerTipoCambioPorFechaCambio(DateTime fechaCambio, SqlConnection cn)
        {
            TipoCambioBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_tipocambio_obtener_x_fechacambio", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaCambio", fechaCambio.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new TipoCambioBe();

                            if (dr.Read())
                            {
                                item.CodigoTipoCambio = dr.GetData<int>("CodigoTipoCambio");
                                item.FechaCambio = dr.GetData<DateTime>("FechaCambio");
                                item.ValorCompra = dr.GetData<decimal>("ValorCompra");
                                item.ValorVenta = dr.GetData<decimal>("ValorVenta");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool ExisteTipoCambio(DateTime fechaCambio, int? codigoTipoCambio, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_tipocambio_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaCambio", fechaCambio.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoCambio", codigoTipoCambio.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarTipoCambio(TipoCambioBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_tipocambio_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoTipoCambio", registro.CodigoTipoCambio.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaCambio", registro.FechaCambio.GetNullable());
                    cmd.Parameters.AddWithValue("@valorCompra", registro.ValorCompra.GetNullable());
                    cmd.Parameters.AddWithValue("@valorVenta", registro.ValorVenta.GetNullable());
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
