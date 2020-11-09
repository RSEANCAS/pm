using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ControlBusquedaBe
    {
        public int CodigoControlBusqueda { get; set; }
        public string Formulario { get; set; }
        public string Control { get; set; }
        public string FromTables { get; set; }
        public string WhereMain { get; set; }
        public string TituloFormulario { get; set; }
        public string TipoObjeto { get; set; }
        public List<ControlBusquedaColumnaBe> ListaControlBusquedaColumna { get; set; }
    }
}
