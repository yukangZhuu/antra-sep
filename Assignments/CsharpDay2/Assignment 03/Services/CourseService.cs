using Assignment_03.Interfaces;
using Assignment_03.Models;
namespace Assignment_03.Services;


public class CourseService: ICourseService
{
    private List<Course> courses = new List<Course>();
    
    public void AddCourse(Course course)
    {
        courses.Add(course);
    }
    public void EnrollStudentInCourse(Student student, Course course)
    {
        course.AddStudent(student);
    }

    public IEnumerable<Student> GetStudentsInCourse(Course course)
    {
        return course.GetEnrollments();
    }
}