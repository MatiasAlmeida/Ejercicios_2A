﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo.Parcial.Facil
{
    class CajonLlenoException : Exception
    {
        public CajonLlenoException(string mensaje) : base(mensaje) { }
    }
}
