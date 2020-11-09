using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class MotivoNotaBe : BaseAuditoria
    {
        public int CodigoMotivoNota { get; set; }
        public string Descripcion { get; set; }
        public int CodigoTipoComprobante { get; set; }
        public TipoComprobanteBe TipoComprobante { get; set; }
        public bool FlagActivo { get; set; }
        public override string ToString() => Descripcion;
    }
}
