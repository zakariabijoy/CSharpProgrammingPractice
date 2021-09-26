using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningAShoppingCart_oop_
{
    public class GiftCard : IPurchasable
    {
        public string Name { get ; set ; }
        public double Price { get ; set ; }
        public string ImageFileName { get; set; }
        public string ReceiverEmailAddress { get; set; }
    }
}
