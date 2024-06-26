﻿using Assignment_03;
using Assignment_03.Services;
using Assignment_03.Interfaces;
using Assignment_03.Models;
// Working with methods

// 1. Let’s make a program that uses methods to accomplish a task. Let’s take an array and
//    reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
//    become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1
int[] numbers = Utils.GenerateNumbers(10);
Utils.Reverse(numbers);
Utils.PrintNumbers(numbers);


// 2. The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
// and every other number in the sequence after it is the sum of the two numbers before it. So
//     the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
// which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
// number: 2 + 3 = 5. This keeps going forever.
// In your Mainmethod, write code to loop through the first 10 numbers of the Fibonacci
// sequence and print them out
Console.WriteLine();
Console.WriteLine();
 Console.WriteLine("Fibonacci sequence from 1 to 10:");
 for (int i = 1; i <= 10; i++)
 {
     Console.WriteLine($"{i} -> " + Utils.Fibonacci(i));
 }




// Designing and Building Classes using object-oriented principles

// 1. -> 6. Person, Student, Instructor, Course, Department

//Instantiate Services
IStudentService studentService = new StudentService();
IInstructorService instructorService = new InstructorService();
ICourseService courseService = new CourseService();
IDepartmentService departmentService = new DepartmentService();

//Add some students
Student student1 = new Student("Jake", new DateTime(2000, 3, 31));
Student student2 = new Student("Bill", new DateTime(1999, 12, 29));
Student student3 = new Student("Lisa", new DateTime(2001, 5, 11));
Student student4 = new Student("Lora", new DateTime(1996, 5, 24));
Student student5 = new Student("Peter", new DateTime(2004, 8, 7));
studentService.AddPerson(student1);
studentService.AddPerson(student2);
studentService.AddPerson(student3);
studentService.AddPerson(student4);
studentService.AddPerson(student5);

//Add some instructors
Instructor instructor1 = new Instructor("Mr.Eggert", new DateTime(2015, 2, 21), 200000, new DateTime(1985, 3, 1));
Instructor instructor2 = new Instructor("Ms.Lee", new DateTime(2001, 6, 11), 350000, new DateTime(1962, 5, 1));
Instructor instructor3 = new Instructor("Ms.Cohen", new DateTime(2021, 8, 4), 160000, new DateTime(1993, 3, 24));
instructorService.AddPerson(instructor1);
instructorService.AddPerson(instructor2);
instructorService.AddPerson(instructor3);

//Add some departments
Department department1 = new Department("Computer Science", instructor1);
Department department2 = new Department("Electrical and Computer Engineering", instructor2);
departmentService.AddDepartment(department1);
departmentService.AddDepartment(department2);

//Add some courses
Course course1 = new Course("Operating System");
Course course2 = new Course("Data Mining");
Course course3 = new Course("Embedded Systems");
Course course4 = new Course("Computational Imaging");
courseService.AddCourse(course1);
courseService.AddCourse(course2);
courseService.AddCourse(course3);
courseService.AddCourse(course4);

//Some Configurations
departmentService.AssignHeadOfDepartment(instructor1, department1);
departmentService.AssignHeadOfDepartment(instructor2, department2);
courseService.EnrollStudentInCourse(student1, course1, 'A');
courseService.EnrollStudentInCourse(student1, course2, 'B');
courseService.EnrollStudentInCourse(student2, course3, 'C');
courseService.EnrollStudentInCourse(student2, course4, 'B');
courseService.EnrollStudentInCourse(student3, course1, 'B');

//Some Sample Outputs
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("-----------------------------------------------------------------------------------------");
Console.WriteLine($"Student List: {string.Join(", ", studentService.GetStudentList())}");
Console.WriteLine($"Instructor List: {string.Join(", ", instructorService.GetInstructorList())}");
Console.WriteLine($"Department List: {string.Join(", ", departmentService.GetDepartmentList())}");
Console.WriteLine($"Course List: {string.Join(", ", courseService.GetCourseList())}");

Console.WriteLine("-----------------------------------------------------------------------------------------");
Console.WriteLine($"Department of {department1.Name}:");
Console.WriteLine($"- Head of Department: {departmentService.getHeadOfDepartment(department1).Name}");
Console.WriteLine($"- Total Salary of him/her: " + $"${instructorService.CalculateInstructorSalary(departmentService.getHeadOfDepartment(department1))}");

Console.WriteLine("-----------------------------------------------------------------------------------------");
Console.WriteLine($"Student Name: {student1.Name}");
Console.WriteLine($"GPA: {studentService.CalculateStudentGPA(student1)} / 4");

Console.WriteLine("-----------------------------------------------------------------------------------------");
Console.WriteLine($"Course Name: {course1.CourseName}");
Console.WriteLine($"Enrolled Students: {string.Join(", ", courseService.GetEnrollment(course1))}");




// 7. Color and Ball class
// Write some code in your Main method to create a few balls, throw them around a few
//     times, pop a few, and try to throw them again, and print out the number of times that the
// balls have been thrown. (Popped balls shouldn’t have changed.)

Ball ball1 = new Ball(1, new Color(255, 255, 255));
Ball ball2 = new Ball(5, new Color(1, 255, 1));
Ball ball3 = new Ball(10, new Color(255, 1, 255));

ball1.Throw();
ball2.Throw();
ball3.Throw();

ball1.Pop();

ball1.Throw();
ball2.Throw();
ball3.Throw();

ball2.Pop();

ball1.Throw();
ball2.Throw();
ball3.Throw();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("number of times that the balls have been thrown: ");
Console.WriteLine($"ball 1: {ball1.ThrowCount}");
Console.WriteLine($"ball 2: {ball2.ThrowCount}");
Console.WriteLine($"ball 3: {ball3.ThrowCount}");