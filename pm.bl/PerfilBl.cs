using pm.be;
using pm.da;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace pm.bl
{
    public class PerfilBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        PerfilDa perfilDa = new PerfilDa();
        PerfilMenuDa perfilMenuDa = new PerfilMenuDa();

        public List<PerfilBe> BuscarPerfil(string nombre, bool flagActivo)
        {
            List<PerfilBe> resultados = null;

            try
            {
                cn.Open();
                resultados = perfilDa.BuscarPerfil(nombre, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public PerfilBe ObtenerPerfil(int codigoPerfil)
        {
            PerfilBe item = null;

            try
            {
                cn.Open();
                item = perfilDa.ObtenerPerfil(codigoPerfil, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExistePerfil(string nombre, int? codigoPerfil)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = perfilDa.ExistePerfil(nombre, codigoPerfil, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarPerfil(PerfilBe registro)
        {
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    int codigoPerfil = 0;
                    seGuardo = perfilDa.GuardarPerfil(registro, cn, out codigoPerfil);
                    if (seGuardo)
                    {
                        if (registro.ListaMenu != null)
                        {
                            if (registro.CodigoPerfil > 0)
                            {
                                seGuardo = perfilMenuDa.EliminarPerfilMenuPorPerfil(registro.CodigoPerfil, cn);
                            }

                            if (seGuardo)
                            {
                                foreach (MenuBe item in registro.ListaMenu)
                                {
                                    PerfilMenuBe itemPerfilMenu = new PerfilMenuBe();
                                    itemPerfilMenu.CodigoPerfil = codigoPerfil;
                                    itemPerfilMenu.CodigoMenu = item.CodigoMenu;

                                    seGuardo = perfilMenuDa.GuardarPerfilMenu(itemPerfilMenu, cn);
                                    if (!seGuardo) break;
                                }
                            }
                        }
                    }

                    if (seGuardo) scope.Complete();
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarFlagActivoPerfil(PerfilBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = perfilDa.CambiarFlagActivoPerfil(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public List<PerfilBe> ListarPerfilPorUsuario(int codigoUsuario)
        {
            List<PerfilBe> lista = null;

            try
            {
                cn.Open();
                lista = perfilDa.ListarPerfilPorUsuario(codigoUsuario, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }

        public List<PerfilBe> ListarPerfilDefaultPorUsuario(int? codigoUsuario)
        {
            List<PerfilBe> lista = null;

            try
            {
                cn.Open();
                lista = perfilDa.ListarPerfilDefaultPorUsuario(codigoUsuario, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }
    }
}
