using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class GuiaRemisionBe : BaseComprobante//BaseAuditoria
    {
        public int CodigoGuiaRemision { get; set; }
        public int CodigoTipoComprobante { get; set; }
        public TipoComprobanteBe TipoComprobante { get; set; }
        public DateTime FechaHoraTraslado { get; set; }
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
        public int? CodigoCotizacion { get; set; }
        public CotizacionBe Cotizacion { get; set; }
        public bool FlagEmitido { get; set; }
        public bool FlagActivo { get; set; }

        public List<GuiaRemisionDetalleBe> ListaGuiaRemisionDetalle { get; set; }
        public int[] ListaGuiaRemisionDetalleEliminar { get; set; }
    }
}
