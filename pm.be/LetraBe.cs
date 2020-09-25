using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class LetraBe : BaseAuditoria
    {
        public int CodigoLetra { get; set; }
        public int Numero { get; set; }
        public DateTime FechaHoraEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Dias { get; set; }
        public int CodigoTipoComprobanteRef { get; set; }
        public int CodigoSerieRef { get; set; }
        public int NumeroRef { get; set; }
        public int CodigoSerieGuia { get; set; }
        public int NumeroGuia { get; set; }
        public int CodigoCliente { get; set; }
        public ClienteBe Cliente { get; set; }
        public int CodigoBanco { get; set; }
        public BancoBe Banco { get; set; }
        public string CodigoUnicoBanco { get; set; }
        public int CodigoMoneda { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; }
        public bool FlagCancelado { get; set; }
    }
}
