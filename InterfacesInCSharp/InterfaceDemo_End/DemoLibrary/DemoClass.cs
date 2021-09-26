using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    // Implement multiple interfaces
    public class DemoClass : IFirstInterface, ISecondInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("Some text..");
        }

        public void MyOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }
}
