using System;

namespace ExtenstionMethod
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int muba = 1;
           

           var sumResult =  b.Sum(muba);

            Console.WriteLine(sumResult);

            var mubaMal = muba.Mul(a, b);

            Console.WriteLine(mubaMal);



        }


    }
}
