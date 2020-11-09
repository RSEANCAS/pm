using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ProveedorBe : BaseAuditoria
    {
        public int CodigoProveedor { get; set; }
        public int CodigoTipoDocumentoIdentidad { get; set; }
        public TipoDocumentoIdentidadBe TipoDocumentoIdentidad { get; set; }
        public string StrTipoDocumentoIdentidad { get; set; }
        public string NroDocumentoIdentidad { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public int CodigoDistrito { get; set; }
        public DistritoBe Distrito { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Contacto { get; set; }
        public bool FlagActivo { get; set; }

        public override string ToString() => Nombres;
    }
}
