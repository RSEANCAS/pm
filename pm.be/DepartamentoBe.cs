using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class DepartamentoBe
    {
        public int CodigoDepartamento { get; set; }
        public int CodigoPais { get; set; }
        public PaisBe Pais { get; set; }
        public string CodigoUbigeo { get; set; }
        public string Nombre { get; set; }
        public override string ToString() => Nombre;
    }
}
