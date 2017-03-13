using System;
using System.Collections;
using System.Collections.Generic;

namespace Module7
{
    abstract class Person
    {
        private string _firstname;
        public string PFirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        private string _lastname;
        public string PLastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        private DateTime _birthdate;
        public DateTime PBirthDate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        private string _addr1;
        public string PAddr1
        {
            get { return _addr1; }
            set { _addr1 = value; }
        }

        private string _addr2;
        public string PAddr2
        {
            get { return _addr2; }
            set { _addr2 = value; }
        }

        private string _city;
        public string PCity
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _state;
        public string PState
        {
            get { return _state; }
            set { _state = value; }
        }

        private string _zipCode;
        public string PZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        private string _country;
        public string PCountry
        {

            get { return _country; }
            set { _country = value; }
        }

        public static int personCount = 0;

        public Person(string firstName, string lastName, DateTime birthday, string addr1, string addr2, string city, string state, string zipCode, string country)
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
            personCount++;
        }

    }
}

