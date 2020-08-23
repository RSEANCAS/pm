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
    public class ProductoIndividualBl : Conexion
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ProductoIndividualDa productoIndividualDa = new ProductoIndividualDa();

        public List<ProductoIndividualBe> BuscarProductoIndividual(int? codigoProductoIndividual, string codigoBarra, int? codigoProducto, string nombre, string codigoInicial, string color, string nroDocumentoIdentidadProveedor, string nombresProveedor, DateTime fechaEntradaDesde, DateTime fechaEntradaHasta, string nroDocumentoIdentidadPersonalInspeccion, string nombresPersonalInspeccion)
        {
            List<ProductoIndividualBe> resultados = null;

            try
            {
                cn.Open();
                resultados = productoIndividualDa.BuscarProductoIndividual(codigoProductoIndividual, codigoBarra, codigoProducto, nombre, codigoInicial, color, nroDocumentoIdentidadProveedor, nombresProveedor, fechaEntradaDesde, fechaEntradaHasta, nroDocumentoIdentidadPersonalInspeccion, nombresPersonalInspeccion, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return resultados;
        }

        public ProductoIndividualBe ObtenerProductoIndividual(int codigoProductoIndividual)
        {
            ProductoIndividualBe item = null;

            try
            {
                cn.Open();
                item = productoIndividualDa.ObtenerProductoIndividual(codigoProductoIndividual, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return item;
        }

        public bool ExisteProductoIndividual(string nombre, int? codigoProductoIndividual)
        {
            bool existe = false;

            try
            {
                cn.Open();
                existe = productoIndividualDa.ExisteProductoIndividual(nombre, codigoProductoIndividual, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return existe;
        }

        public bool GuardarProductoIndividual(ProductoIndividualBe registro)
        {
            bool seGuardo = false;

            try
            {
                cn.Open();
                seGuardo = productoIndividualDa.GuardarProductoIndividual(registro, cn);
            }
            catch (Exception ex) { log.Error(ex.Message); }
            finally { if (cn.State == ConnectionState.Open) cn.Close(); }

            return seGuardo;
        }
    }
}
