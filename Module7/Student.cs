using System;
using System.Collections;
using System.Collections.Generic;

namespace Module7
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

        private Stack grades = new Stack();
        public Stack Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        public void TakeTest()
        {
            Console.WriteLine($"Student takes a test");
        }

        public static int studentCount = 0;

        public Student(string _firstName, string lastName, DateTime birthday, string addr1, string addr2, string city, string state, string zipCode, string country, string studentID, double studentGPA)
            : base(_firstName, lastName,birthday, addr1, addr2, city, state, zipCode, country)
        {            
             studentCount++;
        }

        public void GetGrades()
        {
            Console.WriteLine($"GGGG Grades for {PFirstName}");
            //for(int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine($"Grade {i.ToString()}");
            //    grades.Push = Console.ReadLine();
            //}
        }
    }
}

