using System;

namespace Module5
{
    public class Student
    {
        private string _firstname;
        public string StudentFirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        private string _lastname;
        public string StudentLastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        private DateTime _birthdate;
        public DateTime StudentBirthDate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        private string _addr1;
        public string StudentAddr1
        {
            get { return _addr1; }
            set { _addr1 = value; }
        }
        
        private string _addr2;
        public string StudentAddr2
        {
            get { return _addr2; }
            set { _addr2 = value; }
        }

        private string _city;
        public string StudentCity
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _state;
        public string StudentState
        {
            get { return _state; }
            set { _state = value; }
        }

        private string _zipCode;
        public string StudentZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        private string _country;
        public string StudentCountry
        {

            get { return _country; }
            set { _country = value; }
        }

        public static int studentCount = 0;

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
            studentCount++;
        }

    }
}

