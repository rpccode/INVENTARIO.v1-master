﻿using iNVENTARIO.COMMON.entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNVENTARIO.COMMON.interfaces
{
   public interface IManejadorDeEmpleados:IManejadorGenerico<Empleado>
    {
        List<Empleado> EmpleadoPorArea(string area);
       
    }
}
