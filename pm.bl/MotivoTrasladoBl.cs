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
    public class MotivoTrasladoBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        MotivoTrasladoDa motivoTrasladoDa = new MotivoTrasladoDa();

        public List<MotivoTrasladoBe> ListarComboMotivoTraslado()
        {
            List<MotivoTrasladoBe> lista = null;

            try
            {
                cn.Open();
                lista = motivoTrasladoDa.ListarComboMotivoTraslado(cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }

        public List<MotivoTrasladoBe> BuscarMotivoTraslado(string descripcion, bool flagActivo)
        {
            List<MotivoTrasladoBe> resultados = null;

            try
            {
                cn.Open();
                resultados = motivoTrasladoDa.BuscarMotivoTraslado(descripcion, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public MotivoTrasladoBe ObtenerMotivoTraslado(int codigoMotivoTraslado)
        {
            MotivoTrasladoBe item = null;

            try
            {
                cn.Open();
                item = motivoTrasladoDa.ObtenerMotivoTraslado(codigoMotivoTraslado, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteMotivoTraslado(string descripcion, int? codigoMotivoTraslado)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = motivoTrasladoDa.ExisteMotivoTraslado(descripcion, codigoMotivoTraslado, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarMotivoTraslado(MotivoTrasladoBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = motivoTrasladoDa.GuardarMotivoTraslado(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarFlagActivoMotivoTraslado(MotivoTrasladoBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = motivoTrasladoDa.CambiarFlagActivoMotivoTraslado(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
