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

        public List<MenuBe> BuscarMenu(string nombre, string formulario, bool flagActivo)
        {
            List<MenuBe> resultados = null;

            try
            {
                cn.Open();
                resultados = menuDa.BuscarMenu(nombre, formulario, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public MenuBe ObtenerMenu(int codigoMenu)
        {
            MenuBe item = null;

            try
            {
                cn.Open();
                item = menuDa.ObtenerMenu(codigoMenu, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteMenu(string nombre, int? codigoMenu)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = menuDa.ExisteMenu(nombre, codigoMenu, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarMenu(MenuBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = menuDa.GuardarMenu(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarFlagActivoMenu(MenuBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = menuDa.CambiarFlagActivoMenu(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

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

        public List<MenuBe> ListarMenuDefaultPorPerfil(int? codigoPerfil)
        {
            List<MenuBe> lista = null;

            try
            {
                cn.Open();
                lista = menuDa.ListarMenuDefaultPorPerfil(codigoPerfil, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }

        public List<MenuBe> ListarComboMenuPadreMenu(int? codigoMenu)
        {
            List<MenuBe> lista = null;

            try
            {
                cn.Open();
                lista = menuDa.ListarComboMenuPadreMenu(codigoMenu, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }
    }
}
