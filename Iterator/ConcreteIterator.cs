using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ConcreteIterator<T>: AbstractIterator<T>
    {
        List<T> algoIterable;
        int index;

        public ConcreteIterator(List<T> algo)
        {
            algoIterable = algo;
            index = 0;
        }

        public override void MoveFirst()
        {
            index = 0;
        }

        public override void MoveLast()
        {
            index = algoIterable.Count - 1;
        }

        public override void MoveNext()
        {
            index++;
        }

        public override void MovePrevious()
        {
            index--;
        }

        public override T CurrentItem()
        {
            return algoIterable[index];
        }
    }
}
