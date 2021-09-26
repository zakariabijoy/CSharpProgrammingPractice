using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethods
{
    class ShopingCart : IEnumerable, ICloneable, IDisposable
    {
        public int TotalAmmount { get; set; }
        public int Count { get; set; }
        private ArrayList arrayList = new ArrayList();
        private readonly Item[] _items;

        public ShopingCart(Item[] items)
        {
            _items = new Item[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                _items[i] = items[i];
            }
        }
        public void AddItem()
        {
            arrayList.Add(1);
            Count++;
        }
        public void RemoveItem()
        {
            arrayList.Add(2);
            Count--;
        }

        public object Clone()
        {
            //return new ShopingCart() { Count = Count, TotalAmmount = TotalAmmount };
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            arrayList.Clear();
        }

        public Item this[int index] { get => _items[index]; set => _items[index] = value; } // indexer 
        public Item this[string index] { get => _items.Where(i => i.Name == index).FirstOrDefault(); set => this[index].Name = value.Name; } // indexer 

        public IEnumerator GetEnumerator()
        {
            return new ItemEnum(_items);
        }
    }
}
