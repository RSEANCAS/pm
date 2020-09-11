using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace pm.be
{
    public class BaseComprobante : BaseAuditoria
    {
        public int CodigoSerie { get; set; }
        public SerieBe Serie { get; set; }
        public int NroComprobante { get; set; }
        public DateTime FechaHoraEmision { get; set; }
    }
}
