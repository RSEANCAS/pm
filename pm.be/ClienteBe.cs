using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ClienteBe : BaseAuditoria
    {
        public int CodigoCliente { get; set; }
        public int CodigoTipoDocumentoIdentidad { get; set; }
        public TipoDocumentoIdentidadBe TipoDocumentoIdentidad { get; set; }
        public string NroDocumentoIdentidad { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int? CodigoActividadPrincipal { get; set; }
        public ActividadBe ActividadPrincipal { get; set; }
        public string Contacto { get; set; }
        public string AreaContacto { get; set; }
        public bool FlagActivo { get; set; }
    }
}
