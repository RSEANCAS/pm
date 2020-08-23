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
    public class UsuarioBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        UsuarioDa usuarioDa = new UsuarioDa();
        UsuarioPerfilDa usuarioPerfilDa = new UsuarioPerfilDa();

        public List<UsuarioBe> BuscarUsuario(string nombre, string nroDocumentoIdentidadPersonal, string nombresPersonal, string correoPersonal, bool flagActivo)
        {
            List<UsuarioBe> resultados = null;

            try
            {
                cn.Open();
                resultados = usuarioDa.BuscarUsuario(nombre, nroDocumentoIdentidadPersonal, nombresPersonal, correoPersonal, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public UsuarioBe ObtenerUsuario(int codigoUsuario)
        {
            UsuarioBe item = null;

            try
            {
                cn.Open();
                item = usuarioDa.ObtenerUsuario(codigoUsuario, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteUsuario(string nombre, int? codigoUsuario)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = usuarioDa.ExisteUsuario(nombre, codigoUsuario, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarUsuario(UsuarioBe registro)
        {
            bool seGuardo = false;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    cn.Open();
                    int codigoUsuario = 0;
                    seGuardo = usuarioDa.GuardarUsuario(registro, cn, out codigoUsuario);

                    if (seGuardo)
                    {
                        if (registro.ListaPerfil != null)
                        {
                            if (registro.CodigoUsuario > 0)
                            {
                                seGuardo = usuarioPerfilDa.EliminarUsuarioPerfilPorUsuario(registro.CodigoUsuario, cn);
                            }

                            if (seGuardo)
                            {
                                foreach (PerfilBe item in registro.ListaPerfil)
                                {
                                    UsuarioPerfilBe itemUsuarioPerfil = new UsuarioPerfilBe();
                                    itemUsuarioPerfil.CodigoUsuario = codigoUsuario;
                                    itemUsuarioPerfil.CodigoPerfil = item.CodigoPerfil;

                                    seGuardo = usuarioPerfilDa.GuardarUsuarioPerfil(itemUsuarioPerfil, cn);
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

        public bool CambiarFlagActivoUsuario(UsuarioBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = usuarioDa.CambiarFlagActivoUsuario(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public UsuarioBe ObtenerUsuarioPorNombre(string nombre)
        {
            UsuarioBe usuario = null;

            try
            {
                cn.Open();
                usuario = usuarioDa.ObtenerUsuarioPorNombre(nombre, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return usuario;
        }
    }
}
