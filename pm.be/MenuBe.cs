using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class MenuBe : BaseAuditoria
    {
        public int CodigoMenu { get; set; }
        public string Nombre { get; set; }
        public string Formulario { get; set; }
        public int? CodigoMenuPadre { get; set; }
        public MenuBe MenuPadre { get; set; }
        public List<MenuBe> ListaMenu { get; set; }
    }
}
