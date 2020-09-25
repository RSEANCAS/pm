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
    public class BancoBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        BancoDa bancoDa = new BancoDa();

        public List<BancoBe> ListarComboBanco()
        {
            List<BancoBe> lista = null;

            try
            {
                cn.Open();
                lista = bancoDa.ListarComboBanco(cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return lista;
        }

        public List<BancoBe> BuscarBanco(string nombre, bool flagActivo)
        {
            List<BancoBe> resultados = null;

            try
            {
                cn.Open();
                resultados = bancoDa.BuscarBanco(nombre, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public BancoBe ObtenerBanco(int codigoBanco)
        {
            BancoBe item = null;

            try
            {
                cn.Open();
                item = bancoDa.ObtenerBanco(codigoBanco, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteBanco(string nombre, int? codigoBanco)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = bancoDa.ExisteBanco(nombre, codigoBanco, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarBanco(BancoBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = bancoDa.GuardarBanco(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarFlagActivoBanco(BancoBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = bancoDa.CambiarFlagActivoBanco(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
