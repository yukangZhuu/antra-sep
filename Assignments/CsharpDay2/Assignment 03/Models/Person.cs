namespace Assignment_03.Models;

public class Person
{
    public string Name { get; set; } 
    public DateTime Birthday { get; set; }
    public List<string> Addresses { get; private set; }

    public decimal salary;

    public Person(decimal salary, string name, DateTime birthday)
    {
        this.salary = salary;
        Name = name;
        Birthday = birthday;
    }
    
    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Salary cannot be negative.");
            }
            else
            {
                salary = value;
            }
        }
    }

    public int GetAge()
    {
        int age = DateTime.Now.Year - Birthday.Year;
        if (Birthday.Date > DateTime.Now.AddYears(-age)) age--;
        return age;
    }

    public IEnumerable<string> GetAddresses()
    {
        return Addresses;
    }

    public void AddAddress(string a)
    {
        Addresses.Add(a);
    }

    public virtual decimal CalculateSalary()
    {
        return salary;
    }
}