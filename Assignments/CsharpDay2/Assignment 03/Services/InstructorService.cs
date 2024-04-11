using Assignment_03.Interfaces;
using Assignment_03.Models;
namespace Assignment_03.Services;


public class InstructorService: PersonService, IInstructorService
{
    public void AssignToDepartment(Instructor instructor, Department department)
    {
        instructor.WorkDepartment = department;
    }

    public decimal CalculateInstructorSalary(Instructor instructor)
    {
        return instructor.CalculateSalary();
    }
}