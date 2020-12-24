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
    public class LetraDa
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public List<LetraBe> ListarLetraPorRef(int codigoTipoComprobanteRef, int codigoSerieRef, int numeroRef, SqlConnection cn)
        {
            List<LetraBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_listar_x_ref", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoTipoComprobanteRef", codigoTipoComprobanteRef.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoSerieRef", codigoSerieRef.GetNullable());
                    cmd.Parameters.AddWithValue("@numeroRef", numeroRef.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<LetraBe>();

                            while (dr.Read())
                            {
                                LetraBe item = new LetraBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoLetra = dr.GetData<int>("CodigoLetra");
                                item.Numero = dr.GetData<int>("Numero");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.FechaVencimiento = dr.GetData<DateTime>("FechaVencimiento");
                                item.CodigoTipoComprobanteRef = dr.GetData<int>("CodigoTipoComprobanteRef");
                                item.CodigoComprobanteRef = dr.GetData<int>("CodigoComprobanteRef");
                                item.CodigoSerieComprobanteRef = dr.GetData<int>("CodigoSerieComprobanteRef");
                                item.SerialSerieComprobanteRef = dr.GetData<string>("SerialSerieComprobanteRef");
                                item.NroComprobanteComprobanteRef = dr.GetData<int>("NroComprobanteComprobanteRef");
                                item.CodigoGuiaRemision = dr.GetData<int>("CodigoGuiaRemision");
                                item.CodigoSerieGuiaRemision = dr.GetData<int>("CodigoSerieGuiaRemision");
                                item.SerialSerieGuiaRemision = dr.GetData<string>("SerialSerieGuiaRemision");
                                item.NroComprobanteGuiaRemision = dr.GetData<int>("NroComprobanteGuiaRemision");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.CodigoBanco = dr.GetData<int>("CodigoBanco");
                                item.CodigoUnicoBanco = dr.GetData<string>("CodigoUnicoBanco");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.Monto = dr.GetData<decimal>("Monto");
                                item.Estado = dr.GetData<int?>("Estado");
                                item.FlagCancelado = dr.GetData<bool>("FlagCancelado");

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public List<LetraBe> BuscarLetra(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, string numero, string nroDocIdentidadCliente, string nombresCliente, int? estado, bool flagCancelado, bool flagActivo, SqlConnection cn)
        {
            List<LetraBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_buscar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaEmisionDesde", fechaEmisionDesde.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaEmisionHasta", fechaEmisionHasta.GetNullable());
                    cmd.Parameters.AddWithValue("@numero", numero.GetNullable());
                    cmd.Parameters.AddWithValue("@nroDocumentoIdentidadCliente", nroDocIdentidadCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@nombresCliente", nombresCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@estado", estado.GetNullable());
                    cmd.Parameters.AddWithValue("@flagCancelado", flagCancelado.GetNullable());
                    cmd.Parameters.AddWithValue("@flagActivo", flagActivo.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<LetraBe>();

                            while (dr.Read())
                            {
                                LetraBe item = new LetraBe();
                                item.Fila = dr.GetData<int>("Fila");
                                item.CodigoLetra = dr.GetData<int>("CodigoLetra");
                                item.Numero = dr.GetData<int>("Numero");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.FechaVencimiento = dr.GetData<DateTime>("FechaVencimiento");
                                item.Dias = dr.GetData<int>("Dias");
                                item.CodigoTipoComprobanteRef = dr.GetData<int>("CodigoTipoComprobanteRef");
                                item.TipoComprobanteRef = new TipoComprobanteBe();
                                item.TipoComprobanteRef.CodigoTipoComprobante = dr.GetData<int>("CodigoTipoComprobanteRef");
                                item.TipoComprobanteRef.Nombre = dr.GetData<string>("NombreTipoComprobanteRef");
                                item.CodigoComprobanteRef = dr.GetData<int>("CodigoComprobanteRef");
                                item.CodigoSerieComprobanteRef = dr.GetData<int>("CodigoSerieComprobanteRef");
                                item.SerialSerieComprobanteRef = dr.GetData<string>("SerialSerieComprobanteRef");
                                item.NroComprobanteComprobanteRef = dr.GetData<int>("NroComprobanteComprobanteRef");
                                item.CodigoGuiaRemision = dr.GetData<int?>("CodigoGuiaRemision");
                                item.CodigoSerieGuiaRemision = dr.GetData<int?>("CodigoSerieGuiaRemision");
                                item.SerialSerieGuiaRemision = dr.GetData<string>("SerialSerieGuiaRemision");
                                item.NroComprobanteGuiaRemision = dr.GetData<int?>("NroComprobanteGuiaRemision");
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
                                item.CodigoUnicoBanco = dr.GetData<string>("CodigoUnicoBanco");
                                item.CodigoBanco = dr.GetData<int?>("CodigoBanco");
                                if (item.CodigoBanco.HasValue)
                                {
                                    item.Banco = new BancoBe();
                                    item.Banco.CodigoBanco = dr.GetData<int>("CodigoBanco");
                                    item.Banco.Nombre = dr.GetData<string>("NombreBanco");
                                }
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.Monto = dr.GetData<decimal>("Monto");
                                item.Mora = dr.GetData<decimal>("Mora");
                                item.Protesto = dr.GetData<decimal>("Protesto");
                                item.Estado = dr.GetData<int>("Estado");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                                item.FlagCancelado = dr.GetData<bool>("FlagCancelado");
                                item.CodigoLetraPadre = dr.GetData<int?>("CodigoLetraPadre");
                                if (item.CodigoLetraPadre.HasValue)
                                {
                                    item.LetraPadre = new LetraBe();
                                    item.LetraPadre.Numero = dr.GetData<int>("NumeroLetraPadre");
                                    item.LetraPadre.Monto = dr.GetData<decimal>("MontoLetraPadre");
                                    item.LetraPadre.Mora = dr.GetData<decimal>("MoraLetraPadre");
                                    item.LetraPadre.Protesto = dr.GetData<decimal>("ProtestoLetraPadre");
                                }
                                item.CodigoLetraInicial = dr.GetData<int?>("CodigoLetraInicial");
                                if (item.CodigoLetraInicial.HasValue)
                                {
                                    item.LetraInicial = new LetraBe();
                                    item.LetraInicial.Numero = dr.GetData<int>("NumeroLetraInicial");
                                    item.LetraInicial.Monto = dr.GetData<decimal>("MontoLetraInicial");
                                    item.LetraInicial.Mora = dr.GetData<decimal>("MoraLetraInicial");
                                    item.LetraInicial.Protesto = dr.GetData<decimal>("ProtestoLetraInicial");
                                }

                                resultados.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return resultados;
        }

        public List<LetraBe> ListarLetraPorCodigoLetraInicial(int codigoLetraInicial, SqlConnection cn)
        {
            List<LetraBe> resultados = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_listar_x_codigoletrainicial", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoLetraInicial", codigoLetraInicial.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            resultados = new List<LetraBe>();

                            while (dr.Read())
                            {
                                LetraBe item = new LetraBe();

                                item.CodigoLetra = dr.GetData<int>("CodigoLetra");
                                item.Numero = dr.GetData<int>("Numero");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.FechaVencimiento = dr.GetData<DateTime>("FechaVencimiento");
                                item.Dias = dr.GetData<int>("Dias");
                                item.CodigoTipoComprobanteRef = dr.GetData<int>("CodigoTipoComprobanteRef");
                                item.CodigoComprobanteRef = dr.GetData<int>("CodigoComprobanteRef");
                                item.CodigoGuiaRemision = dr.GetData<int>("CodigoGuiaRemision");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.CodigoBanco = dr.GetData<int>("CodigoBanco");
                                item.CodigoUnicoBanco = dr.GetData<string>("CodigoUnicoBanco");
                                item.Monto = dr.GetData<decimal>("Monto");
                                item.Mora = dr.GetData<decimal>("Mora");
                                item.Protesto = dr.GetData<decimal>("Protesto");
                                item.Estado = dr.GetData<int>("Estado");
                                item.CodigoLetraPadre = dr.GetData<int?>("CodigoLetraPadre");
                                item.CodigoLetraInicial = dr.GetData<int?>("CodigoLetraInicial");
                                item.FlagAval = dr.GetData<bool>("FlagAval");
                                item.DireccionAval = dr.GetData<string>("DireccionAval");
                                item.NombrePaisAval = dr.GetData<string>("NombrePaisAval");
                                item.NombreDepartamentoAval = dr.GetData<string>("NombreDepartamentoAval");
                                item.NombreProvinciaAval = dr.GetData<string>("NombreProvinciaAval");
                                item.NombreDistritoAval = dr.GetData<string>("NombreDistritoAval");
                                item.FlagCancelado = dr.GetData<bool>("FlagCancelado");
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

        public LetraBe ObtenerLetra(int codigoLetra, SqlConnection cn)
        {
            LetraBe item = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_obtener", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoLetra", codigoLetra.GetNullable());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            item = new LetraBe();

                            if (dr.Read())
                            {
                                item.CodigoLetra = dr.GetData<int>("CodigoLetra");
                                item.Numero = dr.GetData<int>("Numero");
                                item.FechaHoraEmision = dr.GetData<DateTime>("FechaHoraEmision");
                                item.FechaVencimiento = dr.GetData<DateTime>("FechaVencimiento");
                                item.Dias = dr.GetData<int>("Dias");
                                item.CodigoTipoComprobanteRef = dr.GetData<int>("CodigoTipoComprobanteRef");
                                item.CodigoComprobanteRef = dr.GetData<int>("CodigoComprobanteRef");
                                item.CodigoGuiaRemision = dr.GetData<int>("CodigoGuiaRemision");
                                item.CodigoMoneda = dr.GetData<int>("CodigoMoneda");
                                item.CodigoCliente = dr.GetData<int>("CodigoCliente");
                                item.CodigoBanco = dr.GetData<int>("CodigoBanco");
                                item.CodigoUnicoBanco = dr.GetData<string>("CodigoUnicoBanco");
                                item.Monto = dr.GetData<decimal>("Monto");
                                item.Mora = dr.GetData<decimal>("Mora");
                                item.Protesto = dr.GetData<decimal>("Protesto");
                                item.Estado = dr.GetData<int>("Estado");
                                item.CodigoLetraPadre = dr.GetData<int?>("CodigoLetraPadre");
                                item.CodigoLetraInicial = dr.GetData<int?>("CodigoLetraInicial");
                                item.FlagAval = dr.GetData<bool>("FlagAval");
                                item.DireccionAval = dr.GetData<string>("DireccionAval");
                                item.NombrePaisAval = dr.GetData<string>("NombrePaisAval");
                                item.NombreDepartamentoAval = dr.GetData<string>("NombreDepartamentoAval");
                                item.NombreProvinciaAval = dr.GetData<string>("NombreProvinciaAval");
                                item.NombreDistritoAval = dr.GetData<string>("NombreDistritoAval");
                                item.FlagCancelado = dr.GetData<bool>("FlagCancelado");
                                item.FlagActivo = dr.GetData<bool>("FlagActivo");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return item;
        }

        public bool GuardarLetra(LetraBe registro, SqlConnection cn, out int codigoLetra, out int numero)
        {
            codigoLetra = 0;
            numero = 0;
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_guardar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@codigoLetra", Value = registro.CodigoLetra.GetNullable(), Direction = ParameterDirection.InputOutput });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@numero", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output });
                    cmd.Parameters.AddWithValue("@fechaHoraEmision", registro.FechaHoraEmision.GetNullable());
                    cmd.Parameters.AddWithValue("@fechaVencimiento", registro.FechaVencimiento.GetNullable());
                    cmd.Parameters.AddWithValue("@dias", registro.Dias.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoTipoComprobanteRef", registro.CodigoTipoComprobanteRef.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoComprobanteRef", registro.CodigoComprobanteRef.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoGuiaRemision", registro.CodigoGuiaRemision.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoCliente", registro.CodigoCliente.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoBanco", registro.CodigoBanco.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoUnicoBanco", registro.CodigoUnicoBanco.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoMoneda", registro.CodigoMoneda.GetNullable());
                    cmd.Parameters.AddWithValue("@monto", registro.Monto.GetNullable());
                    cmd.Parameters.AddWithValue("@mora", registro.Mora.GetNullable());
                    cmd.Parameters.AddWithValue("@protesto", registro.Protesto.GetNullable());
                    cmd.Parameters.AddWithValue("@estado", registro.Estado.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoLetraPadre", registro.CodigoLetraPadre.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoLetraInicial", registro.CodigoLetraInicial.GetNullable());
                    cmd.Parameters.AddWithValue("@flagAval", registro.FlagAval.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoAval", registro.CodigoAval.GetNullable());
                    cmd.Parameters.AddWithValue("@direccionAval", registro.DireccionAval.GetNullable());
                    cmd.Parameters.AddWithValue("@nombrePaisAval", registro.NombrePaisAval.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreDepartamentoAval", registro.NombreDepartamentoAval.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreProvinciaAval", registro.NombreProvinciaAval.GetNullable());
                    cmd.Parameters.AddWithValue("@nombreDistritoAval", registro.NombreDistritoAval.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoDistritoAval", registro.CodigoDistritoAval.GetNullable());
                    cmd.Parameters.AddWithValue("@flagCancelado", registro.FlagCancelado.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;

                    if (seGuardo)
                    {
                        codigoLetra = (int)cmd.Parameters["@codigoLetra"].Value;
                        numero = (int)cmd.Parameters["@numero"].Value;
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool AsignarBanco(LetraBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_asignarbanco", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoLetra", registro.CodigoLetra.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoBanco", registro.CodigoBanco.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoUnicoBanco", registro.CodigoUnicoBanco.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool AsignarMora(LetraBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_asignarmora", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoLetra", registro.CodigoLetra.GetNullable());
                    cmd.Parameters.AddWithValue("@mora", registro.Mora.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool AsignarProtesto(LetraBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_asignarprotesto", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoLetra", registro.CodigoLetra.GetNullable());
                    cmd.Parameters.AddWithValue("@protesto", registro.Protesto.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool AsignarObservacion(LetraBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_asignarobservacion", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoLetra", registro.CodigoLetra.GetNullable());
                    cmd.Parameters.AddWithValue("@observacion", registro.Observacion.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool EliminarLetraPorRef(int codigoTipoComprobanteRef, int codigoComprobanteRef, string usuarioModi, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_eliminar_x_ref", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoTipoComprobanteRef", codigoTipoComprobanteRef.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoComprobanteRef", codigoComprobanteRef.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", usuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas >= 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarEstadoLetra(LetraBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_cambiar_estado", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoLetra", registro.CodigoLetra.GetNullable());
                    cmd.Parameters.AddWithValue("@estado", registro.Estado.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool CambiarFlagCanceladoLetra(LetraBe registro, SqlConnection cn)
        {
            bool seGuardo = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_cambiar_flagcancelado", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoLetra", registro.CodigoLetra.GetNullable());
                    cmd.Parameters.AddWithValue("@flagCancelado", registro.FlagCancelado.GetNullable());
                    cmd.Parameters.AddWithValue("@usuarioModi", registro.UsuarioModi.GetNullable());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    seGuardo = filasAfectadas > 0;
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return seGuardo;
        }

        public bool ExisteCodigoUnicoBanco(int codigoLetra, int codigoBanco, string codigoUnicoBanco, SqlConnection cn)
        {
            bool existe = false;

            try
            {
                using (SqlCommand cmd = new SqlCommand("dbo.usp_letra_existe_codigounicobanco", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoBanco", codigoBanco.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoUnicoBanco", codigoUnicoBanco.GetNullable());
                    cmd.Parameters.AddWithValue("@codigoLetra", codigoLetra.GetNullable());

                    existe = (bool)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }

            return existe;
        }
    }
}
