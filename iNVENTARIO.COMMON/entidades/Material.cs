﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNVENTARIO.COMMON.entidades
{
    
    public  class Material:Base
    {
        
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Decripccion { get; set; }
        public byte[] Fotografia { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1}", Categoria, Nombre);
        }
    }
}
