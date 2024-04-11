namespace Assignment_03.Models;

public class Department
{
    public string Name { get; set; }
    private List<Course> coursesOffered;
    public Instructor HeadInstructor { get; set; }
    private Dictionary<SchoolYear, decimal> budgets;

    public Department(string name, Instructor head)
    {
        Name = name;
        HeadInstructor = head;
        coursesOffered = new List<Course>();
        budgets = new Dictionary<SchoolYear, decimal>();
    }

    public void RegisterCourse(Course course)
    {
        coursesOffered.Add(course);
    }

    public void RegisterBudget(SchoolYear year, decimal budget)
    {
        budgets.Add(year, budget);
    }
    
    public IEnumerable<Course> GetOfferedCourses()
    {
        return coursesOffered;
    }
    
}



public class SchoolYear
{
    public string Year { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }

    public SchoolYear(string year, DateTime start, DateTime end)
    {
        Year = year;
        StartDate = start;
        EndDate = end;
    }
}