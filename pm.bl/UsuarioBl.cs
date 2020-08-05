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
    public class UsuarioBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        UsuarioDa usuarioDa = new UsuarioDa();

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
