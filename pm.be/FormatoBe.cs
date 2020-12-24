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
    public class FormatoBe
    {
        public class Letra
        {
            public int Numero { get; set; }
            public DateTime FechaGiro { get; set; }
            public string LugarGiro { get; set; }
            public DateTime FechaVencimiento { get; set; }
            public int CodigoMoneda { get; set; }
            public string StrMoneda { get { return Enum<Moneda>.GetCollection().Count(x => x.Value == CodigoMoneda.ToString()) == 0 ? "" : ((Moneda)CodigoMoneda).GetAttributeOfType<DescriptionAttribute>().Description; } }
            public string SimboloMoneda { get { return Enum<Moneda>.GetCollection().Count(x => x.Value == CodigoMoneda.ToString()) == 0 ? "" : ((Moneda)CodigoMoneda).GetAttributeOfType<DefaultValueAttribute>().Value.ToString(); } }
            public decimal Importe { get; set; }
            public string ImporteEnLetras { get; set; }
            public string RucCliente { get; set; }
            public string NombresCliente { get; set; }
            public string DireccionCliente { get; set; }
            public string LocalidadCliente { get; set; }
            public string TelefonoCliente { get; set; }
            public string NroDocIdentidadAval { get; set; }
            public string NombresAval { get; set; }
            public string DireccionAval { get; set; }
            public string LocalidadAval { get; set; }
            public string TelefonoAval { get; set; }
        }

        public class GuiaRemision
        {
            public string Serie { get; set; }
            public int Numero { get; set; }
            public DateTime FechaEmision { get; set; }
            public DateTime FechaTraslado { get; set; }
            public string NroPedido { get; set; }
            public string NombresVendedor { get; set; }
            public string DireccionPartida { get; set; }
            public string DistritoPartida { get; set; }
            public string ProvinciaPartida { get; set; }
            public string DepartamentoPartida { get; set; }
            public string DireccionLlegada { get; set; }
            public string DistritoLlegada { get; set; }
            public string ProvinciaLlegada { get; set; }
            public string DepartamentoLlegada { get; set; }
            public string RazonSocialDestinatario { get; set; }
            public string TipoDocumentoIdentidadDestinatario { get; set; }
            public string TelefonoDestinatario { get; set; }
            public string MarcaVehiculo { get; set; }
            public string PlacaVehiculo { get; set; }
            public string MTCVehiculo { get; set; }
            public string LicenciaVehiculo { get; set; }
            public string NombresTransportista { get; set; }
            public string NroDocumentoIdentidadTransportista { get; set; }
            public string MotivoTraslado { get; set; }
        }

        public class GuiaRemisionDetalle
        {
            public string Codigo { get; set; }
            public decimal Cantidad { get; set; }
            public string UnidadMedida { get; set; }
            public string Descripcion { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal Peso { get; set; }
            public decimal CostoMinimoTraslado { get; set; }
        }

        public class Factura
        {
            public string Serie { get; set; }
            public int Correlativo { get; set; }
            public DateTime FechaEmision { get; set; }
            public DateTime FechaVencimiento { get; set; }
            public string NroDocumentoIdentidadCliente { get; set; }
            public string NombresCompletoCliente { get; set; }
            public string DireccionCliente { get; set; }
            public string TelefonoCliente { get; set; }
            public string CondicionPago { get; set; }
            public decimal TipoCambio { get; set; }
            public string AgenciaTransporte { get; set; }
            public string NroPedido { get; set; }
            public string NroGuia { get; set; }
            public string OrdenCompra { get; set; }
            public string SimboloMoneda { get; set; }
            public decimal TotalGravada { get; set; }
            public decimal TotalInafecta { get; set; }
            public decimal TotalExonerada { get; set; }
            public decimal TotalExportacion { get; set; }
            public decimal TotalIGV { get; set; }
            public decimal TotalImporte { get; set; }
            public decimal TotalPercepcion { get; set; }
            public decimal TotalPagar { get; set; }
            public string TotalEnLetras { get; set; }
            public byte[] QR { get; set; }
            public string Hash { get; set; }

            public List<FacturaDetalle> ListaDetalle { get; set; }
        }

        public class FacturaDetalle
        {
            public string Codigo { get; set; }
            public string Articulo { get; set; }
            public decimal Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal Importe { get; set; }
        }

        public class Boleta
        {
            public string Serie { get; set; }
            public int Correlativo { get; set; }
            public DateTime FechaEmision { get; set; }
            public DateTime FechaVencimiento { get; set; }
            public string NroDocumentoIdentidadCliente { get; set; }
            public string NombresCompletoCliente { get; set; }
            public string DireccionCliente { get; set; }
            public string TelefonoCliente { get; set; }
            public string CondicionPago { get; set; }
            public decimal TipoCambio { get; set; }
            public string AgenciaTransporte { get; set; }
            public string NroPedido { get; set; }
            public string NroGuia { get; set; }
            public string OrdenCompra { get; set; }
            public string SimboloMoneda { get; set; }
            public decimal TotalGravada { get; set; }
            public decimal TotalInafecta { get; set; }
            public decimal TotalExonerada { get; set; }
            public decimal TotalExportacion { get; set; }
            public decimal TotalIGV { get; set; }
            public decimal TotalImporte { get; set; }
            public decimal TotalPercepcion { get; set; }
            public decimal TotalPagar { get; set; }
            public string TotalEnLetras { get; set; }
            public byte[] QR { get; set; }
            public string Hash { get; set; }

            public List<BoletaDetalle> ListaDetalle { get; set; }
        }

        public class BoletaDetalle
        {
            public string Codigo { get; set; }
            public string Articulo { get; set; }
            public decimal Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal Importe { get; set; }
        }
    }
}