using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class BaseComprobante : BaseAuditoria
    {
        public int CodigoSerie { get; set; }
        public SerieBe Serie { get; set; }
        // NO MAPEADO EN BD
        public string StrSerie { get; set; }
        public int NroComprobante { get; set; }
        public DateTime FechaHoraEmision { get; set; }

        public int CodigoCliente { get; set; }
        public ClienteBe Cliente { get; set; }
        // NO MAPEADO EN BD
        public string NroDocumentoIdentidadCliente { get; set; }
        // NO MAPEADO EN BD
        public string NombresCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string NombrePaisCliente { get; set; }
        public string NombreDepartamentoCliente { get; set; }
        public string NombreProvinciaCliente { get; set; }
        public int CodigoDistritoCliente { get; set; }
        public string NombreDistritoCliente { get; set; }
        public DistritoBe DistritoCliente { get; set; }
        // NO MAPEADO EN BD
        public int CodigoTipoDocumentoIdentidadCliente { get; set; }
        // NO MAPEADO EN BD
        public TipoDocumentoIdentidadBe TipoDocumentoIdentidadCliente { get; set; }
        // NO MAPEADO EN BD
        public string DescripcionTipoDocumentoIdentidadCliente { get; set; }

        public List<dynamic> ListaDetalle { get; set; }
    }
}
