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
    public class FormatoBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        FormatoDa formatoDa = new FormatoDa();

        public List<FormatoBe.Letra> ListarFormatoLetra(int[] codigosLetra)
        {
            List<FormatoBe.Letra> resultados = null;

            try
            {
                cn.Open();
                resultados = formatoDa.ListarFormatoLetra(codigosLetra, cn);
            }
            catch (Exception ex) { log.Error(ex); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }
    }
}
