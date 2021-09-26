using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace why_propertise
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _passmark = 35;

        public void Setname(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("name cannot be null or empty");
            }
            this._Name=Name;

        }
        public string Getname()
        {
            return string.IsNullOrEmpty(this._Name) ? "no name " : this._Name;
        }
           
        public void  SetId(int Id)
        {
            if (Id <= 0)
            {
                 throw new Exception("Student id cannot be egative");
                
            }
            this._id = Id;
        }
        public int GetId()
        {
            return this._id;

        }

            
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.SetId(101);
            Console.WriteLine("student ID = {0}", C1.GetId());

        }
    }
}
