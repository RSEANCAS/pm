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
    public class ConfiguracionValorBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ConfiguracionValorDa configuracionValorDa = new ConfiguracionValorDa();
        ProveedorDa proveedorDa = new ProveedorDa();

        public ConfiguracionValorBe ObtenerConfiguracionValor(bool withTransportistaGuiaRemision = false)
        {
            ConfiguracionValorBe item = null;

            try
            {
                cn.Open();
                item = configuracionValorDa.ObtenerConfiguracionValor(cn);
                if(item != null)
                {
                    if (item.CodigoTransportistaGuiaRemision.HasValue) item.TransportistaGuiaRemision = proveedorDa.ObtenerProveedor(item.CodigoTransportistaGuiaRemision.Value, cn);
                }
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool GuardarConfiguracionValor(ConfiguracionValorBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = configuracionValorDa.GuardarConfiguracionValor(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
