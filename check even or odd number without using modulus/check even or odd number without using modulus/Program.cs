using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_even_or_odd_number_without_using_modulus
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double x = Convert.ToDouble(Console.ReadLine());
            if ((x + 1) / 2 == x / 2)
            {
                Console.WriteLine("its a odd number");

            }
           
            else 
            {
                Console.WriteLine("its a even number");
            }
             
            
            

        }
    }
}
