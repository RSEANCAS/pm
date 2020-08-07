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

        ActividadDa tipoDocumentoIdentidadDa = new ActividadDa();

        public List<ActividadBe> ListarComboActividad()
        {
            List<ActividadBe> lista = null;

            try
            {
                cn.Open();
                lista = tipoDocumentoIdentidadDa.ListarComboActividad(cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }
    }
}
