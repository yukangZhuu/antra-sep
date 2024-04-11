namespace Assignment_03.Models;

public class Instructor: Person
{
    public bool IsHead { get; set; }
    public DateTime JoinDate { get; private set; }
    
    public Department WorkDepartment { get; set; }

    public Instructor(string name, DateTime joinDate, decimal salary, DateTime birth): base(salary, name, birth)
    {
        this.IsHead = false;
        JoinDate = joinDate;
    }
    
    public override decimal CalculateSalary()
    {
        int experience = JoinDate.Year - DateTime.Now.Year;
        if (DateTime.Now.AddYears(-experience) > JoinDate) experience--;
        
        return this.Salary + 10000 * experience;
    }
}