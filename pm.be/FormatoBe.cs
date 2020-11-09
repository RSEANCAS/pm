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
    public class FormatoBe
    {
        public class Letra
        {
            public int Numero { get; set; }
            public DateTime FechaGiro { get; set; }
            public string LugarGiro { get; set; }
            public DateTime FechaVencimiento { get; set; }
            public int CodigoMoneda { get; set; }
            public string StrMoneda { get { return Enum<Moneda>.GetCollection().Count(x => x.Value == CodigoMoneda.ToString()) == 0 ? "" : ((Moneda)CodigoMoneda).GetAttributeOfType<DescriptionAttribute>().Description; } }
            public string SimboloMoneda { get { return Enum<Moneda>.GetCollection().Count(x => x.Value == CodigoMoneda.ToString()) == 0 ? "" : ((Moneda)CodigoMoneda).GetAttributeOfType<DefaultValueAttribute>().Value.ToString(); } }
            public decimal Importe { get; set; }
            public string ImporteEnLetras { get; set; }
            public string RucCliente { get; set; }
            public string NombresCliente { get; set; }
            public string DireccionCliente { get; set; }
            public string LocalidadCliente { get; set; }
            public string TelefonoCliente { get; set; }
            public string NroDocIdentidadAval { get; set; }
            public string NombresAval { get; set; }
            public string DireccionAval { get; set; }
            public string LocalidadAval { get; set; }
            public string TelefonoAval { get; set; }
        }
    }
}