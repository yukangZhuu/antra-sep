namespace Assignment_03.Models;

public class Student: Person
{
    private Dictionary<Course, char> enrollments;

    public Student(string name, DateTime birth) : base(0, name, birth)
    {
        enrollments = new Dictionary<Course, char>();
    }

    public void EnrollCourse(Course course, char grade)
    {
        enrollments.Add(course, grade);
    }

    public double CalculateGPA()
    {
        int gpa = 0;

        foreach (var grade in enrollments.Values)
        {
            gpa += grade switch
            {
                'A' => 4,
                'B' => 3,
                'C' => 2,
                'D' => 1,
                'F' => 0,
                _ => 0
            };
        }

        return gpa / enrollments.Count;
    }
}