using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void HelloFunctionDelegate(string Message); 

namespace @delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("hello from delegate");

        }

        public static void Hello(String strMessage)
        {
            Console.WriteLine(strMessage);
            Console.ReadKey();
        }
       
    }  
    
   
}
