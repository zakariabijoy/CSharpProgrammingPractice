using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
         string []a=new string [n];
            int i;
            for ( i =0;i<n;i++){

                a[i] = Convert.ToString(Console.ReadLine());
            }

            for (i = n; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }



        }
    }
}
