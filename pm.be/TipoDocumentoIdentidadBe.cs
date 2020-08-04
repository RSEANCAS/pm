using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class TipoDocumentoIdentidadBe : BaseAuditoria
    {
        public int CodigoTipoDocumentoIdentidad { get; set; }
        public string Descripcion { get; set; }
    }
}
