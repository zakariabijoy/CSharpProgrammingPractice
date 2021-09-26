using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highestMark
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            
            
         

           
            Console.WriteLine("enter the number of student");
            int n=Convert.ToInt32(Console.ReadLine());
            String[] names = new String[n];
            int[] Marks = new int[n];
            int[] Id = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the student ID");
                Id[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("Enter the student name for id "+Id[i]);
                names[i] = Console.ReadLine();
            }
            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("Enter "+names[i]+"marks");
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            if( Marks[0] < Marks[i])
            {
                Console.WriteLine("the highest mark is" + Marks[i] + "by" + names[i] + "id:" + Id[i]);
            }
            else
            {
                Console.WriteLine("the highest mark is" + Marks[0] + "by" + names[i] + "id:" + Id[i]);
            }
            Console.ReadKey();
        }
    }
}
