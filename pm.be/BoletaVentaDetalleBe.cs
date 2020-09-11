using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class BoletaVentaDetalleBe : BaseAuditoria
    {
        public int CodigoBoletaVenta { get; set; }
        public int CodigoBoletaVentaDetalle { get; set; }
        public int CodigoProducto { get; set; }
        public ProductoBe Producto { get; set; }
        public int CodigoProductoIndividual { get; set; }
        public ProductoIndividualBe ProductoIndividual { get; set; }
        public int CodigoUnidadMedida { get; set; }
        public UnidadMedidaBe UnidadMedida { get; set; }
        public string Detalle { get; set; }
        public decimal Cantidad { get; set; }
        public int TipoCalculo { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Igv { get; set; }
        public decimal Isc { get; set; }
        public int TipoDescuento { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal Descuento { get; set; }
        public decimal OtrosCargos { get; set; }
        public decimal OtrosTributos { get; set; }
        public decimal BaseImponible { get; set; }
        public decimal Importe { get; set; }
        public bool FlagEliminado { get; set; }
    }
}
