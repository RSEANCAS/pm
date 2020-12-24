using pm.be;
using pm.da;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static pm.enums.Enums;

namespace pm.bl
{
    public class LetraBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        LetraDa letraDa = new LetraDa();

        public List<LetraBe> BuscarLetra(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, string numero, string nroDocIdentidadCliente, string nombresCliente, int? estado, bool flagCancelado, bool flagActivo)
        {
            List<LetraBe> resultados = null;

            try
            {
                cn.Open();
                resultados = letraDa.BuscarLetra(fechaEmisionDesde, fechaEmisionHasta, numero, nroDocIdentidadCliente, nombresCliente, estado, flagCancelado, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public LetraBe ObtenerLetra(int codigoLetra)
        {
            LetraBe item = null;

            try
            {
                cn.Open();
                item = letraDa.ObtenerLetra(codigoLetra, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool AsignarBanco(LetraBe registro)
        {
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    seGuardo = letraDa.AsignarBanco(registro, cn);

                    if (seGuardo)
                    {
                        switch ((EstadoLetra)registro.Estado)
                        {
                            case EstadoLetra.PorAsignarBanco:
                                if((registro.CodigoUnicoBanco ?? "").Trim() != "")registro.Estado = (int)EstadoLetra.Pendiente;
                                seGuardo = letraDa.CambiarEstadoLetra(registro, cn);
                                break;
                        }
                    }

                    if (seGuardo) scope.Complete();
                    cn.Close();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool AsignarMora(LetraBe registro)
        {
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    seGuardo = letraDa.AsignarMora(registro, cn);

                    if (seGuardo) scope.Complete();
                    cn.Close();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool AsignarProtesto(LetraBe registro)
        {
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    seGuardo = letraDa.AsignarProtesto(registro, cn);

                    if (seGuardo)
                    {
                        switch ((EstadoLetra)registro.Estado)
                        {
                            case EstadoLetra.Pendiente:
                            case EstadoLetra.Renovada:
                                registro.Estado = (int)EstadoLetra.Protestada;
                                seGuardo = letraDa.CambiarEstadoLetra(registro, cn);
                                break;
                        }
                    }

                    if (seGuardo) scope.Complete();
                    cn.Close();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool Retirar(LetraBe registro, bool seRegenera = false)
        {
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    seGuardo = letraDa.AsignarObservacion(registro, cn);

                    if (seGuardo)
                    {
                        registro.Estado = (int)EstadoLetra.Retirada;
                        seGuardo = letraDa.CambiarEstadoLetra(registro, cn);

                        if (seRegenera)
                        {
                            LetraBe nuevaLetra = new LetraBe
                            {
                                FechaHoraEmision = registro.FechaHoraEmision,
                                FechaVencimiento = registro.FechaVencimiento,
                                Dias = registro.Dias,
                                CodigoTipoComprobanteRef = registro.CodigoTipoComprobanteRef,
                                CodigoComprobanteRef = registro.CodigoComprobanteRef,
                                CodigoSerieComprobanteRef = registro.CodigoSerieComprobanteRef,
                                NroComprobanteComprobanteRef = registro.NroComprobanteComprobanteRef,
                                CodigoGuiaRemision = registro.CodigoGuiaRemision,
                                CodigoSerieGuiaRemision = registro.CodigoSerieGuiaRemision,
                                NroComprobanteGuiaRemision = registro.NroComprobanteGuiaRemision,
                                CodigoCliente = registro.CodigoCliente,
                                CodigoBanco = registro.CodigoBanco,
                                CodigoUnicoBanco = registro.CodigoUnicoBanco,
                                CodigoMoneda = registro.CodigoMoneda,
                                Monto = registro.Monto,
                                Mora = registro.Mora,
                                Protesto = registro.Protesto,
                                Estado = (int)EstadoLetra.Pendiente,
                                CodigoLetraPadre = registro.CodigoLetra,
                                CodigoLetraInicial = registro.CodigoLetraInicial.HasValue ? registro.CodigoLetraInicial.Value : registro.CodigoLetra,
                                FlagAval = registro.FlagAval,
                                CodigoAval = registro.CodigoAval,
                                DireccionAval = registro.DireccionAval,
                                NombrePaisAval = registro.NombrePaisAval,
                                NombreDepartamentoAval = registro.NombreDepartamentoAval,
                                NombreProvinciaAval = registro.NombreProvinciaAval,
                                CodigoDistritoAval = registro.CodigoDistritoAval,
                                NombreDistritoAval = registro.NombreDistritoAval,
                                FlagCancelado = registro.FlagCancelado,
                                FlagActivo = registro.FlagActivo,
                                FlagEliminado = registro.FlagEliminado
                            };
                            int nuevoCodigoLetra = 0; int nuevoNumeroLetra = 0;
                            letraDa.GuardarLetra(nuevaLetra, cn, out nuevoCodigoLetra, out nuevoNumeroLetra);
                        }
                    }

                    if (seGuardo) scope.Complete();
                    cn.Close();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool ExisteCodigoUnicoBanco(int codigoLetra, int codigoBanco, string codigoUnicoBanco)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = letraDa.ExisteCodigoUnicoBanco(codigoLetra, codigoBanco, codigoUnicoBanco, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool GuardarLetra(LetraBe registro, out int codigoLetra, out int numero)
        {
            codigoLetra = 0;
            numero = 0;
            bool seGuardo = false;

            try
            {

                cn.Open();
                seGuardo = letraDa.GuardarLetra(registro, cn, out codigoLetra, out numero);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
