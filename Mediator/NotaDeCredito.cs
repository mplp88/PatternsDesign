﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class NotaDeCredito: IComprobante
    {
        public int Numero {get;set;}
        public string Destinatario { get; set; }
    }
}
