namespace CsharpDay3.Models;

public class Person : Entity
{
    public string Name { get; set; }

    public Person(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
}