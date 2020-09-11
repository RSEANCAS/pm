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
    public class SerieBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        SerieDa serieDa = new SerieDa();

        public List<SerieBe> ListarComboSerie(int codigoTipoComprobante)
        {
            List<SerieBe> lista = null;

            try
            {
                cn.Open();
                lista = serieDa.ListarComboSerie(codigoTipoComprobante, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }

        public List<SerieBe> BuscarSerie(string serial, int? codigoTipoComprobante, bool flagActivo)
        {
            List<SerieBe> resultados = null;

            try
            {
                cn.Open();
                resultados = serieDa.BuscarSerie(serial, codigoTipoComprobante, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public SerieBe ObtenerSerie(int codigoSerie)
        {
            SerieBe item = null;

            try
            {
                cn.Open();
                item = serieDa.ObtenerSerie(codigoSerie, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteSerie(string serial, int codigoTipoComprobante, int? codigoSerie)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = serieDa.ExisteSerie(serial, codigoTipoComprobante, codigoSerie, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarSerie(SerieBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = serieDa.GuardarSerie(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarFlagActivoSerie(SerieBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = serieDa.CambiarFlagActivoSerie(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
