namespace Assignment_03.Models;

public class Course
{
    public string CourseName { get; set; }
    private List<Student> enrolledStudent;

    public Course(string name)
    {
        CourseName = name;
        enrolledStudent = new List<Student>();
    }

    public void AddStudent(Student s)
    {
        enrolledStudent.Add(s);
    }

    public IEnumerable<Student> GetEnrollments()
    {
        return enrolledStudent;
    }
}