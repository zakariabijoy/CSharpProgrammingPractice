using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        /// <summary>
        /// declaring delegate 
        /// The syntax for defining a delegate: <Access Modifier> delegate <return type> <delegate name> (arguments list);
        /// </summary>
        public delegate void MentionDiscount(decimal subTotal);

        public List<ProductModel> Items { get; set; } = new List<ProductModel>();


        /// <summary>
        /// Delegates for call back methods
        /// Here this method takes 3 delegate types as  parameters and we have to pass  there methods as  arguments with corresponding signature of delegate
        /// </summary>
        /// <param name="mentionSubtotal"> Delegate</param>
        /// <param name="calculateDiscountedTotal">Func Delegate </param>
        /// <param name="tellUserWeAreDiscounting"> Action Delegate</param>
        /// <returns> this method return total which is decimal type </returns>
        public decimal GenerateTotal(MentionDiscount mentionSubtotal,
            Func<List<ProductModel>,decimal,decimal> calculateDiscountedTotal,    
            Action<string> tellUserWeAreDiscounting)    
        {
            decimal subTotal = Items.Sum(x => x.Price);

            mentionSubtotal(subTotal);

            tellUserWeAreDiscounting("We are applying your discount.");

            decimal total = calculateDiscountedTotal(Items, subTotal);

            return total;
        }
    }
}
