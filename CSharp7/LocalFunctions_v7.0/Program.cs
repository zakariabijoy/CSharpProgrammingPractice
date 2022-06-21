using System;

namespace LocalFunctions_v7._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LocalFunctionFactorial(5));
        }

        public static int LocalFunctionFactorial(int n)
        {
            return nthFactorial(n);

            int nthFactorial(int number) => number < 2
                ? 1
                : number * nthFactorial(number - 1);
        }
    }
}
