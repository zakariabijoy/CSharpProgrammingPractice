using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningAShoppingCart_oop_
{
    public class ShoppingCart
    {
        private List<CartItem> _items;
        public IReadOnlyCollection<CartItem> Items { get => new ReadOnlyCollection<CartItem>(_items); }

        public ShoppingCart()
        {
            _items = new List<CartItem>();
        }

        public CartItem this[int index] { get => _items[index]; }
        public CartItem this[string index] { get => _items.FirstOrDefault(i=>i.Item.Name==index); }

        public void AddItem(CartItem item)
        {
            _items.Add(item);
        }
        public void ClearCart()
        {
            _items.Clear();
        }
        public void RemoveItem(CartItem item)
        {
            if (_items.Contains(item))
            {
                _items.Remove(item);
            }
        }

        public double Total
        {
            get
            {
                double total = 0;
                foreach (var item in _items)
                {
                    total += item.Item.Price * item.Quantity;
                }
                return total;
            }
        }
    }
}
