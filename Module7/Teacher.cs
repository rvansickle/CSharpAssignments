using System;

namespace Module7
{
    class Teacher : Person
    {
        private DateTime _tHireDate;
        public DateTime THireDate
        {
            get { return _tHireDate; }
            set { _tHireDate = value; }
        }

        private int _tEmployeeID;
        public int TEmployeeID
        {
            get { return _tEmployeeID; }
            set { _tEmployeeID = value; }
        }

        private string _tAccredidation;
        public string TAccredidation
        {
            get { return _tAccredidation; }
            set { _tAccredidation = value; }
        }
        public void GradeTest()
        {
            Console.WriteLine($"Teacher grades a test");
        }

        public Teacher(string firstName, string lastName, DateTime birthday, string addr1, string addr2, string city, string state, string zipCode, string country, DateTime tHireDate, int tEmployeeID, string tAccredidation)
            : base(firstName, lastName, birthday, addr1, addr2, city, state, zipCode, country)
        {
        }
    }
}