using System;
using System.Collections.Generic;

namespace changeCaseAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please Give a string  to ChangeCase AndR everse");
            string input = Console.ReadLine();
            ChangeCaseAndReverse(input);
        }

        static public void ChangeCaseAndReverse(string s)
        {
            List<char> output = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')

                    //Convert lowercase to uppercase 
                    output.Add((char)(s[i] - 32));

                else if (s[i] >= 'A' && s[i] <= 'Z')

                    //Convert uppercase to lowercase 
                    output.Add((char)(s[i] + 32));
            }
            var Length = output.Count - 1;
            var reverse = "";
            while (Length >= 0)
            {
                reverse = reverse + output[Length];
                Length--;
            }
            Console.WriteLine(reverse);
        }


    }
}
