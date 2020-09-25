using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class GuiaRemisionDetalleBe : BaseAuditoria
    {
        public int CodigoGuiaRemision { get; set; }
        public GuiaRemisionBe GuiaRemision { get; set; }
        public int CodigoGuiaRemisionDetalle { get; set; }
        public int CodigoProducto { get; set; }
        public ProductoBe Producto { get; set; }
        public int CodigoProductoIndividual { get; set; }
        public ProductoIndividualBe ProductoIndividual { get; set; }
        public int CodigoUnidadMedida { get; set; }
        public UnidadMedidaBe UnidadMedida { get; set; }
        public string Detalle { get; set; }
        public decimal Cantidad { get; set; }
        public int CodigoUnidadMedidaPeso { get; set; }
        public UnidadMedidaBe UnidadMedidaPeso { get; set; }
        public decimal Peso { get; set; }
        public bool FlagEliminado { get; set; }
    }
}
