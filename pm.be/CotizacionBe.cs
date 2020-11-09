using pm.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static pm.enums.Enums;

namespace pm.be
{
    public class CotizacionBe : BaseAuditoria
    {
        public int CodigoCotizacion { get; set; }
        public int NroComprobante { get; set; }
        public DateTime FechaHoraEmision { get; set; }
        public string NroPedido { get; set; }
        public int CodigoCliente { get; set; }
        public ClienteBe Cliente { get; set; }
        // NO MAPEADO EN BD
        public string NroDocumentoIdentidadCliente { get; set; }
        // NO MAPEADO EN BD
        public string DescripcionTipoDocumentoIdentidadCliente { get; set; }
        public int CodigoVendedor { get; set; }
        public PersonalBe Vendedor { get; set; }
        // NO MAPEADO EN BD
        public string NroDocumentoIdentidadVendedor { get; set; }
        // NO MAPEADO EN BD
        public string DescripcionTipoDocumentoIdentidadVendedor { get; set; }
        public int CodigoMoneda { get; set; }
        public string StrMoneda { get { return Enum<Moneda>.GetCollection().Count(x => x.Value == CodigoMoneda.ToString()) == 0 ? "" : ((Moneda)CodigoMoneda).GetAttributeOfType<DescriptionAttribute>().Description; } }
        public decimal TotalImporte { get; set; }
        public bool FlagActivo { get; set; }

        public List<CotizacionDetalleBe> ListaCotizacionDetalle { get; set; }
        public int[] ListaCotizacionDetalleEliminar { get; set; }
    }
}
