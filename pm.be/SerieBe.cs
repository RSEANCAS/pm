using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class SerieBe : BaseAuditoria
    {
        public int CodigoSerie { get; set; }
        public int CodigoTipoComprobante { get; set; }
        public TipoComprobanteBe TipoComprobante { get; set; }
        public string Serial { get; set; }
        public int ValorInicial { get; set; }
        public int ValorFinal { get; set; }
        public int ValorActual { get; set; }
        public bool FlagActivo { get; set; }
        public override string ToString() => Serial;
    }
}
