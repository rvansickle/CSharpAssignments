using System;

namespace Module3
{
    public class Module3
    {
        public static void Main(string[] args)
        {
            GetStudentInformation();
            GetTeacherInformation();
            GetCourseInformation();
            GetProgramInformation();
            GetDegreeInformation();
            Console.ReadLine();
        }
     
        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's information");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            DateTime birthDate = GetBirthday();
            Console.Write("Home Address 1: ");
            string addr1 = Console.ReadLine();
            Console.Write("Home Address 2: ");
            string addr2 = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("State: ");
            string state = Console.ReadLine();
            Console.Write("Zip Code: ");
            string zipCode = Console.ReadLine();
            Console.Write("Country: ");
            string country = Console.ReadLine();

            // Print the Student Information
            WriteStudentInformation(firstName, lastName, birthDate, addr1, addr2, city, state, zipCode, country);
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
            
            static void WriteStudentInformation(string firstName, string lastName, DateTime birthDate, string addr1, string addr2, string city, string state, string zipCode, string country)
        {
            Console.WriteLine();
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(birthDate.ToShortDateString());
            Console.WriteLine(addr1);
            Console.WriteLine(addr2);
            Console.WriteLine(city + ", " + state + " " + zipCode.ToString() + " " + country);           
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
