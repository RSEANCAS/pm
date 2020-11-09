using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ProductoIndividualBe : BaseAuditoria
    {
        public int CodigoProductoIndividual { get; set; }
        public string CodigoBarra { get; set; }
        public int CodigoProducto { get; set; }
        public ProductoBe Producto { get; set; }
        public string Nombre { get; set; }
        public int CodigoUnidadMedida { get; set; }
        public UnidadMedidaBe UnidadMedida { get; set; }
        public decimal Metraje { get; set; }
        public int CodigoUnidadMedidaPeso { get; set; }
        public UnidadMedidaBe UnidadMedidaPeso { get; set; }
        public decimal Peso { get; set; }
        public int? CodigoInicial { get; set; }
        public ProductoIndividualBe Inicial { get; set; }
        public decimal Rollo { get; set; }
        public decimal Bulto { get; set; }
        public string Color { get; set; }
        public int CodigoProveedor { get; set; }
        public ProveedorBe Proveedor { get; set; }
        public string CodigoBarraProveedor { get; set; }
        public DateTime FechaEntrada { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal? PrecioCompra { get; set; }
        public int CodigoPersonalInspeccion { get; set; }
        public PersonalBe PersonalInspeccion { get; set; }
        public int? CodigoComprobanteCompra { get; set; }
        public ComprobanteCompraBe ComprobanteCompra { get; set; }
        public int? CodigoComprobanteCompraDetalle { get; set; }
        public ComprobanteCompraDetalleBe ComprobanteCompraDetalle { get; set; }
        public bool FlagActivo { get; set; }
        public override string ToString() => Nombre;
    }
}
