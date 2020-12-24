using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class TipoCambioBe : BaseAuditoria
    {
        public int CodigoTipoCambio { get; set; }
        public DateTime FechaCambio { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorCompra { get; set; }
    }
}
