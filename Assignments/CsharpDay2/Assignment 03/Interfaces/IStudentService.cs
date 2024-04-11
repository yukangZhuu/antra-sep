namespace Assignment_03.Interfaces;
using Assignment_03.Models;

public interface IStudentService : IPersonService
{
    public double CalculateStudentGPA(Student student);
}

