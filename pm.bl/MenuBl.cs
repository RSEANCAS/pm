using pm.be;
using pm.da;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace pm.bl
{
    public class MenuBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        MenuDa menuDa = new MenuDa();

        public List<MenuBe> ListarMenuPorPerfil(int codigoPerfil)
        {
            List<MenuBe> lista = null;

            try
            {
                cn.Open();
                lista = menuDa.ListarMenuPorPerfil(codigoPerfil, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }
    }
}
