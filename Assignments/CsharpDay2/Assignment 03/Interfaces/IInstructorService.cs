namespace Assignment_03.Interfaces;
using Assignment_03.Models;

public interface IInstructorService: IPersonService
{
    void AssignToDepartment(Instructor instructor, Department department);

    public decimal CalculateInstructorSalary(Instructor instructor);
}