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
    public class ComprobantePagoBe : BaseAuditoria
    {
        public int CodigoComprobantePago { get; set; }
        public DateTime FechaHoraPago { get; set; }
        public int CodigoSerie { get; set; }
        public SerieBe Serie { get; set; }
        public int NroComprobante { get; set; }
        public int CodigoMoneda { get; set; }
        public string StrMoneda { get { return Enum<Moneda>.GetCollection().Count(x => x.Value == CodigoMoneda.ToString()) == 0 ? "" : ((Moneda)CodigoMoneda).GetAttributeOfType<DescriptionAttribute>().Description; } }
        public int CodigoCliente { get; set; }
        public ClienteBe Cliente { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public bool FlagAnulado { get; set; }
        public bool FlagEliminado { get; set; }

        public List<ComprobantePagoDetalleBe> ListaComprobantePagoDetalle { get; set; }
        public int[] ListaComprobantePagoDetalleEliminar { get; set; }
    }
}
