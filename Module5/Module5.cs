using System;

namespace Module5
{
    public class Module5

    {
            public static void Main(string[] args)
            {
                Student student1 = new Student("Richard", "VanSickle", new DateTime(1986, 3, 10), "169 Saxony Rd", "#212", "Encinitas", "CA", "92024", "USA");
                Student student2 = new Student("Bob", "Smith", new DateTime(1975, 5, 11), "123 Main St", "", "Pleasantville", "CA", "92123", "USA");
                Student student3 = new Student("Mary", "Jones", new DateTime(1991, 7, 22), "17 South St", "#246", "San Diego", "CA", "90007", "USA");

                Course course1 = new Course("Programming with C#", 5, 12);

                Teacher teacher1 = new Teacher("Professor", "Longhair");

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
                Console.ReadLine();
            }         
        }
    }
