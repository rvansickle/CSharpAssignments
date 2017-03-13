using System;

namespace Module7
{
    class Course
    {
        private string _courseName;
        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }

        private int _courseCredits;
        public int CourseCredits
        {
            get { return _courseCredits; }
            set { _courseCredits = value; }
        }

        private int _courseDuration;
        public int CourseDuration
        {

            get { return _courseDuration; }
            set { _courseDuration = value; }
        }

        private Student[] studentArray = new Student[3];
        public Student[] students
        {
            get { return studentArray; }
            set { studentArray = value; }
        }

        private Teacher[] teacherArray = new Teacher[3];
        public Teacher[] teachers
        {
            get { return teacherArray; }
            set { teacherArray = value; }
        }

        public Course(string courseName, int courseCredits, int courseDuration)
        {
            this.CourseName = courseName;
            this.CourseCredits = courseCredits;
            this.CourseDuration = courseDuration;
        }
    }
}
        
