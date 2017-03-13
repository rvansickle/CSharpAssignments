using System;
using System.Collections;
using System.Collections.Generic;

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

        private ArrayList studentList = new ArrayList();
        public ArrayList Students
        {
            get { return studentList; }
            set { studentList = value; }
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

        public void ListStudents()
        {
            foreach (Student stu in this.Students)
            {
                Console.Write($"The grades for {stu.PFirstName} {stu.PLastName} are ");
                foreach (double gt in stu.Grades)
                {
                    Console.Write($"{gt.ToString()} ");
                }
            Console.WriteLine();
            }
        }
    }
}
        
