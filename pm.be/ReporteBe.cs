using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ReporteBe
    {
        public class Letra
        {
            public int Numero { get; set; }
            public DateTime FechaVencimiento { get; set; }
            public string NroDocIdentidadCliente { get; set; }
            public string NombresCompletosCliente { get; set; }
            public string Ubigeo { get; set; }
            public string Departamento { get; set; }
            public string Provincia { get; set; }
            public string Distrito { get; set; }
            public string Moneda { get; set; }
            public decimal Importe { get; set; }
            public string ComprobanteGuia { get; set; }
            public string ComprobanteFactura { get; set; }

        }

        public class Comision
        {
            public string NombrePersonal { get; set; }
            public string TipoPersonal { get; set; }
            public decimal PorcentajeComision { get; set; }
            public int CantidadVentas { get; set; }
            public decimal TotalVentasSinIgv { get; set; }
            public decimal TotalVentasConIgv { get; set; }
            public decimal TotalComision { get; set; }
        }
    }
}
