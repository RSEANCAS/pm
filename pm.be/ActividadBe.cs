using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ActividadBe : BaseAuditoria
    {
        public int CodigoActividad { get; set; }
        public string Nombre { get; set; }
        public bool FlagActivo { get; set; }

        public override string ToString() => Nombre;
    }
}
