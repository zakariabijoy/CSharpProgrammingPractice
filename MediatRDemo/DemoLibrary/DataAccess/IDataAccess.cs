using DemoLibrary.Models;

namespace DemoLibrary
{
    public interface IDataAccess
    {
        List<Person> GetPeople();
        Person InsertPerson(string firstName, string lastName);
    }
}