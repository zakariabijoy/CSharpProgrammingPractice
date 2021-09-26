using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //interface
    public interface IProductModel    
    {
        string Title { get; set; }  // interface property 

        bool HasOrderBeenCompleted { get; }  // interface property 

        void ShipItem(CustomerModel customer);   // interface method (does not have a body)
    }
}
