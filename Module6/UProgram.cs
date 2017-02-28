using System;

namespace Module6
{
    class UProgram
    {
        private string _programName;
        public string ProgramName
        {
            get { return _programName; }
            set { _programName = value; }
        }

        private string _programDeptHead;
        public string ProgramDeptHead
        {
            get { return _programDeptHead; }
            set { _programDeptHead = value; }
        }

        private Degree _degree;
        public Degree degree
        {
            get { return _degree; }
            set { _degree = value; }
        }


        public UProgram(string programName, string programDeptHead)
        {
            this.ProgramName = programName;
            this.ProgramDeptHead = programDeptHead;
        }
        public UProgram(Degree degree)
        {
            this.degree = degree;
        }
    }
}
