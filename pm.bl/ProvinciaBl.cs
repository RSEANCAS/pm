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
    public class ProvinciaBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ProvinciaDa provinciaDa = new ProvinciaDa();

        public List<ProvinciaBe> ListarComboProvincia()
        {
            List<ProvinciaBe> lista = null;

            try
            {
                cn.Open();
                lista = provinciaDa.ListarComboProvincia(cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }
    }
}
