namespace Assignment_03.Interfaces;
using Assignment_03.Models;

public interface IPersonService
{
    void AddPerson(Person person);
    void DeletePerson(Person person);
}