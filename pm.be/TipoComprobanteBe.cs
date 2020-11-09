using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class TipoComprobanteBe
    {
        public int CodigoTipoComprobante { get; set; }
        public string Nombre { get; set; }
        public string CodigoSunat { get; set; }
        public override string ToString() => Nombre;
    }
}
