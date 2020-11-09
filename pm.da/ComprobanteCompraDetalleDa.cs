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
    public class ComprobanteCompraDetalleDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bool GuardarComprobanteCompraDetalle(ComprobanteCompraDetalleBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantecompradetalle_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoComprobanteCompra", registro.CodigoComprobanteCompra.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoComprobanteCompraDetalle", registro.CodigoComprobanteCompraDetalle.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProducto", registro.CodigoProducto.GetNullable());
                    cmd.Parameters.AddWithValue("@detalle", registro.Detalle.GetNullable());
                    cmd.Parameters.AddWithValue("@cantidad", registro.Cantidad.GetNullable());
                    cmd.Parameters.AddWithValue("@precioUnitario", registro.PrecioUnitario.GetNullable());
                    cmd.Parameters.AddWithValue("@importeTotal", registro.ImporteTotal.GetNullable());
                    cmd.Parameters.AddWithValue("@flagCompleto", registro.FlagCompleto.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public List<ComprobanteCompraDetalleBe> ListarComprobanteCompraDetalle(int codigoComprobanteCompra, SqlConnection cn)
        {
            List<ComprobanteCompraDetalleBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantecompradetalle_listar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoComprobanteCompra", codigoComprobanteCompra.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<ComprobanteCompraDetalleBe>();

                            while (dr.Read())
                            {
                                ComprobanteCompraDetalleBe item = new ComprobanteCompraDetalleBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoComprobanteCompra = dr.GetData<int>("CodigoComprobanteCompra");
                                item.CodigoComprobanteCompraDetalle = dr.GetData<int>("CodigoComprobanteCompraDetalle");
                                item.CodigoProducto = dr.GetData<int>("CodigoProducto");
                                item.Detalle = dr.GetData<string>("Detalle");
                                item.Cantidad = dr.GetData<int>("Cantidad");
                                item.PrecioUnitario = dr.GetData<decimal>("PrecioUnitario");
                                item.ImporteTotal = dr.GetData<decimal>("ImporteTotal");
                                item.FlagCompleto = dr.GetData<bool>("FlagCompleto");
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

        public bool EliminarComprobanteCompraDetalle(int codigoComprobanteCompraDetalle, string usuarioModi, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantecompradetalle_eliminar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoComprobanteCompraDetalle", codigoComprobanteCompraDetalle.GetNullable());
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
