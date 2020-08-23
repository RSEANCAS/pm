using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.enums
{
    public class Enums
    {
        public enum EstadoProducto
        {
            [Description("Activo")]
            Activo = 1,
            [Description("Sin Stock")]
            SinStock = 2

        }

        public enum EstadoPersonal
        {
            [Description("Activo")]
            Activo = 1,
            [Description("Inactivo")]
            Inactivo = 2
        }
    }
}
