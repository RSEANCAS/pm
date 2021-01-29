using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ResultadoBe
    {
        public class Letra
        {
            public int NroFila { get; set; }
            public int NroLetra { get; set; }
            public int? NroLetraInicial { get; set; }
            public string Banco { get; set; }
            public string CodigoUnico { get; set; }
            public string TipoComprobante { get; set; }
            public string SerieRef { get; set; }
            public int NroRef { get; set; }
            public DateTime FechaEmision { get; set; }
            public string FechaVencimiento { get; set; }
            public int Dias { get; set; }
            public int DiasPorVencer { get; set; }
            public int DiasDeVencido { get; set; }
            public string TipoDocumentoIdentidadCliente { get; set; }
            public string NroDocumentoIdentidadCliente { get; set; }
            public string NombreCompletosCliente { get; set; }
            public string Moneda { get; set; }
            public decimal Monto { get; set; }
            public decimal Mora { get; set; }
            public decimal Protesto { get; set; }
            public decimal Total { get; set; }
            public decimal? TotalAnterior { get; set; }
            public decimal? TotalInicial { get; set; }
            public string Estado { get; set; }
            public bool Cancelado { get; set; }
            public bool Activo { get; set; }




        }
    }
}
