using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethods
{
    class ItemEnum : IEnumerator
    {
        private readonly Item[] _items;
        private int position = -1;
        public ItemEnum(Item[] items)
        {
            _items = items;
        }
        public object Current => _items[position];

        public bool MoveNext()
        {
            position++;
            return position < _items.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
