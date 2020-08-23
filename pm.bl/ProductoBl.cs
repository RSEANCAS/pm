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
    public class ProductoBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ProductoDa productoDa = new ProductoDa();

        public List<ProductoBe> BuscarProducto(int? codigoProducto, string nombres, string color, int? estado)
        {
            List<ProductoBe> resultados = null;

            try
            {
                cn.Open();
                resultados = productoDa.BuscarProducto(codigoProducto, nombres, color, estado, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public ProductoBe ObtenerProducto(int codigoProducto)
        {
            ProductoBe item = null;

            try
            {
                cn.Open();
                item = productoDa.ObtenerProducto(codigoProducto, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteProducto(string nroDocumentoIdentidad, int? codigoProducto)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = productoDa.ExisteProducto(nroDocumentoIdentidad, codigoProducto, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarProducto(ProductoBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = productoDa.GuardarProducto(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }

        public bool CambiarEstadoProducto(ProductoBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = productoDa.CambiarEstadoProducto(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
