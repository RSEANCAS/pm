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
    public class PersonalBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        PersonalDa personalDa = new PersonalDa();

        public List<PersonalBe> BuscarPersonal(string nroDocumentoIdentidad, string nombres, string correo, string nombreArea, int? estado, bool flagActivo)
        {
            List<PersonalBe> resultados = null;

            try
            {
                cn.Open();
                resultados = personalDa.BuscarPersonal(nroDocumentoIdentidad, nombres, correo, nombreArea, estado, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public PersonalBe ObtenerPersonal(int codigoPersonal)
        {
            PersonalBe personal = null;

            try
            {
                cn.Open();
                personal = personalDa.ObtenerPersonal(codigoPersonal, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return personal;
        }

        public bool ExistePersonal(string nombre, int? codigoPersonal)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = personalDa.ExistePersonal(nombre, codigoPersonal, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarPersonal(PersonalBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = personalDa.GuardarPersonal(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarFlagActivoPersonal(PersonalBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = personalDa.CambiarFlagActivoPersonal(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

    }
}
