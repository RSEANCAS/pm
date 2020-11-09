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
    public class NotaDebitoDetalleDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bool GuardarNotaDebitoDetalle(NotaDebitoDetalleBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_notadebitodetalle_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoNotaDebito", registro.CodigoNotaDebito.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoNotaDebitoDetalle", registro.CodigoNotaDebitoDetalle.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProducto", registro.CodigoProducto.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProductoIndividual", registro.CodigoProductoIndividual.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoUnidadMedida", registro.CodigoUnidadMedida.GetNullable());
                    cmd.Parameters.AddWithValue("@detalle", registro.Detalle.GetNullable());
                    cmd.Parameters.AddWithValue("@cantidad", registro.Cantidad.GetNullable());
                    cmd.Parameters.AddWithValue("@tipoCalculo", registro.TipoCalculo.GetNullable());
                    cmd.Parameters.AddWithValue("@valorUnitario", registro.ValorUnitario.GetNullable());
                    cmd.Parameters.AddWithValue("@precioUnitario", registro.PrecioUnitario.GetNullable());
                    cmd.Parameters.AddWithValue("@valorVenta", registro.ValorVenta.GetNullable());
                    cmd.Parameters.AddWithValue("@precioVenta", registro.PrecioVenta.GetNullable());
                    cmd.Parameters.AddWithValue("@igv", registro.Igv.GetNullable());
                    cmd.Parameters.AddWithValue("@isc", registro.Isc.GetNullable());
                    cmd.Parameters.AddWithValue("@tipoDescuento", registro.TipoDescuento.GetNullable());
                    cmd.Parameters.AddWithValue("@porcentajeDescuento", registro.PorcentajeDescuento.GetNullable());
                    cmd.Parameters.AddWithValue("@descuento", registro.Descuento.GetNullable());
                    cmd.Parameters.AddWithValue("@otrosCargos", registro.OtrosCargos.GetNullable());
                    cmd.Parameters.AddWithValue("@otrosTributos", registro.OtrosTributos.GetNullable());
                    cmd.Parameters.AddWithValue("@baseImponible", registro.BaseImponible.GetNullable());
                    cmd.Parameters.AddWithValue("@importe", registro.Importe.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoComprobanteRef", registro.CodigoTipoComprobanteRef.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoComprobanteRef", registro.CodigoComprobanteRef.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoComprobanteDetalleRef", registro.CodigoComprobanteDetalleRef.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public List<NotaDebitoDetalleBe> ListarNotaDebitoDetalle(int codigoNotaDebito, SqlConnection cn)
        {
            List<NotaDebitoDetalleBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_notadebitodetalle_listar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoNotaDebito", codigoNotaDebito.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<NotaDebitoDetalleBe>();

                            while (dr.Read())
                            {
                                NotaDebitoDetalleBe item = new NotaDebitoDetalleBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoNotaDebito = dr.GetData<int>("CodigoNotaDebito");
                                item.CodigoNotaDebitoDetalle = dr.GetData<int>("CodigoNotaDebitoDetalle");
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
                                item.ValorUnitario = dr.GetData<decimal>("ValorUnitario");
                                item.PrecioUnitario = dr.GetData<decimal>("PrecioUnitario");
                                item.ValorVenta = dr.GetData<decimal>("ValorVenta");
                                item.PrecioVenta = dr.GetData<decimal>("PrecioVenta");
                                item.Igv = dr.GetData<decimal>("Igv");
                                item.Isc = dr.GetData<decimal>("Isc");
                                item.PorcentajeDescuento = dr.GetData<decimal>("PorcentajeDescuento");
                                item.Descuento = dr.GetData<decimal>("Descuento");
                                item.OtrosCargos = dr.GetData<decimal>("OtrosCargos");
                                item.OtrosTributos = dr.GetData<decimal>("OtrosTributos");
                                item.BaseImponible = dr.GetData<decimal>("BaseImponible");
                                item.Importe = dr.GetData<decimal>("Importe");
                                item.CodigoTipoComprobanteRef = dr.GetData<int>("CodigoTipoComprobanteRef");
                                item.CodigoComprobanteRef = dr.GetData<int>("CodigoComprobanteRef");
                                item.CodigoComprobanteDetalleRef = dr.GetData<int>("CodigoComprobanteDetalleRef");
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

        public bool EliminarNotaDebitoDetalle(int codigoNotaDebitoDetalle, string usuarioModi, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_notadebitodetalle_eliminar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoNotaDebitoDetalle", codigoNotaDebitoDetalle.GetNullable());
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
