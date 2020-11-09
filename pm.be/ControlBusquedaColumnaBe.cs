using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class ControlBusquedaColumnaBe
    {
        public int CodigoControlBusquedaColumna { get; set; }
		public int CodigoControlBusqueda { get; set; }
		public string CampoBD { get; set; }
		public string NombreAtributo { get; set; }
		public string Titulo { get; set; }
		public string Formato { get; set; }
		public bool EsVisible { get; set; }
		public string TipoColumna { get; set; }
		public bool EsFiltro { get; set; }
		public int Ancho { get; set; }
	}
}
