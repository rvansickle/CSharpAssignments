using System;

namespace Module4
{
    public class Module4
    {
        public struct Student
        {
            // Student information
            public string StudentFirstName;
            public string StudentLastName;
            public DateTime StudentBirthDate;
            public string StudentAddr1;
            public string StudentAddr2;
            public string StudentCity;
            public string StudentState;
            public string StudentZipCode;
            public string StudentCountry;

            // Student constructor
            public Student(string firstName, string lastName, DateTime birthday, string addr1, string addr2, string city, string state, string zipCode, string country)
            {
                this.StudentFirstName = firstName;
                this.StudentLastName = lastName;
                this.StudentBirthDate = birthday;
                this.StudentAddr1 = addr1;
                this.StudentAddr2 = addr2;
                this.StudentCity = city;
                this.StudentState = state;
                this.StudentZipCode = zipCode;
                this.StudentCountry = country;
            }
        }
        public struct Teacher
        {
            // Teacher information
            public string TeacherFirstName;
            public string TeacherLastName;
            public DateTime TeacherBirthDate;
            public string TeacherAddr1;
            public string TeacherAddr2;
            public string TeacherCity;
            public string TeacherState;
            public string TeacherZipCode;
            public string TeacherCountry;

            // Teacher constructor
            public Teacher(string firstName, string lastName, DateTime birthday, string addr1, string addr2, string city, string state, string zipCode, string country)
            {
                this.TeacherFirstName = firstName;
                this.TeacherLastName = lastName;
                this.TeacherBirthDate = birthday;
                this.TeacherAddr1 = addr1;
                this.TeacherAddr2 = addr2;
                this.TeacherCity = city;
                this.TeacherState = state;
                this.TeacherZipCode = zipCode;
                this.TeacherCountry = country;
            }
        }

        public struct Program
        {
            // Program information
            public string ProgramName;
            public string ProgramDegree;
            public string ProgramDeptHead;

            // Program constructor
            public Program(string programName, string programDegree, string programDeptHead)
            {
                this.ProgramName = programName;
                this.ProgramDegree = programDegree;
                this.ProgramDeptHead = programDeptHead;
            }
        }

        public struct Course
        {
            // Course information
            public string CourseName;
            public int CourseCredits;
            public int CourseDuration;
            public string CourseTeacher;

            // Course constructor
            public Course(string courseName, int courseCredits, int courseDuration, string courseTeacher)
            {
                this.CourseName = courseName;
                this.CourseCredits = courseCredits;
                this.CourseDuration = courseDuration;
                this.CourseTeacher = courseTeacher;
            }
        }
        public static void Main(string[] args)
        {
            GetStudentInformation();
            //DisplayStudentInformation();
            //GetTeacherInformation();
            //GetCourseInformation();
            //GetProgramInformation();
            //GetDegreeInformation();
            Console.ReadLine();
        }

        static void GetStudentInformation()
        {

            Student[] studentArray = new Student[5];
            Student student0 = new Student("Richard", "VanSickle", new DateTime(1986, 3, 10), "169 Saxony Rd", "#212", "Encinitas", "CA", "92024", "USA");
            studentArray[0] = student0;

            for (int i = 1; i < studentArray.Length; i++)
            {
                Console.WriteLine($"Enter the new student information");
                Console.Write("First Name: ");
                studentArray[i].StudentFirstName = Console.ReadLine();
                Console.Write("Last Name: ");
                studentArray[i].StudentLastName = Console.ReadLine();
                studentArray[i].StudentBirthDate = GetBirthday();
                Console.Write("Home Address 1: ");
                studentArray[i].StudentAddr1 = Console.ReadLine();
                Console.Write("Home Address 2: ");
                studentArray[i].StudentAddr2 = Console.ReadLine();
                Console.Write("City: ");
                studentArray[i].StudentCity = Console.ReadLine();
                Console.Write("State: ");
                studentArray[i].StudentState = Console.ReadLine();
                Console.Write("Zip Code: ");
                studentArray[i].StudentZipCode = Console.ReadLine();
                Console.Write("Country: ");
                studentArray[i].StudentCountry = Console.ReadLine();
            }

            for (int i = 0; i < studentArray.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Student {i+1}");
                Console.WriteLine($"{studentArray[i].StudentFirstName} {studentArray[i].StudentLastName}");
                Console.WriteLine(studentArray[i].StudentBirthDate);
                Console.WriteLine(studentArray[i].StudentAddr1);
                Console.WriteLine(studentArray[i].StudentAddr2);                            
                Console.WriteLine($"{studentArray[i].StudentCity}, {studentArray[i].StudentState} {studentArray[i].StudentZipCode} {studentArray[i].StudentCountry}");
            }
        }


