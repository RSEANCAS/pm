using pm.da;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.bl
{
    public class CommonBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        CommonDa commonDa = new CommonDa();

        public List<dynamic> BuscarQuery(string table, string columns, string columnsFilter)
        {
            List<dynamic> resultados = null;

            try
            {
                cn.Open();
                resultados = commonDa.BuscarQuery(table, columns, columnsFilter, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }
    }
}
