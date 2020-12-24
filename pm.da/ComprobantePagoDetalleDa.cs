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
    public class ComprobantePagoDetalleDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bool GuardarComprobantePagoDetalle(ComprobantePagoDetalleBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantepagodetalle_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoComprobantePago", registro.CodigoComprobantePago.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoComprobantePagoDetalle", registro.CodigoComprobantePagoDetalle.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoDocumentoPago", registro.CodigoTipoDocumentoPago.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoDocumentoPago", registro.CodigoDocumentoPago.GetNullable());
                    cmd.Parameters.AddWithValue("@descripcion", registro.Descripcion.GetNullable());
                    cmd.Parameters.AddWithValue("@monto", registro.Monto.GetNullable());
                    cmd.Parameters.AddWithValue("@mora", registro.Mora.GetNullable());
                    cmd.Parameters.AddWithValue("@protesto", registro.Protesto.GetNullable());
                    cmd.Parameters.AddWithValue("@total", registro.Total.GetNullable());
                    cmd.Parameters.AddWithValue("@importePagar", registro.ImportePagar.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public List<ComprobantePagoDetalleBe> ListarComprobantePagoDetalle(int codigoComprobantePago, SqlConnection cn)
        {
            List<ComprobantePagoDetalleBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantepagodetalle_listar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoComprobantePago", codigoComprobantePago.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<ComprobantePagoDetalleBe>();

                            while (dr.Read())
                            {
                                ComprobantePagoDetalleBe item = new ComprobantePagoDetalleBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoComprobantePago = dr.GetData<int>("CodigoComprobantePago");
                                item.CodigoComprobantePagoDetalle = dr.GetData<int>("CodigoComprobantePagoDetalle");
                                item.CodigoTipoDocumentoPago = dr.GetData<int>("CodigoTipoDocumentoPago");
                                item.CodigoDocumentoPago = dr.GetData<int>("CodigoDocumentoPago");
                                item.Monto = dr.GetData<decimal>("Monto");
                                item.Mora = dr.GetData<decimal>("Mora");
                                item.Protesto = dr.GetData<decimal>("Protesto");
                                item.Total = dr.GetData<decimal>("Total");
                                item.FlagEliminado = dr.GetData<bool>("FlagEliminado");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public bool EliminarComprobantePagoDetalle(int codigoComprobantePagoDetalle, string usuarioModi, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantepagodetalle_eliminar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoComprobantePagoDetalle", codigoComprobantePagoDetalle.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", usuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }
    }
}
