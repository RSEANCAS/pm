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
        public int CodigoCliente { get; set; }
        public ClienteBe Cliente { get; set; }
        // NO MAPEADO EN BD
        public string NroDocumentoIdentidadCliente { get; set; }
        // NO MAPEADO EN BD
        public string NombresCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string NombrePaisCliente { get; set; }
        public string NombreDepartamentoCliente { get; set; }
        public string NombreProvinciaCliente { get; set; }
        public int CodigoDistritoCliente { get; set; }
        public string NombreDistritoCliente { get; set; }
        public DistritoBe DistritoCliente { get; set; }
        // NO MAPEADO EN BD
        public int CodigoTipoDocumentoIdentidadCliente { get; set; }
        // NO MAPEADO EN BD
        public TipoDocumentoIdentidadBe TipoDocumentoIdentidadCliente { get; set; }
        // NO MAPEADO EN BD
        public string DescripcionTipoDocumentoIdentidadCliente { get; set; }
        public int CodigoMoneda { get; set; }
        public string StrMoneda { get { return Enum<Moneda>.GetCollection().Count(x => x.Value == CodigoMoneda.ToString()) == 0 ? "" : ((Moneda)CodigoMoneda).GetAttributeOfType<DescriptionAttribute>().Description; } }
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
        public bool FlagEmitido { get; set; }
        public bool FlagActivo { get; set; }

        public List<FacturaVentaDetalleBe> ListaFacturaVentaDetalle { get; set; }
        public int[] ListaFacturaVentaDetalleEliminar { get; set; }

        public List<LetraBe> ListaLetra { get; set; }
    }
}
