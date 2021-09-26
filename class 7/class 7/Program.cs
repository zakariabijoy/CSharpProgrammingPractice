using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregation oA = new Aggregation();
            Umid u = new Umid();
            Himel h = new Himel();
            oA.TotalName(h);
            Console.ReadKey();
            
        }
    }
    class Aggregation 
    {
        public void TotalName(person per) 
        {
            per.FullName();
        }
    }

    class person 
    {
       public string first_name;
       public string last_name;
       public virtual void FullName() 
       {

       }
        
    }
    class Himel :person
    {
        public override void FullName() 
        {
            first_name = "Himel";
            last_name = "tayel";
            Console.WriteLine(first_name+ " "+ last_name);
        }
    }
    class Umid : person
    {
       
        public override void FullName()
        {
            first_name = "Umid";
            last_name = "dey";
            Console.WriteLine(first_name + " " + last_name);
        }
    }
    class Zakariya : person 
    {
        public override void FullName()
        {
            first_name = "Bijoy";
            last_name = "zak";
            Console.WriteLine(first_name + " " + last_name);
        }
    }
    
}

