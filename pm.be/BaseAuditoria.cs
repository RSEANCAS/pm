using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class BaseAuditoria
    {
        public string UsuarioGraba { get; set; }
        public DateTime FechaGraba { get; set; }
        public string UsuarioModi { get; set; }
        public DateTime FechaModi { get; set; }
    }
}
