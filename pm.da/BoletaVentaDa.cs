﻿using pm.be;
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
    public class BoletaVentaDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<BoletaVentaBe> BuscarBoletaVenta(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, int? codigoSerie, string numero, string nroDocIdentidadCliente, string nombresCliente, bool flagActivo, SqlConnection cn)
        {
            List<BoletaVentaBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_boletaventa_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaEmisionDesde", fechaEmisionDesde.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaEmisionHasta", fechaEmisionHasta.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoSerie", codigoSerie.GetNullable());
                    cmd.Parameters.AddWithValue("@numero", numero.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidadCliente", nroDocIdentidadCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombresCliente", nombresCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<BoletaVentaBe>();

                            while (dr.Read())
                            {
                                BoletaVentaBe item = new BoletaVentaBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoBoletaVenta = dr.GetData<int>("CodigoBoletaVenta");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.FechaHoraVencimiento = dr.GetData<DateTime>("FechaHoraVencimiento");
                                item.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.Serie = new SerieBe();
                                item.Serie.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.Serie.Serial = dr.GetData<string>("SerialSerie");
                                item.NroComprobante = dr.GetData<int>("NroComprobante");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.Cliente = new ClienteBe();
                                item.Cliente.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.Cliente.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadCliente");
                                item.Cliente.TipoDocumentoIdentidad = new TipoDocumentoIdentidadBe();
                                item.Cliente.TipoDocumentoIdentidad.CodigoTipoDocumentoIdentidad = dr.GetData<int>("CodigoTipoDocumentoIdentidadCliente");
                                item.Cliente.TipoDocumentoIdentidad.Descripcion = dr.GetData<string>("DescripcionTipoDocumentoIdentidadCliente");
                                item.Cliente.NroDocumentoIdentidad = dr.GetData<string>("NroDocumentoIdentidadCliente");
                                item.Cliente.Nombres = dr.GetData<string>("NombresCliente");
                                item.Cliente.FlagActivo = dr.GetData<bool>("FlagActivoCliente");
                                item.NroDocumentoIdentidadCliente = dr.GetData<string>("NroDocumentoIdentidadCliente");
                                item.DescripcionTipoDocumentoIdentidadCliente = dr.GetData<string>("DescripcionTipoDocumentoIdentidadCliente");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");
                                item.FlagEmitido = dr.GetData<bool>("FlagEmitido");
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

        public BoletaVentaBe ObtenerBoletaVenta(int codigoBoletaVenta, SqlConnection cn)
        {
            BoletaVentaBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_boletaventa_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoBoletaVenta", codigoBoletaVenta.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new BoletaVentaBe();

                            if (dr.Read())
                            {
                                item.CodigoBoletaVenta = dr.GetData<int>("CodigoBoletaVenta");
                                item.CodigoSerie = dr.GetData<int>("CodigoSerie");
                                item.NroComprobante = dr.GetData<int>("NroComprobante");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.FechaHoraVencimiento = dr.GetData<DateTime>("FechaHoraVencimiento");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.DireccionCliente = dr.GetData<string>("DireccionCliente");
                                item.NombrePaisCliente = dr.GetData<string>("NombrePaisCliente");
                                item.NombreDepartamentoCliente = dr.GetData<string>("NombreDepartamentoCliente");
                                item.NombreProvinciaCliente = dr.GetData<string>("NombreProvinciaCliente");
                                item.NombreDistritoCliente = dr.GetData<string>("NombreDistritoCliente");
                                item.CodigoDistritoCliente = dr.GetData<int>("CodigoDistritoCliente");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.TotalOperacionGravada = dr.GetData<decimal>("TotalOperacionGravada");
                                item.TotalOperacionInafecta = dr.GetData<decimal>("TotalOperacionInafecta");
                                item.TotalOperacionExonerada = dr.GetData<decimal>("TotalOperacionExonerada");
                                item.TotalOperacionExportacion = dr.GetData<decimal>("TotalOperacionExportacion");
                                item.TotalOperacionGratuita = dr.GetData<decimal>("TotalOperacionGratuita");
                                item.TotalIgv = dr.GetData<decimal>("TotalIgv");
                                item.TotalIsc = dr.GetData<decimal>("TotalIsc");
                                item.TotalOtrosCargos = dr.GetData<decimal>("TotalOtrosCargos");
                                item.TotalOtrosTributos = dr.GetData<decimal>("TotalOtrosTributos");
                                item.TotalIcbper = dr.GetData<decimal>("TotalIcbper");
                                item.TotalDescuentoDetallado = dr.GetData<decimal>("TotalDescuentoDetallado");
                                item.TotalPorcentajeDescuentoGlobal = dr.GetData<decimal>("TotalPorcentajeDescuentoGlobal");
                                item.TotalDescuentoGlobal = dr.GetData<decimal>("TotalDescuentoGlobal");
                                item.TotalImporte = dr.GetData<decimal>("TotalImporte");
                                item.TotalPercepcion = dr.GetData<decimal>("TotalPercepcion");
                                item.TotalPagar = dr.GetData<decimal>("TotalPagar");
                                item.FlagEmitido = dr.GetData<bool>("FlagEmitido");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool GuardarBoletaVenta(BoletaVentaBe registro, SqlConnection cn, out int codigoBoletaVenta, out int nroComprobante)
        {
            codigoBoletaVenta = 0;
            nroComprobante = 0;
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_boletaventa_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@codigoBoletaVenta", Value = registro.CodigoBoletaVenta.GetNullable(), Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.AddWithValue("@codigoSerie", registro.CodigoSerie.GetNullable());
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@nroComprobante", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output });
                    cmd.Parameters.AddWithValue("@fechaHoraEmision", registro.FechaHoraEmision.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaHoraVencimiento", registro.FechaHoraVencimiento.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCliente", registro.CodigoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@direccionCliente", registro.DireccionCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombrePaisCliente", registro.NombrePaisCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreDepartamentoCliente", registro.NombreDepartamentoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreProvinciaCliente", registro.NombreProvinciaCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreDistritoCliente", registro.NombreDistritoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoDistritoCliente", registro.CodigoDistritoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMoneda", registro.CodigoMoneda.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOperacionGravada", registro.TotalOperacionGravada.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOperacionInafecta", registro.TotalOperacionInafecta.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOperacionExonerada", registro.TotalOperacionExonerada.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOperacionExportacion", registro.TotalOperacionExportacion.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOperacionGratuita", registro.TotalOperacionGratuita.GetNullable());
                    cmd.Parameters.AddWithValue("@totalValorVenta", registro.TotalValorVenta.GetNullable());
                    cmd.Parameters.AddWithValue("@totalIgv", registro.TotalIgv.GetNullable());
                    cmd.Parameters.AddWithValue("@totalIsc", registro.TotalIsc.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOtrosCargos", registro.TotalOtrosCargos.GetNullable());
                    cmd.Parameters.AddWithValue("@totalOtrosTributos", registro.TotalOtrosTributos.GetNullable());
                    cmd.Parameters.AddWithValue("@totalIcbper", registro.TotalIcbper.GetNullable());
                    cmd.Parameters.AddWithValue("@totalDescuentoDetallado", registro.TotalDescuentoDetallado.GetNullable());
                    cmd.Parameters.AddWithValue("@totalPorcentajeDescuentoGlobal", registro.TotalPorcentajeDescuentoGlobal.GetNullable());
                    cmd.Parameters.AddWithValue("@totalDescuentoGlobal", registro.TotalDescuentoGlobal.GetNullable());
                    cmd.Parameters.AddWithValue("@totalPrecioVenta", registro.TotalPrecioVenta.GetNullable());
                    cmd.Parameters.AddWithValue("@totalImporte", registro.TotalImporte.GetNullable());
                    cmd.Parameters.AddWithValue("@totalPercepcion", registro.TotalPercepcion.GetNullable());
                    cmd.Parameters.AddWithValue("@totalPagar", registro.TotalPagar.GetNullable());
                    cmd.Parameters.AddWithValue("@flagEmitido", registro.FlagEmitido.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;

                    if (seGuardo)
                    {
                        codigoBoletaVenta = (int)cmd.Parameters["@codigoBoletaVenta"].Value;
                        nroComprobante = (int)cmd.Parameters["@nroComprobante"].Value;
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }
    }
}
