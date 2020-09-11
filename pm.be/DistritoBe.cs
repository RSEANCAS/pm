using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class DistritoBe
    {
        public int CodigoDistrito { get; set; }
        public int CodigoProvincia { get; set; }
        public ProvinciaBe Provincia { get; set; }
        public string CodigoUbigeo { get; set; }
        public string Nombre { get; set; }
        public override string ToString() => Nombre;
    }
}
