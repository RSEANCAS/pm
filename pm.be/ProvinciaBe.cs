using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ProvinciaBe
    {
        public int CodigoProvincia { get; set; }
        public int CodigoDepartamento { get; set; }
        public DepartamentoBe Departamento { get; set; }
        public string CodigoUbigeo { get; set; }
        public string Nombre { get; set; }
        public override string ToString() => Nombre;
    }
}
