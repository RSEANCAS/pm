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
    public class UnidadMedidaBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        UnidadMedidaDa unidadMedidaDa = new UnidadMedidaDa();

        public List<UnidadMedidaBe> BuscarUnidadMedida(string nombre, bool flagActivo)
        {
            List<UnidadMedidaBe> resultados = null;

            try
            {
                cn.Open();
                resultados = unidadMedidaDa.BuscarUnidadMedida(nombre, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public UnidadMedidaBe ObtenerUnidadMedida(int codigoUnidadMedida)
        {
            UnidadMedidaBe item = null;

            try
            {
                cn.Open();
                item = unidadMedidaDa.ObtenerUnidadMedida(codigoUnidadMedida, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteUnidadMedida(string nombre, int? codigoUnidadMedida)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = unidadMedidaDa.ExisteUnidadMedida(nombre, codigoUnidadMedida, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarUnidadMedida(UnidadMedidaBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = unidadMedidaDa.GuardarUnidadMedida(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarFlagActivoUnidadMedida(UnidadMedidaBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = unidadMedidaDa.CambiarFlagActivoUnidadMedida(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public List<UnidadMedidaBe> ListarComboUnidadMedida()
        {
            List<UnidadMedidaBe> lista = null;

            try
            {
                cn.Open();
                lista = unidadMedidaDa.ListarComboUnidadMedida(cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }
    }
}
