using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DemoDataAccess : IDataAccess
    {
        private List<Person> people = new();
        public DemoDataAccess()
        {
            people.Add(new Person { Id = 1, FirstName = "zakaria", LastName = "Bijoy" });
            people.Add(new Person { Id = 1, FirstName = "zakaria", LastName = "Bijoy" });

        }

        public List<Person> GetPeople()
        {
            return people;
        }

        public Person InsertPerson(string firstName, string lastName)
        {
            Person person = new() { FirstName = firstName, LastName = lastName };
            person.Id = people.Max(x => x.Id) + 1;
            people.Add(person);
            return person;
        }
    }
}
