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
    public class MotivoNotaBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        MotivoNotaDa motivoNotaDa = new MotivoNotaDa();

        public List<MotivoNotaBe> ListarComboMotivoNota(int codigoTipoComprobante)
        {
            List<MotivoNotaBe> lista = null;

            try
            {
                cn.Open();
                lista = motivoNotaDa.ListarComboMotivoNota(codigoTipoComprobante, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }

        public List<MotivoNotaBe> BuscarMotivoNota(string descripcion, bool flagActivo)
        {
            List<MotivoNotaBe> resultados = null;

            try
            {
                cn.Open();
                resultados = motivoNotaDa.BuscarMotivoNota(descripcion, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public MotivoNotaBe ObtenerMotivoNota(int codigoMotivoNota)
        {
            MotivoNotaBe item = null;

            try
            {
                cn.Open();
                item = motivoNotaDa.ObtenerMotivoNota(codigoMotivoNota, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteMotivoNota(string descripcion, int codigoTipoComprobante, int? codigoMotivoNota)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = motivoNotaDa.ExisteMotivoNota(descripcion, codigoTipoComprobante, codigoMotivoNota, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarMotivoNota(MotivoNotaBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = motivoNotaDa.GuardarMotivoNota(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarFlagActivoMotivoNota(MotivoNotaBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = motivoNotaDa.CambiarFlagActivoMotivoNota(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
