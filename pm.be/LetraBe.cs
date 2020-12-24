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
    public class LetraBe : BaseAuditoria
    {
        public int CodigoLetra { get; set; }
        public int Numero { get; set; }
        public DateTime FechaHoraEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Dias { get; set; }
        public int CodigoTipoComprobanteRef { get; set; }
        public TipoComprobanteBe TipoComprobanteRef { get; set; }
        public int CodigoComprobanteRef { get; set; }
        public int CodigoSerieComprobanteRef { get; set; }
        public string SerialSerieComprobanteRef { get; set; }
        public int NroComprobanteComprobanteRef { get; set; }
        public int? CodigoGuiaRemision { get; set; }
        public int? CodigoSerieGuiaRemision { get; set; }
        public string SerialSerieGuiaRemision { get; set; }
        public int? NroComprobanteGuiaRemision { get; set; }
        public int CodigoCliente { get; set; }
        public ClienteBe Cliente { get; set; }
        public int? CodigoBanco { get; set; }
        public BancoBe Banco { get; set; }
        public string CodigoUnicoBanco { get; set; }
        public int CodigoMoneda { get; set; }
        public string StrMoneda { get { return Enum<Moneda>.GetCollection().Count(x => x.Value == CodigoMoneda.ToString()) == 0 ? "" : ((Moneda)CodigoMoneda).GetAttributeOfType<DescriptionAttribute>().Description; } }
        public decimal Monto { get; set; }
        public decimal Mora { get; set; }
        public decimal Protesto { get; set; }
        public decimal Total { get { return Monto + Mora + Protesto; } }
        public int? Estado { get; set; }
        public string StrEstado { get { return Estado == null ? "" : Enum<EstadoLetra>.GetCollection().FirstOrDefault(x => x.Value == Estado.Value.ToString()).Text; } }
        public string Observacion { get; set; }
        public int? CodigoLetraPadre { get; set; }
        public LetraBe LetraPadre { get; set; }
        public int? CodigoLetraInicial { get; set; }
        public LetraBe LetraInicial { get; set; }
        public bool FlagAval { get; set; }
        public int? CodigoAval { get; set; }
        public ClienteBe Aval { get; set; }
        // NO MAPEADO EN BD
        public string NroDocumentoIdentidadAval { get; set; }
        // NO MAPEADO EN BD
        public string NombresAval { get; set; }
        public string DireccionAval { get; set; }
        public string NombrePaisAval { get; set; }
        public string NombreDepartamentoAval { get; set; }
        public string NombreProvinciaAval { get; set; }
        public int CodigoDistritoAval { get; set; }
        public string NombreDistritoAval { get; set; }
        public DistritoBe DistritoAval { get; set; }
        // NO MAPEADO EN BD
        public int CodigoTipoDocumentoIdentidadAval { get; set; }
        // NO MAPEADO EN BD
        public TipoDocumentoIdentidadBe TipoDocumentoIdentidadAval { get; set; }
        // NO MAPEADO EN BD
        public string DescripcionTipoDocumentoIdentidadAval { get; set; }
        public bool FlagCancelado { get; set; }
        public bool FlagActivo { get; set; }
        public bool FlagEliminado { get; set; }
    }
}
