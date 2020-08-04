using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class UnidadMedidaBe : BaseAuditoria 
    {
        public int CodigoUnidadMedida { get; set; }
        public string Descripcion { get; set; }
        public bool FlagActivo { get; set; }
    }
}
