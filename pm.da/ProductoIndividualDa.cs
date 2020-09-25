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
    public class ProductoIndividualDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ProductoIndividualBe> BuscarProductoIndividual(int? codigoProductoIndividual, string codigoBarra, int? codigoProducto, string nombre, string codigoInicial, string color, string nroDocumentoIdentidadProveedor, string nombresProveedor, DateTime fechaEntradaDesde, DateTime fechaEntradaHasta, string nroDocumentoIdentidadPersonalInspeccion, string nombresPersonalInspeccion, SqlConnection cn)
        {
            List<ProductoIndividualBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_productoindividual_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoProductoIndividual", codigoProductoIndividual.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoBarra", codigoBarra.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProducto", codigoProducto.GetNullable());
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoInicial", codigoInicial.GetNullable());
                    cmd.Parameters.AddWithValue("@color", color.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidadProveedor", nroDocumentoIdentidadProveedor.GetNullable());
                    cmd.Parameters.AddWithValue("@nombresProveedor", nombresProveedor.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaEntradaDesde", fechaEntradaDesde.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaEntradaHasta", fechaEntradaHasta.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidadPersonaInspeccion", nroDocumentoIdentidadPersonalInspeccion.GetNullable());
                    cmd.Parameters.AddWithValue("@nombresPersonalInspeccion", nombresPersonalInspeccion.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<ProductoIndividualBe>();

                            while (dr.Read())
                            {
                                ProductoIndividualBe item = new ProductoIndividualBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoProductoIndividual = dr.GetData<int>("CodigoProductoIndividual");
                                item.CodigoBarra = dr.GetData<string>("CodigoBarra");
                                item.CodigoProducto = dr.GetData<int>("CodigoProducto");
                                item.Nombre = dr.GetData<string>("Nombre");
                                item.CodigoUnidadMedida = dr.GetData<int>("CodigoUnidadMedida");
                                item.UnidadMedida = new UnidadMedidaBe();
                                item.UnidadMedida.CodigoUnidadMedida = dr.GetData<int>("CodigoUnidadMedida");
                                item.UnidadMedida.Descripcion = dr.GetData<string>("DescripcionUnidadMedida");
                                item.UnidadMedida.FlagActivo = dr.GetData<bool>("FlagActivoUnidadMedida");
                                item.Metraje = dr.GetData<decimal>("Metraje");
                                item.Peso = dr.GetData<decimal>("Peso");
                                item.CodigoInicial = dr.GetData<int?>("CodigoInicial");
                                item.Rollo = dr.GetData<decimal>("Rollo");
                                item.Bulto = dr.GetData<decimal>("Bulto");
                                item.Color = dr.GetData<string>("Color");
                                item.CodigoProveedor = dr.GetData<int>("CodigoProveedor");
                                item.Proveedor = new ProveedorBe();
                                item.Proveedor.CodigoProveedor = dr.GetData<int>("CodigoProveedor");
                                item.Proveedor.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadProveedor");
                                item.Proveedor.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidadProveedor");
                                item.Proveedor.Nombres = dr.GetData<string>("NombresProveedor");
                                item.Proveedor.Direccion = dr.GetData<string>("DireccionProveedor");
                                item.Proveedor.CodigoDistrito = dr.GetData<int>("CodigoDistritoProveedor");
                                item.Proveedor.Correo = dr.GetData<string>("CorreoProveedor");
                                item.Proveedor.Telefono = dr.GetData<string>("TelefonoProveedor");
                                item.Proveedor.Contacto = dr.GetData<string>("ContactoProveedor");
                                item.Proveedor.FlagActivo = dr.GetData<bool>("FlagActivoProveedor");
                                item.CodigoBarraProveedor = dr.GetData<string>("CodigoBarraProveedor");
                                item.FechaEntrada = dr.GetData<DateTime>("FechaEntrada");
                                item.CodigoPersonalInspeccion = dr.GetData<int>("CodigoPersonalInspeccion");
                                item.PersonalInspeccion = new PersonalBe();
                                item.PersonalInspeccion.CodigoPersonal = dr.GetData<int>("CodigoPersonalInspeccion");
                                item.PersonalInspeccion.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadPersonalInspeccion");
                                item.PersonalInspeccion.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidadPersonalInspeccion");
                                item.PersonalInspeccion.Nombres = dr.GetData<string>("NombresPersonalInspeccion");
                                item.PersonalInspeccion.Correo = dr.GetData<string>("CorreoPersonalInspeccion");
                                item.PersonalInspeccion.CodigoArea = dr.GetData<int>("CodigoAreaPersonalInspeccion");
                                item.PersonalInspeccion.FlagActivo = dr.GetData<bool>("FlagActivoPersonalInspeccion");
                                item.PersonalInspeccion.Estado = dr.GetData<int>("EstadoPersonalInspeccion");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public ProductoIndividualBe ObtenerProductoIndividual(int codigoProductoIndividual, SqlConnection cn)
        {
            ProductoIndividualBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_productoindividual_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoProductoIndividual", codigoProductoIndividual.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new ProductoIndividualBe();

                            if (dr.Read())
                            {
                                item.CodigoProductoIndividual = dr.GetData<int>("CodigoProductoIndividual");
                                item.CodigoBarra = dr.GetData<string>("CodigoBarra");
                                item.CodigoProducto = dr.GetData<int>("CodigoProducto");
                                item.Nombre = dr.GetData<string>("Nombre");
                                item.CodigoUnidadMedida = dr.GetData<int>("CodigoUnidadMedida");
                                item.Metraje = dr.GetData<decimal>("Metraje");
                                item.Peso = dr.GetData<decimal>("Peso");
                                item.CodigoInicial = dr.GetData<int?>("CodigoInicial");
                                item.Rollo = dr.GetData<decimal>("Rollo");
                                item.Bulto = dr.GetData<decimal>("Bulto");
                                item.Color = dr.GetData<string>("Color");
                                item.CodigoProveedor = dr.GetData<int>("CodigoProveedor");
                                item.CodigoBarraProveedor = dr.GetData<string>("CodigoBarraProveedor");
                                item.FechaEntrada = dr.GetData<DateTime>("FechaEntrada");
                                item.CodigoPersonalInspeccion = dr.GetData<int>("CodigoPersonalInspeccion");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool ExisteProductoIndividual(string codigoBarra, string nombre, int? codigoProductoIndividual, SqlConnection cn, out bool flagCodigoBarraExiste, out bool flagNombreExiste)
        {
            flagCodigoBarraExiste = false;
            flagNombreExiste = false;
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_productoindividual_existe", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoProductoIndividual", codigoProductoIndividual.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoBarra", codigoBarra.GetNullable());
                    cmd.Parameters.AddWithValue("@nombre", nombre.GetNullable());

                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@flagCodigoBarraExiste", Value = false, Direction = ParameterDirection.Output });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@flagNombreExiste", Value = false, Direction = ParameterDirection.Output });

                    existe = (bool)cmd.ExecuteScalar();

                    if (existe)
                    {
                        flagCodigoBarraExiste = (bool)cmd.Parameters["@flagCodigoBarraExiste"].Value;
                        flagNombreExiste = (bool)cmd.Parameters["@flagNombreExiste"].Value;
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }

        public bool GuardarProductoIndividual(ProductoIndividualBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_productoindividual_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoProductoIndividual", registro.CodigoProductoIndividual.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoBarra", registro.CodigoBarra.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProducto", registro.CodigoProducto.GetNullable());
                    cmd.Parameters.AddWithValue("@nombre", registro.Nombre.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoUnidadMedida", registro.CodigoUnidadMedida.GetNullable());
                    cmd.Parameters.AddWithValue("@metraje", registro.Metraje.GetNullable());
                    cmd.Parameters.AddWithValue("@peso", registro.Peso.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoInicial", registro.CodigoInicial.GetNullable());
                    cmd.Parameters.AddWithValue("@rollo", registro.Rollo.GetNullable());
                    cmd.Parameters.AddWithValue("@bulto", registro.Bulto.GetNullable());
                    cmd.Parameters.AddWithValue("@color", registro.Color.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProveedor", registro.CodigoProveedor.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoBarraProveedor", registro.CodigoBarraProveedor.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaEntrada", registro.FechaEntrada.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoPersonalInspeccion", registro.CodigoPersonalInspeccion.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        //public bool CambiarEstadoProductoIndividual(ProductoIndividualBe registro, SqlConnection cn)
        //{
        //    bool seGuardo = false;

        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("dbo.usp_productoindividual_cambiar_estado", cn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@codigoProductoIndividual", registro.CodigoProductoIndividual.GetNullable());
        //            cmd.Parameters.AddWithValue("@flagActivo", registro.Estado.GetNullable());
        //            cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

        //            int filasAfectadas = cmd.ExecuteNonQuery();

        //            seGuardo = filasAfectadas > 0;
        //        }
        //    }
        //    catch (Exception ex) { log.Error(ex.Message); }

        //    return seGuardo;
        //}
    }
}
