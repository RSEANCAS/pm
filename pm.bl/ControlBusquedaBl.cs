using pm.be;
using pm.da;
using pm.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.bl
{
    public class ControlBusquedaBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ControlBusquedaDa controlBusquedaDa = new ControlBusquedaDa();
        ControlBusquedaColumnaDa controlBusquedaColumnaDa = new ControlBusquedaColumnaDa();

        public ControlBusquedaBe ObtenerControlBusqueda(string formulario, string control, bool widthColumnas = false)
        {
            ControlBusquedaBe item = null;

            try
            {
                cn.Open();
                item = controlBusquedaDa.ObtenerControlBusqueda(formulario, control, cn);
                if (item != null)
                {
                    if (widthColumnas) item.ListaControlBusquedaColumna = controlBusquedaColumnaDa.ListarControlBusquedaColumna(item.CodigoControlBusqueda, cn);
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }
    }
}
