using System;

namespace Module6
{
    class Student : Person
    {
        private string _studentID;
        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        private double _studentGPA;
        public double StudentGPA
        {
            get { return _studentGPA; }
            set { _studentGPA = value; }
        }

        public void TakeTest()
        {
            Console.WriteLine($"Student takes a test");
        }

        public static int studentCount = 0;

        public Student(string firstName, string lastName, DateTime birthday, string addr1, string addr2, string city, string state, string zipCode, string country, string studentID, double studentGPA)
            : base(firstName, lastName,birthday, addr1, addr2, city, state, zipCode, country)
        {            
 //           this.StudentID = studentID;
 //           this.StudentGPA = studentGPA;
            studentCount++;

        }
    }
}

