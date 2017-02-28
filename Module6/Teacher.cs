using System;

namespace Module6
{
    class Teacher
    {
        private string _teacherFirstName;
        public string TeacherFirstName
        {
            get { return _teacherFirstName; }
            set { _teacherFirstName = value; }
        }

        private string _teacherLastName;
        public string TeacherLastName
        {
            get { return _teacherLastName; }
            set { _teacherLastName = value; }
        }

        public Teacher(string firstName, string lastName)
        {
            this.TeacherFirstName = firstName;
            this.TeacherLastName = lastName;
        }
    }
}
