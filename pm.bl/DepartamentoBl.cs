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
    public class DepartamentoBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        DepartamentoDa departamentoDa = new DepartamentoDa();

        public List<DepartamentoBe> ListarComboDepartamento()
        {
            List<DepartamentoBe> lista = null;

            try
            {
                cn.Open();
                lista = departamentoDa.ListarComboDepartamento(cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }
    }
}
