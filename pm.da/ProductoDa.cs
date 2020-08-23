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
    public class ProductoDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ProductoBe> BuscarProducto(int? codigoProducto, string nombre, string color, int? estado, SqlConnection cn)
        {
            List<ProductoBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_producto_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoProducto", codigoProducto.GetNullable());
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@color", color.GetNullable());
                    cmd.Parameters.AddWithValue("@estado", estado.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<ProductoBe>();

                            while (dr.Read())
                            {
                                ProductoBe item = new ProductoBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoProducto = dr.GetData<int>("CodigoProducto");
                                item.Nombre = dr.GetData<string>("Nombre");
                                item.CodigoUnidadMedida = dr.GetData<int>("CodigoUnidadMedida");
                                item.UnidadMedida = new UnidadMedidaBe();
                                item.UnidadMedida.CodigoUnidadMedida = dr.GetData<int>("CodigoUnidadMedida");
                                item.UnidadMedida.Descripcion = dr.GetData<string>("DescripcionUnidadMedida");
                                item.UnidadMedida.FlagActivo = dr.GetData<bool>("FlagActivoUnidadMedida");
                                item.Cantidad = dr.GetData<decimal>("Cantidad");
                                item.ValorCompra = dr.GetData<decimal>("ValorCompra");
                                item.ValorVenta = dr.GetData<decimal>("ValorVenta");
                                item.DescuentoMaximo = dr.GetData<decimal>("DescuentoMaximo");
                                item.Color = dr.GetData<string>("Color");
                                item.MetrajeTotal = dr.GetData<decimal>("MetrajeTotal");
                                item.Estado = dr.GetData<int>("Estado");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public ProductoBe ObtenerProducto(int codigoProducto, SqlConnection cn)
        {
            ProductoBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_producto_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoProducto", codigoProducto.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new ProductoBe();

                            if (dr.Read())
                            {
                                item.CodigoProducto = dr.GetData<int>("CodigoProducto");
                                item.Nombre = dr.GetData<string>("Nombre");
                                item.CodigoUnidadMedida = dr.GetData<int>("CodigoUnidadMedida");
                                item.Cantidad = dr.GetData<decimal>("Cantidad");
                                item.ValorCompra = dr.GetData<decimal>("ValorCompra");
                                item.ValorVenta = dr.GetData<decimal>("ValorVenta");
                                item.DescuentoMaximo = dr.GetData<decimal>("DescuentoMaximo");
                                item.Color = dr.GetData<string>("Color");
                                item.MetrajeTotal = dr.GetData<decimal>("MetrajeTotal");
                                item.Estado = dr.GetData<int>("Estado");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool ExisteProducto(string nombre, int? codigoProducto, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_producto_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProducto", codigoProducto.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarProducto(ProductoBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_producto_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoProducto", registro.CodigoProducto.GetNullable());
                    cmd.Parameters.AddWithValue("@nombre", registro.Nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoUnidadMedida", registro.CodigoUnidadMedida.GetNullable());
                    cmd.Parameters.AddWithValue("@cantidad", registro.Cantidad.GetNullable());
                    cmd.Parameters.AddWithValue("@valorCompra", registro.ValorCompra.GetNullable());
                    cmd.Parameters.AddWithValue("@valorVenta", registro.ValorVenta.GetNullable());
                    cmd.Parameters.AddWithValue("@descuentoMaximo", registro.DescuentoMaximo.GetNullable());
                    cmd.Parameters.AddWithValue("@color", registro.Color.GetNullable());
                    cmd.Parameters.AddWithValue("@metrajeTotal", registro.MetrajeTotal.GetNullable());
                    cmd.Parameters.AddWithValue("@estado", registro.Estado.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarEstadoProducto(ProductoBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_producto_cambiar_estado", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoProducto", registro.CodigoProducto.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", registro.Estado.GetNullable());
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
