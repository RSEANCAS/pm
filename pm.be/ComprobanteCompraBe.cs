using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ComprobanteCompraBe : BaseAuditoria
    {
        public int CodigoComprobanteCompra { get; set; }
        public DateTime FechaHoraRegistro { get; set; }
        public DateTime FechaCompra { get; set; }
        public int CodigoTipoComprobante { get; set; }
        public TipoComprobanteBe TipoComprobante { get; set; }
        public string Serie { get; set; }
        public int Numero { get; set; }
        public int CodigoProveedor { get; set; }
        public ProveedorBe Proveedor { get; set; }
        // NO MAPEADO EN BD
        public string DescripcionTipoDocumentoIdentidadProveedor { get; set; }
        // NO MAPEADO EN BD
        public string NroDocumentoIdentidadProveedor { get; set; }
        public string SerieGuia { get; set; }
        public int NumeroGuia { get; set; }
        public decimal TotalImporte { get; set; }
        public bool FlagCompleto { get; set; }
        public bool FlagActivo { get; set; }

        public List<ComprobanteCompraDetalleBe> ListaComprobanteCompraDetalle { get; set; }
        public int[] ListaComprobanteCompraDetalleEliminar { get; set; }

        public List<ProductoIndividualBe> ListaProductoIndividual { get; set; }
    }
}