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
    public class GuiaRemisionDetalleDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bool GuardarGuiaRemisionDetalle(GuiaRemisionDetalleBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_guiaremisiondetalle_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoGuiaRemision", registro.CodigoGuiaRemision.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoGuiaRemisionDetalle", registro.CodigoGuiaRemisionDetalle.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProducto", registro.CodigoProducto.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProductoIndividual", registro.CodigoProductoIndividual.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoUnidadMedida", registro.CodigoUnidadMedida.GetNullable());
                    cmd.Parameters.AddWithValue("@detalle", registro.Detalle.GetNullable());
                    cmd.Parameters.AddWithValue("@cantidad", registro.Cantidad.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoUnidadMedidaPeso", registro.CodigoUnidadMedidaPeso.GetNullable());
                    cmd.Parameters.AddWithValue("@peso", registro.Peso.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCotizacion", registro.CodigoCotizacion.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCotizacionDetalle", registro.CodigoCotizacionDetalle.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public List<GuiaRemisionDetalleBe> ListarGuiaRemisionDetalle(int codigoGuiaRemision, SqlConnection cn)
        {
            List<GuiaRemisionDetalleBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_guiaremisiondetalle_listar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoGuiaRemision", codigoGuiaRemision.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<GuiaRemisionDetalleBe>();

                            while (dr.Read())
                            {
                                GuiaRemisionDetalleBe item = new GuiaRemisionDetalleBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoGuiaRemision = dr.GetData<int>("CodigoGuiaRemision");
                                item.CodigoGuiaRemisionDetalle = dr.GetData<int>("CodigoGuiaRemisionDetalle");
                                item.CodigoProducto = dr.GetData<int>("CodigoProducto");
                                item.Producto = new ProductoBe();
                                item.Producto.CodigoProducto = dr.GetData<int>("CodigoProducto");
                                item.Producto.Nombre = dr.GetData<string>("NombreProducto");
                                item.CodigoProductoIndividual = dr.GetData<int>("CodigoProductoIndividual");
                                item.ProductoIndividual = new ProductoIndividualBe();
                                item.ProductoIndividual.CodigoProductoIndividual = dr.GetData<int>("CodigoProductoIndividual");
                                item.ProductoIndividual.Nombre = dr.GetData<string>("NombreProductoIndividual");
                                item.CodigoUnidadMedida = dr.GetData<int>("CodigoUnidadMedida");
                                item.Detalle = dr.GetData<string>("Detalle");
                                item.Cantidad = dr.GetData<decimal>("Cantidad");
                                item.CodigoUnidadMedidaPeso = dr.GetData<int>("CodigoUnidadMedidaPeso");
                                item.Peso = dr.GetData<decimal>("Peso");
                                item.CodigoCotizacion = dr.GetData<int>("CodigoCotizacion");
                                item.CodigoCotizacionDetalle = dr.GetData<int>("CodigoCotizacionDetalle");
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

        public bool EliminarGuiaRemisionDetalle(int codigoGuiaRemisionDetalle, string usuarioModi, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_guiaremisiondetalle_eliminar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoGuiaRemisionDetalle", codigoGuiaRemisionDetalle.GetNullable());
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
