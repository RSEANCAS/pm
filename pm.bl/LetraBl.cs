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

        public List<LetraBe> BuscarLetra(DateTime? fechaEmisionDesde, DateTime? fechaEmisionHasta, string numero, string nroDocIdentidadCliente, string nombresCliente, int? estado, bool flagActivo)
        {
            List<LetraBe> resultados = null;

            try
            {
                cn.Open();
                resultados = letraDa.BuscarLetra(fechaEmisionDesde, fechaEmisionHasta, numero, nroDocIdentidadCliente, nombresCliente, estado, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
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
    }
}
