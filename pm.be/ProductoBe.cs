using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ProductoBe : BaseAuditoria
    {
        public int CodigoProducto { get; set; }
        public string Nombres { get; set; }
        public int CodigoUnidadMedida { get; set; }
        public UnidadMedidaBe UnidadMedida { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal DescuentoMaximo { get; set; }
        public string Color { get; set; }
        public decimal MetrajeTotal { get; set; }
        public int Estado { get; set; }
    }
}
