using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    abstract class AbstractIterator<T>
    {
        public abstract void MoveFirst();
        public abstract void MoveLast();
        public abstract void MoveNext();
        public abstract void MovePrevious();
        public abstract T CurrentItem();
        public int SetStep { get; set; }

    }
}
