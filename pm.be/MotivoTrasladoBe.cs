﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class MotivoTrasladoBe : BaseAuditoria
    {
        public int CodigoMotivoTraslado { get; set; }
        public string Descripcion { get; set; }
        public bool FlagActivo { get; set; }
        public override string ToString() => Descripcion;
    }
}
