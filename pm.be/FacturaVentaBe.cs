using pm.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static pm.enums.Enums;

namespace pm.be
{
    public class FacturaVentaBe : BaseComprobante
    {
        public int CodigoFacturaVenta { get; set; }
        public DateTime FechaHoraVencimiento { get; set; }
        public int CodigoMoneda { get; set; }
        public string StrMoneda { get { return Enum<Moneda>.GetCollection().Count(x => x.Value == CodigoMoneda.ToString()) == 0 ? "" : ((Moneda)CodigoMoneda).GetAttributeOfType<DescriptionAttribute>().Description; } }
        public int? CodigoGuiaRemision { get; set; }
        public GuiaRemisionBe GuiaRemision { get; set; }
        public int CodigoMetodoPago { get; set; }
        public int CantidadLetrasCredito { get; set; }
        public decimal TotalOperacionGravada { get; set; }
        public decimal TotalOperacionInafecta { get; set; }
        public decimal TotalOperacionExonerada { get; set; }
        public decimal TotalOperacionExportacion { get; set; }
        public decimal TotalOperacionGratuita { get; set; }
        public decimal TotalValorVenta { get; set; }
        public decimal TotalIgv { get; set; }
        public decimal TotalIsc { get; set; }
        public decimal TotalOtrosCargos { get; set; }
        public decimal TotalOtrosTributos { get; set; }
        public decimal TotalIcbper { get; set; }
        public decimal TotalDescuentoDetallado { get; set; }
        public decimal TotalPorcentajeDescuentoGlobal { get; set; }
        public decimal TotalDescuentoGlobal { get; set; }
        public decimal TotalPrecioVenta { get; set; }
        public decimal TotalBaseImponible { get; set; }
        public decimal TotalImporte { get; set; }
        public decimal TotalPercepcion { get; set; }
        public decimal TotalPagar { get; set; }
        public int? CodigoCotizacion { get; set; }
        public CotizacionBe Cotizacion { get; set; }
        public bool FlagEmitido { get; set; }
        public bool FlagActivo { get; set; }

        public List<FacturaVentaDetalleBe> ListaFacturaVentaDetalle { get; set; }
        public int[] ListaFacturaVentaDetalleEliminar { get; set; }

        public List<LetraBe> ListaLetra { get; set; }
    }
}
