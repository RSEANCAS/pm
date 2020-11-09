using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ConfiguracionValorBe
    {
        public int? CodigoUsuario { get; set; }
        public UsuarioBe Usuario { get; set; }
        public int? CodigoTransportistaGuiaRemision { get; set; }
        public ProveedorBe TransportistaGuiaRemision { get; set; }
        public int? CodigoTipoComprobanteGuiaRemision { get; set; }
        public TipoComprobanteBe TipoComprobanteGuiaRemision { get; set; }
    }
}
