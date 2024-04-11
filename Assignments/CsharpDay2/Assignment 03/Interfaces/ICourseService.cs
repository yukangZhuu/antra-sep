namespace Assignment_03.Interfaces;
using Assignment_03.Models;

public interface ICourseService
{
    void AddCourse(Course course);
    void EnrollStudentInCourse(Student student, Course course, char grade);
    IEnumerable<Student> GetStudentsInCourse(Course course);
    public List<String> GetCourseList();
    public List<String> GetEnrollment(Course course);
}