        static DateTime GetBirthday()
        {
            Console.Write("Birthday (MM/DD/YYYY): ");
            string birthDateEntered = Console.ReadLine();
            try
            {
                DateTime birthDate = DateTime.Parse(birthDateEntered);
                return birthDate;
            }
            catch (FormatException)
            {
                Console.WriteLine("An invalid date format has been entered. Please try again.");
                return GetBirthday();
            }
        }

        static void DisplayStudentInformation()
        {
            Student[] studentArray = new Student[1];
            for (int i = 0; i < studentArray.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Student {0}", i + 1);
                Console.WriteLine("{0} {1}", studentArray[i].StudentFirstName, studentArray[i].StudentLastName);
                Console.WriteLine(studentArray[i].StudentBirthDate);
                Console.WriteLine(studentArray[i].StudentAddr1);
                Console.WriteLine(studentArray[i].StudentAddr2);
                Console.WriteLine("{0}, {1) {2} {3}", studentArray[i].StudentCity, studentArray[i].StudentState, studentArray[i].StudentZipCode, studentArray[i].StudentCountry);
                Console.ReadLine();
            }
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the teacher's information");
            Console.Write("First Name: ");
            string teacherFirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string teacherLastName = Console.ReadLine();

            // Print the Teacher Information
            WriteTeacherInformation(teacherFirstName, teacherLastName);
        }

        static void WriteTeacherInformation(string firstName, string lastName)
        {
            Console.WriteLine();
            Console.WriteLine(firstName + " " + lastName);
        }

        static void GetCourseInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the course information");
            Console.Write("Course Name: ");
            string courseName = Console.ReadLine();
            Console.Write("Credits: ");
            string courseCredits = Console.ReadLine();
            Console.Write("Duration in Weeks: ");
            string courseDuration = Console.ReadLine();
            Console.Write("Teacher: ");
            string courseTeacher = Console.ReadLine();

            // Print the Course Information
            WriteCourseInformation(courseName, courseCredits, courseDuration, courseTeacher);
        }

        static void WriteCourseInformation(string courseName, string courseCredits, string courseDuration, string courseTeacher)
        {
            Console.WriteLine();
            Console.WriteLine(courseName + " has a duration of " + courseDuration + "weeks and earns the student " + courseCredits + " credits.");
            Console.WriteLine(courseTeacher + " is the teacher.");
        }

        static void GetProgramInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the program Information");
            Console.Write("Program Name: ");
            string programName = Console.ReadLine();
            Console.Write("Department Head: ");
            string programDepartmentHead = Console.ReadLine();

            // Print the Program Information
            WriteProgramInformation(programName, programDepartmentHead);
        }

        static void WriteProgramInformation(string programName, string programDepartmentHead)
        {
            Console.WriteLine();
            Console.WriteLine(programName + " is headed by: " + programDepartmentHead);
        }
        static void GetDegreeInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the Degree Information");
            Console.Write("Degree Name: ");
            string degreeName = Console.ReadLine();
            Console.Write("Credits Required: ");
            string degreeCreditsRequired = Console.ReadLine();

            // Print the Degree Information
            WriteDegreeInformation(degreeName, degreeCreditsRequired);
        }
        static void WriteDegreeInformation(string degreeName, string degreeCreditsRequired)
        {
            Console.WriteLine();
            Console.WriteLine(degreeName + " requires " + degreeCreditsRequired + " credits.");
        }
    }
}
