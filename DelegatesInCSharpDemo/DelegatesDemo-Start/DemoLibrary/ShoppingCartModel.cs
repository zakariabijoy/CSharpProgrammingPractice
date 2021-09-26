using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subtotal);
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();
        
        public decimal GenerateTotal(MentionDiscount mentionSubtotal,
            Func<List<ProductModel>, decimal, decimal> calculateDiscountTotal,
            Action<string> tellUserAreDiscounting)
        {
            decimal subtotal = Items.Sum(x => x.Price);

            mentionSubtotal(subtotal);
            tellUserAreDiscounting("We are apply your discount");

            return calculateDiscountTotal(Items, subtotal);
            
        }
    }
}
