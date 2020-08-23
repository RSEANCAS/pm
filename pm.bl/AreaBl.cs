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
    public class AreaBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        AreaDa areaDa = new AreaDa();

        public List<AreaBe> ListarComboArea()
        {
            List<AreaBe> lista = null;

            try
            {
                cn.Open();
                lista = areaDa.ListarComboArea(cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }

        public List<AreaBe> BuscarArea(string nombre, bool flagActivo)
        {
            List<AreaBe> resultados = null;

            try
            {
                cn.Open();
                resultados = areaDa.BuscarArea(nombre, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public AreaBe ObtenerArea(int codigoArea)
        {
            AreaBe item = null;

            try
            {
                cn.Open();
                item = areaDa.ObtenerArea(codigoArea, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteArea(string nombre, int? codigoArea)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = areaDa.ExisteArea(nombre, codigoArea, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarArea(AreaBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = areaDa.GuardarArea(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarFlagActivoArea(AreaBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = areaDa.CambiarFlagActivoArea(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
