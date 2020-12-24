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

        public enum EstadoLetra
        {
            [Description("Por Asignar Banco")]
            PorAsignarBanco = 1,
            [Description("Pendiente")]
            Pendiente = 2,
            [Description("Renovada")]
            Renovada = 3,
            [Description("Retirada")]
            Retirada = 4,
            [Description("Protestada")]
            Protestada = 5
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
            GuiaRemisionTransportista = 6,
            [Description("Comprobante de Pago")]
            ComprobantePago = 7
        }

        public enum TipoDocumento
        {
            [Description("Letra")]
            Letra = 1
        }

        public enum TipoDocumentoIdentidad
        {
            [Description("DNI")]
            DNI = 1,
            [Description("RUC")]
            RUC = 2,
            [Description("CARNET EXTRANJERIA")]
            CE = 3,
            [Description("PASAPORTE")]
            PASAPORTE = 4,
            [Description("PARTIDA NACIMIENTO")]
            PARTIDANAC = 5,
            [Description("OTROS")]
            OTROS = 6,
            [Description("SIN DOCUMENTO")]
            SINDOCUMENTO = 7
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

        public enum TipoDocumentoPago
        {
            [Description("Factura")]
            Factura = 1,
            [Description("Letra")]
            Letra = 2,
            [Description("Boleta")]
            Boleta = 3
        }
    }
}
