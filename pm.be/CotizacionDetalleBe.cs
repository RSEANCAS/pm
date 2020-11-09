using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class CotizacionDetalleBe: BaseAuditoria
    {
        public int CodigoCotizacion { get; set; }
        public CotizacionBe Cotizacion { get; set; }
        public int CodigoCotizacionDetalle { get; set; }
        public int CodigoProducto { get; set; }
        public ProductoBe Producto { get; set; }
        public int CodigoProductoIndividual { get; set; }
        public ProductoIndividualBe ProductoIndividual { get; set; }
        public string Detalle { get; set; }
        public int CodigoUnidadMedida { get; set; }
        public UnidadMedidaBe UnidadMedida { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe { get; set; }
        public bool FlagEliminado { get; set; }
    }
}
