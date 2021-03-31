using System;

namespace SchoolPortal
{
    public class School
    {
        public string StudentName { get; set; }

        public string RegistrationNum { get; set; }

        public string Department { get; set; }

        public double Score { get; set; }

        public School(string student, string regNum, string dept, double score)
        {
            StudentName = student;
            RegistrationNum = regNum;
            Department = dept;
            Score = score;
        }
    }
}