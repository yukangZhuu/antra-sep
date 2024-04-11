using Assignment_03.Interfaces;
using Assignment_03.Models;
namespace Assignment_03.Services;

public class DepartmentService: IDepartmentService
{
    private List<Department> departments = new List<Department>();
    
    public void AddDepartment(Department department)
    {
        departments.Add(department);
    }
    
    public void AssignHeadOfDepartment(Instructor instructor, Department department)
    {
        department.HeadInstructor = instructor;
        instructor.IsHead = true;
    }
}