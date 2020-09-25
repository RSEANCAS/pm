using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.enums
{
    public class Enums
    {
        public enum EstadoPersonal
        {
            [Description("Activo")]
            Activo = 1,
            [Description("Inactivo")]
            Inactivo = 2
        }

        public enum EstadoProducto
        {
            [Description("Activo")]
            Activo = 1,
            [Description("Sin Stock")]
            SinStock = 2

        }

        public enum Moneda
        {
            [Description("Soles")]
            [DefaultValue("S/")]
            Soles = 1,
            [Description("Dólares")]
            [DefaultValue("$")]
            Dolares = 2
        }

        public enum TipoComprobante
        {
            [Description("Boleta")]
            Boleta = 1,
            [Description("Factura")]
            Factura = 2,
            [Description("Nota de crédito")]
            NotaCredito = 3,
            [Description("Nota de débito")]
            NotaDebito = 4,
            [Description("Guía Remisión Remitente")]
            GuiaRemisionRemitente = 5,
            [Description("Guía Remisión Transportista")]
            GuiaRemisionTransportista = 6
        }

        public enum TipoDocumento
        {
            [Description("Letra")]
            Letra = 1
        }

        public enum TipoCalculo
        {
            [Description("Valor Unitario")]
            ValorUnitario = 1,
            [Description("Precio Unitario")]
            PrecioUnitario = 2,
            [Description("Importe Total")]
            TotalImporte = 3
        }

        public enum TipoDescuento
        {
            [Description("Porcentaje Descuento")]
            Porcentaje = 1,
            [Description("Descuento")]
            Descuento = 2
        }

        public enum MetodoPago
        {
            [Description("Contado")]
            Contado = 1,
            [Description("Crédito")]
            Credito = 2
        }
    }
}
