using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class PersonalBe : BaseAuditoria
    {
        public int CodigoPersonal { get; set; }
        public int CodigoTipoDocumentoIdentidad { get; set; }
        public TipoDocumentoIdentidadBe TipoDocumentoIdentidad { get; set; }
        public string NroDocumentoIdentidad { get; set; }
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public int CodigoArea { get; set; }
        public AreaBe Area { get; set; }
        public bool FlagActivo { get; set; }
        public int Estado { get; set; }
    }
}
