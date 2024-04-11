using Assignment_03.Interfaces;
using Assignment_03.Models;

namespace Assignment_03.Services;

public class StudentService: PersonService, IStudentService
{
    public double CalculateStudentGPA(Student student)
    {
        // Assuming a method in Student class to calculate GPA
        return student.CalculateGPA();
    }
}