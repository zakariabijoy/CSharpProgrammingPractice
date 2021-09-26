using DemoLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "tim", LastName = "corey" });
            people.Add(new PersonModel { Id = 1, FirstName = "sue", LastName = "sotm" });
            people.Add(new PersonModel { Id = 1, FirstName = "joe", LastName = "corey" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(p => p.Id) + 1;
            people.Add(p);

            return p;
        }
    }
}
