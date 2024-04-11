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
    
    public Instructor getHeadOfDepartment(Department department)
    {
        return department.HeadInstructor;
    }

    public List<String> GetDepartmentList()
    {
        List<String> result = new List<string>();
        foreach (var dep in departments)
        {
            result.Add(dep.Name);
        }

        return result;
    }
}