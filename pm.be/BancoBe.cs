using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class BancoBe : BaseAuditoria
    {
        public int CodigoBanco { get; set; }
        public string Nombre { get; set; }
        public bool FlagActivo { get; set; }
    }
}
