﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class PerfilBe : BaseAuditoria
    {
        public int CodigoPerfil { get; set; }
        public string Nombre { get; set; }
        public bool FlagActivo { get; set; }
        public List<MenuBe> ListaMenu { get; set; }
        public bool Check { get; set; }
    }
}
