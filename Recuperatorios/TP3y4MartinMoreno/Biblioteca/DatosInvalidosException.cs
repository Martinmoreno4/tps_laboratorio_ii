﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DatosInvalidosException : Exception
    {
        public DatosInvalidosException(string message) : base(message)
        {
        }


    }
}
