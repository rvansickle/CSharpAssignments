using System;

namespace Module5
{
    class Degree
    {
        private string _degreetype;
        public string DegreeType
        {
            get { return _degreetype; }
            set { _degreetype = value; }
        }

        private int _degreeCreditsReq;
        public int DegreeCreditsReq
        {
            get { return _degreeCreditsReq; }
            set { _degreeCreditsReq = value; }
        }

        private Course _course;
        public Course course
        {
            get { return _course; }
            set { _course = value; }
        }

        public Degree(string degreeType, int degreeCreditsReq)
        {
            this.DegreeType = degreeType;
            this.DegreeCreditsReq = degreeCreditsReq;
        }

        public Degree(Course course)
        {
            this.course = course;
        }

    }
}
