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
    public class CotizacionDetalleDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bool GuardarCotizacionDetalle(CotizacionDetalleBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_cotizaciondetalle_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoCotizacion", registro.CodigoCotizacion.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCotizacionDetalle", registro.CodigoCotizacionDetalle.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProducto", registro.CodigoProducto.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProductoIndividual", registro.CodigoProductoIndividual.GetNullable());
                    cmd.Parameters.AddWithValue("@detalle", registro.Detalle.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoUnidadMedida", registro.CodigoUnidadMedida.GetNullable());
                    cmd.Parameters.AddWithValue("@cantidad", registro.Cantidad.GetNullable());
                    cmd.Parameters.AddWithValue("@precioUnitario", registro.PrecioUnitario.GetNullable());
                    cmd.Parameters.AddWithValue("@importe", registro.Importe.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public List<CotizacionDetalleBe> ListarCotizacionDetalle(int codigoCotizacion, SqlConnection cn)
        {
            List<CotizacionDetalleBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_cotizaciondetalle_listar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoCotizacion", codigoCotizacion.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<CotizacionDetalleBe>();

                            while (dr.Read())
                            {
                                CotizacionDetalleBe item = new CotizacionDetalleBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoCotizacion = dr.GetData<int>("CodigoCotizacion");
                                item.CodigoCotizacionDetalle = dr.GetData<int>("CodigoCotizacionDetalle");
                                item.CodigoProducto = dr.GetData<int>("CodigoProducto");
                                item.Producto = new ProductoBe();
                                item.Producto.CodigoProducto = dr.GetData<int>("CodigoProducto");
                                item.Producto.Nombre = dr.GetData<string>("NombreProducto");
                                item.CodigoProductoIndividual = dr.GetData<int>("CodigoProductoIndividual");
                                item.ProductoIndividual = new ProductoIndividualBe();
                                item.ProductoIndividual.CodigoProductoIndividual = dr.GetData<int>("CodigoProductoIndividual");
                                item.ProductoIndividual.Nombre = dr.GetData<string>("NombreProductoIndividual");
                                item.Detalle = dr.GetData<string>("Detalle");
                                item.CodigoUnidadMedida = dr.GetData<int>("CodigoUnidadMedida");
                                item.Cantidad = dr.GetData<decimal>("Cantidad");
                                item.PrecioUnitario = dr.GetData<decimal>("PrecioUnitario");
                                item.Importe = dr.GetData<decimal>("Importe");
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

        public bool EliminarCotizacionDetalle(int codigoCotizacionDetalle, string usuarioModi, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_cotizaciondetalle_eliminar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoCotizacionDetalle", codigoCotizacionDetalle.GetNullable());
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
