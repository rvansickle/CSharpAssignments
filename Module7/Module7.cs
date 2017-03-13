﻿using System;

namespace Module7
{
    public class Module7
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student("Richard", "VanSickle", new DateTime(1986, 3, 10), "169 Saxony Rd", "#212", "Encinitas", "CA", "92024", "USA", "A12245", 3.95);
            Student student2 = new Student("Bob", "Smith", new DateTime(1975, 5, 11), "123 Main St", "", "Pleasantville", "CA", "92123", "USA", "A15826", 2.33);
            Student student3 = new Student("Mary", "Jones", new DateTime(1991, 7, 22), "17 South St", "#246", "San Diego", "CA", "90007", "USA", "B00506", 3.10);

            Course course1 = new Course("Programming with C#", 5, 12);

            Teacher teacher1 = new Teacher("Professor", "Longhair", new DateTime(1946, 3, 15), "19 Hollow Rd", "", "New Orleans", "LA", "70056", "USA", new DateTime(1986, 5, 10), 45457, "C Major");

            // Added these examples to prove I call these objects from the main method 
            student1.TakeTest();
            teacher1.GradeTest();


            Degree degree1 = new Degree("Bachelor of Science", 132);

            UProgram uProgram1 = new UProgram("Computer Science", "Sandy Beach");

            course1.students[0] = student1;
            course1.students[1] = student2;
            course1.students[2] = student3;

            course1.teachers[0] = teacher1;

            degree1.course = course1;
            uProgram1.degree = degree1;

            Console.WriteLine($"The {uProgram1.ProgramName} program contains the {uProgram1.degree.DegreeType} degree");
            Console.WriteLine($"The {uProgram1.degree.DegreeType} degree contains the course {uProgram1.degree.course.CourseName}");
            Console.WriteLine($"The {uProgram1.degree.course.CourseName} course contains {Student.studentCount}");
        }
    }
}