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
    public class ClienteBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ClienteDa clienteDa = new ClienteDa();

        public List<ClienteBe> BuscarCliente(string nroDocumentoIdentidad, string nombres, string direccion, string correo, string contacto, string areaContacto, bool flagActivo)
        {
            List<ClienteBe> resultados = null;

            try
            {
                cn.Open();
                resultados = clienteDa.BuscarCliente(nroDocumentoIdentidad, nombres, direccion, correo, contacto, areaContacto, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public ClienteBe ObtenerCliente(int codigoCliente)
        {
            ClienteBe item = null;

            try
            {
                cn.Open();
                item = clienteDa.ObtenerCliente(codigoCliente, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteCliente(string nroDocumentoIdentidad, int? codigoCliente)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = clienteDa.ExisteCliente(nroDocumentoIdentidad, codigoCliente, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarCliente(ClienteBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = clienteDa.GuardarCliente(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarFlagActivoCliente(ClienteBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = clienteDa.CambiarFlagActivoCliente(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
