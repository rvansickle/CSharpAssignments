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

        private float _studentGPA;
        public float StudentGPA
        {
            get { return _studentGPA; }
            set { _studentGPA = value; }
        }

        public void TakeTest()
        {
            Console.WriteLine("Taking test......");
        }

        public static int studentCount = 0;

        public Student(string firstName, string lastName, DateTime birthday, string addr1, string addr2, string city, string state, string zipCode, string country, string studentID, float studentGPA)
        {
            this.PFirstName = firstName;
            this.PLastName = lastName;
            this.PBirthDate = birthday;
            this.PAddr1 = addr1;
            this.PAddr2 = addr2;
            this.PCity = city;
            this.PState = state;
            this.PZipCode = zipCode;
            this.PCountry = country;
            this.StudentID = studentID;
            this.StudentGPA = studentGPA;
            studentCount++;

        }
    }
}

