using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.sunat
{
    class ModuloDoc
    {
        public string PasswordSunat { get; set; }
        public string UsuarioSunat { get; set; }
        public string RutaCertificadoDigital { get; set; }
        public string PasswordCertificado { get; set; }
        public string DigestValue { get; set; }
        public string ArchXML { get; set; }
        public object DateAndTime { get; private set; }
        public string numeroFactura { get; set; }
        public string codigoTipoDoc { get; set; }
        public string Serie { get; set; }

        //ruc del cliente
        public string RucCliente { get; set; }
        //nombre del cliente
        public string RazonSocialCliente { get; set; }

        public string IdDoc { get; set; }
        public string Descripcion { get; set; }
        public string ResponseCode { get; set; }

        //nombre del empresa
        public string RazonSocialEmpresa { get; set; }
        // ruc empresa
        public string RucEmpresa { get; set; }

        public decimal MontPrecTotal { get; set; }

        public decimal TotalDescuentoDetallado { get; set; }
        public string ResultadoQR { get; set; }

        public string Codigohas { get; set; }

        public string TotalCostoLetras { get; set; }

        public string codigoItems { get; set; }// UNIDAD DE MEDIDA 
        public string DescripcionItems { get; set; }
        public decimal CantidadItems { get; set; }//CANTIDAD
        public decimal PrecioUnitarioItems { get; set; }
        public decimal DescuentoItems { get; set; }
        public decimal ImporteTotalDetalle { get; set; }
        public decimal PrecioIgv { get; set; }



        public string SerieRf { get; set; }
        public string numeroDocRf { get; set; }
        public string MotivoDescripcionNota { get; set; }
    }
}
