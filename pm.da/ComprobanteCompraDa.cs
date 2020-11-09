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
    public class ComprobanteCompraDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<ComprobanteCompraBe> BuscarComprobanteCompra(DateTime? fechaCompraDesde, DateTime? fechaCompraHasta, string serie, string numero, string nroDocIdentidadProveedor, string nombresProveedor, bool flagActivo, SqlConnection cn)
        {
            List<ComprobanteCompraBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantecompra_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaCompraDesde", fechaCompraDesde.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaCompraHasta", fechaCompraHasta.GetNullable());
                    cmd.Parameters.AddWithValue("@serie", serie.GetNullable());
                    cmd.Parameters.AddWithValue("@numero", numero.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidadProveedor", nroDocIdentidadProveedor.GetNullable());
                    cmd.Parameters.AddWithValue("@nombresProveedor", nombresProveedor.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<ComprobanteCompraBe>();

                            while (dr.Read())
                            {
                                ComprobanteCompraBe item = new ComprobanteCompraBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoComprobanteCompra = dr.GetData<int>("CodigoComprobanteCompra");
                                item.FechaHoraRegistro = dr.GetData<DateTime>("FechaHoraRegistro");
                                item.FechaCompra = dr.GetData<DateTime>("FechaCompra");
                                item.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.TipoComprobante = new TipoComprobanteBe();
                                item.TipoComprobante.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.TipoComprobante.Nombre = dr.GetData<string>("NombreTipoComprobante");
                                item.Serie = dr.GetData<string>("Serie");
                                item.Numero = dr.GetData<int>("Numero");
                                item.CodigoProveedor = dr.GetData<int>("CodigoProveedor");
                                item.Proveedor = new ProveedorBe();
                                item.Proveedor.CodigoProveedor = dr.GetData<int>("CodigoProveedor");
                                item.Proveedor.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadProveedor");
                                item.Proveedor.TipoDocumentoIdentidad = new TipoDocumentoIdentidadBe();
                                item.Proveedor.TipoDocumentoIdentidad.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadProveedor");
                                item.Proveedor.TipoDocumentoIdentidad.Descripcion = dr.GetData<string>("DescripcionTipoDocumentoIdentidadProveedor");
                                item.Proveedor.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidadProveedor");
                                item.Proveedor.Nombres = dr.GetData<string>("NombresProveedor");
                                item.Proveedor.FlagActivo = dr.GetData<bool>("FlagActivoProveedor");
                                item.DescripcionTipoDocumentoIdentidadProveedor = dr.GetData<string>("DescripcionTipoDocumentoIdentidadProveedor");
                                item.NroDocumentoIdentidadProveedor = dr.GetData<string>("NroDocumentoIdentidadProveedor");
                                item.SerieGuia = dr.GetData<string>("SerieGuia");
                                item.NumeroGuia = dr.GetData<int>("NumeroGuia");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");
                                item.FlagCompleto = dr.GetData<bool>("FlagCompleto");
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

        public ComprobanteCompraBe ObtenerComprobanteCompra(int codigoComprobanteCompra, SqlConnection cn)
        {
            ComprobanteCompraBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantecompra_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoComprobanteCompra", codigoComprobanteCompra.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new ComprobanteCompraBe();

                            if (dr.Read())
                            {
                                item.CodigoComprobanteCompra = dr.GetData<int>("CodigoComprobanteCompra");
                                item.FechaHoraRegistro = dr.GetData<DateTime>("FechaHoraRegistro");
                                item.FechaCompra = dr.GetData<DateTime>("FechaCompra");
                                item.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobante");
                                item.Serie = dr.GetData<string>("Serie");
                                item.Numero = dr.GetData<int>("Numero");
                                item.CodigoProveedor = dr.GetData<int>("CodigoProveedor");
                                item.SerieGuia = dr.GetData<string>("SerieGuia");
                                item.NumeroGuia = dr.GetData<int>("NumeroGuia");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool GuardarComprobanteCompra(ComprobanteCompraBe registro, SqlConnection cn, out int codigoComprobanteCompra, out int nroComprobante)
        {
            codigoComprobanteCompra = 0;
            nroComprobante = 0;
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_comprobantecompra_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@codigoComprobanteCompra", Value = registro.CodigoComprobanteCompra.GetNullable(), Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@fechaHoraRegistro", registro.FechaHoraRegistro.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaCompra", registro.FechaCompra.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoComprobante", registro.CodigoTipoComprobante.GetNullable());
                    cmd.Parameters.AddWithValue("@serie", registro.Serie.GetNullable());
                    cmd.Parameters.AddWithValue("@numero", registro.Numero.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoProveedor", registro.CodigoProveedor.GetNullable());
                    cmd.Parameters.AddWithValue("@serieGuia", registro.SerieGuia.GetNullable());
                    cmd.Parameters.AddWithValue("@numeroGuia", registro.NumeroGuia.GetNullable());
                    cmd.Parameters.AddWithValue("@totalImporte", registro.TotalImporte.GetNullable());
                    cmd.Parameters.AddWithValue("@flagCompleto", registro.FlagCompleto.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;

                    if (seGuardo)
                    {
                        codigoComprobanteCompra = (int)cmd.Parameters["@codigoComprobanteCompra"].Value;
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }
    }
}
