using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Paquete : ItemFacturable
    {
        List<ItemFacturable> _items = new List<ItemFacturable>();

        public override decimal PrecionOriginal { get => _items.Sum(o => o.PrecionOriginal); set => _items.ForEach(p=>p.PrecionOriginal = value); }

        public override decimal CalcularPrecio()
        {
            decimal total = _items.Sum(p => p.PrecionOriginal);
            return  total - (total * 0.2m);
        }

        public void AddItem(ItemFacturable item)
        {
            _items.Add(item);
        }

        public void RemoveItem(ItemFacturable item)
        {
            _items.Remove(item);
        }

    }
}
