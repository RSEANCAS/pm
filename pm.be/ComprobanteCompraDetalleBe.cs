using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ComprobanteCompraDetalleBe : BaseAuditoria
    {
        public int CodigoComprobanteCompra { get; set; }
        public ComprobanteCompraBe ComprobanteCompra { get; set; }
        public int CodigoComprobanteCompraDetalle { get; set; }
        public int CodigoProducto { get; set; }
        public ProductoBe Producto { get; set; }
        public string Detalle { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal ImporteTotal { get; set; }
        public bool FlagCompleto { get; set; }
        public bool FlagEliminado { get; set; }
    }
}
