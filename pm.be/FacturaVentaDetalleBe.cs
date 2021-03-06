﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class FacturaVentaDetalleBe : BaseAuditoria
    {
        public int CodigoFacturaVenta { get; set; }
        public int CodigoFacturaVentaDetalle { get; set; }
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
        public int? CodigoGuiaRemision { get; set; }
        public GuiaRemisionBe GuiaRemision { get; set; }
        public int? CodigoGuiaRemisionDetalle { get; set; }
        public GuiaRemisionDetalleBe GuiaRemisionDetalle { get; set; }
        public int? CodigoCotizacion { get; set; }
        public CotizacionBe Cotizacion { get; set; }
        public int? CodigoCotizacionDetalle { get; set; }
        public CotizacionDetalleBe CotizacionDetalle { get; set; }
        public bool FlagEliminado { get; set; }
    }
}
