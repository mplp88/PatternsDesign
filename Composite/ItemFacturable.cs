﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite {
    abstract class ItemFacturable {

        public virtual decimal PrecionOriginal { get; set; }
        public abstract decimal CalcularPrecio();
    }
}
