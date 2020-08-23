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
    public class ActividadBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ActividadDa actividadDa = new ActividadDa();

        public List<ActividadBe> BuscarActividad(string nombre, bool flagActivo)
        {
            List<ActividadBe> resultados = null;

            try
            {
                cn.Open();
                resultados = actividadDa.BuscarActividad(nombre, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public ActividadBe ObtenerActividad(int codigoActividad)
        {
            ActividadBe item = null;

            try
            {
                cn.Open();
                item = actividadDa.ObtenerActividad(codigoActividad, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteActividad(string nombre, int? codigoActividad)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = actividadDa.ExisteActividad(nombre, codigoActividad, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarActividad(ActividadBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = actividadDa.GuardarActividad(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarFlagActivoActividad(ActividadBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = actividadDa.CambiarFlagActivoActividad(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public List<ActividadBe> ListarComboActividad()
        {
            List<ActividadBe> lista = null;

            try
            {
                cn.Open();
                lista = actividadDa.ListarComboActividad(cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }
    }
}
