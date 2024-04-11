using Assignment_03.Interfaces;
using Assignment_03.Models;
namespace Assignment_03.Services;


public class CourseService: ICourseService
{
    internal List<Course> courses = new List<Course>();
    
    public void AddCourse(Course course)
    {
        courses.Add(course);
    }
    public void EnrollStudentInCourse(Student student, Course course, char grade)
    {
        student.EnrollCourse(course, grade);
        course.AddStudent(student);
    }

    public IEnumerable<Student> GetStudentsInCourse(Course course)
    {
        return course.GetEnrollments();
    }

    public List<String> GetEnrollment(Course course)
    {
        List<String> result = new List<string>();
        foreach (var c in GetStudentsInCourse(course))
        {
            result.Add(c.Name);
        }

        return result;
    }
    
    public List<String> GetCourseList()
    {
        List<String> result = new List<string>();
        foreach (var course in courses)
        {
            result.Add(course.CourseName);
        }

        return result;
    }
}