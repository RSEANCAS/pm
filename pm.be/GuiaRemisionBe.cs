using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class GuiaRemisionBe : BaseAuditoria
    {
        public int CodigoGuiaRemision { get; set; }
        public int CodigoTipoComprobante { get; set; }
        public TipoComprobanteBe TipoComprobante { get; set; }
        public int CodigoSerie { get; set; }
        public SerieBe Serie { get; set; }
        public int NroComprobante { get; set; }
        public DateTime FechaHoraEmision { get; set; }
        public DateTime FechaHoraTraslado { get; set; }
        public int CodigoCliente { get; set; }
        public ClienteBe Cliente { get; set; }
        // NO MAPEADO EN BD
        public string NroDocumentoIdentidadCliente { get; set; }
        // NO MAPEADO EN BD
        public string DescripcionTipoDocumentoIdentidadCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string NombrePaisCliente { get; set; }
        public string NombreDepartamentoCliente { get; set; }
        public string NombreProvinciaCliente { get; set; }
        public int CodigoDistritoCliente { get; set; }
        public  DistritoBe DistritoCliente { get; set; }
        public string NombreDistritoCliente { get; set; }
        public int CodigoMotivoTraslado { get; set; }
        public MotivoTrasladoBe MotivoTraslado { get; set; }
        public int CodigoTransportista { get; set; }
        public ProveedorBe Transportista { get; set; }
        // NO MAPEADO EN BD
        public string NroDocumentoIdentidadTransportista { get; set; }
        // NO MAPEADO EN BD
        public string DescripcionTipoDocumentoIdentidadTransportista { get; set; }
        public string DireccionTransportista { get; set; }
        public string NombrePaisTransportista { get; set; }
        public string NombreDepartamentoTransportista { get; set; }
        public string NombreProvinciaTransportista { get; set; }
        public int CodigoDistritoTransportista { get; set; }
        public DistritoBe DistritoTransportista { get; set; }
        public string NombreDistritoTransportista { get; set; }
        public string MarcaVehiculoTransportista { get; set; }
        public string PlacaVehiculoTransportista { get; set; }
        public string LicenciaConducirTransportista { get; set; }
        public bool FlagEmitido { get; set; }
        public bool FlagActivo { get; set; }

        public List<GuiaRemisionDetalleBe> ListaGuiaRemisionDetalle { get; set; }
        public int[] ListaGuiaRemisionDetalleEliminar { get; set; }
    }
}
