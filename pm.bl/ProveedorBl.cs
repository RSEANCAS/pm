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
    public class ProveedorBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ProveedorDa proveedorDa = new ProveedorDa();

        public List<ProveedorBe> BuscarProveedor(string nroDocumentoIdentidad, string nombres, string direccion, int? codigoPais, string correo, string contacto, bool flagActivo)
        {
            List<ProveedorBe> resultados = null;

            try
            {
                cn.Open();
                resultados = proveedorDa.BuscarProveedor(nroDocumentoIdentidad, nombres, direccion, codigoPais, correo, contacto, flagActivo, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public ProveedorBe ObtenerProveedor(int codigoProveedor)
        {
            ProveedorBe item = null;

            try
            {
                cn.Open();
                item = proveedorDa.ObtenerProveedor(codigoProveedor, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteProveedor(string nroDocumentoIdentidad, int? codigoProveedor)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = proveedorDa.ExisteProveedor(nroDocumentoIdentidad, codigoProveedor, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarProveedor(ProveedorBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = proveedorDa.GuardarProveedor(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarFlagActivoProveedor(ProveedorBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = proveedorDa.CambiarFlagActivoProveedor(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
