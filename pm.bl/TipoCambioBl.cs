using pm.be;
using pm.da;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.bl
{
    public class TipoCambioBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        TipoCambioDa tipoCambioDa = new TipoCambioDa();

        public List<TipoCambioBe> BuscarTipoCambio(DateTime? fechaCambioDesde, DateTime? fechaCambioHasta)
        {
            List<TipoCambioBe> resultados = null;

            try
            {
                cn.Open();
                resultados = tipoCambioDa.BuscarTipoCambio(fechaCambioDesde, fechaCambioHasta, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public TipoCambioBe ObtenerTipoCambio(int codigoTipoCambio)
        {
            TipoCambioBe item = null;

            try
            {
                cn.Open();
                item = tipoCambioDa.ObtenerTipoCambio(codigoTipoCambio, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public TipoCambioBe ObtenerTipoCambioPorFechaCambio(DateTime fechaCambio)
        {
            TipoCambioBe item = null;

            try
            {
                cn.Open();
                item = tipoCambioDa.ObtenerTipoCambioPorFechaCambio(fechaCambio, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteTipoCambio(DateTime fechaCambio, int? codigoTipoCambio)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = tipoCambioDa.ExisteTipoCambio(fechaCambio, codigoTipoCambio, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarTipoCambio(TipoCambioBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = tipoCambioDa.GuardarTipoCambio(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
