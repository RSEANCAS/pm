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
    public class ComprobantePagoDetalleBe : BaseAuditoria
    {
        public int CodigoComprobantePagoDetalle { get; set; }
        public int CodigoComprobantePago { get; set; }
        public int CodigoTipoDocumentoPago { get; set; }
        public TipoDocumentoPagoBe TipoDocumentoPago { get; set; }
        public string StrTipoDocumentoPago { get { return Enum<TipoDocumentoPago>.GetCollection().Count(x => x.Value == CodigoTipoDocumentoPago.ToString()) == 0 ? "" : ((TipoDocumentoPago)CodigoTipoDocumentoPago).GetAttributeOfType<DescriptionAttribute>().Description; } }
        public int CodigoDocumentoPago { get; set; }
        public dynamic DocumentoPago { get; set; }
        public dynamic StrDocumentoPago
        {
            get
            {
                string value = null;
                if (!string.IsNullOrEmpty(Descripcion))
                {
                    TipoDocumentoPago? tipoDocumentoPago = Enum<TipoDocumentoPago>.GetCollection().Count(x => x.Value == CodigoTipoDocumentoPago.ToString()) == 0 ? null : ((TipoDocumentoPago?)(TipoDocumentoPago)CodigoTipoDocumentoPago);

                    if (tipoDocumentoPago.HasValue)
                        value = Descripcion.Replace(tipoDocumentoPago.GetAttributeOfType<DescriptionAttribute>().Description, "").Trim();
                }

                return value;
            }

        }
    
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public decimal Mora { get; set; }
        public decimal Protesto { get; set; }
        public decimal Total { get; set; }
        public decimal MontoPagar { get; set; }
        public decimal MoraPagar { get; set; }
        public decimal ProtestoPagar { get; set; }
        public decimal ImportePagar { get; set; }
        public bool FlagEliminado { get; set; }
    }
}