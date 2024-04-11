namespace Assignment_03.Services;
using Assignment_03.Interfaces;
using Assignment_03.Models;

public class PersonService : IPersonService
{
    internal List<Person> people = new List<Person>();

    public void AddPerson(Person person)
    {
        people.Add(person);
    }
    
    public void DeletePerson(Person person)
    {
        if (person != null)
        {
            people.Remove(person);
        }
        else
        {
            throw new ArgumentException("Person not found");
        }
    }
}