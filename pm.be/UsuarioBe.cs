﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm.be
{
    public class UsuarioBe : BaseAuditoria
    {
        public int CodigoUsuario { get; set; }
        public byte[] Contraseña { get; set; }
        public int CodigoPersonal { get; set; }
        public PersonalBe Personal { get; set; }
    }
}