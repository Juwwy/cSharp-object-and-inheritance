using System;

namespace SchoolPortal
{
    public class Student
    {
        public string StudentName { get; set; }

        public string RegistrationNum { get; set; }

        public string Department { get; set; }

        public double Score { get; set; }

        public Student(string student, string regNum, string dept, double score)
        {
            StudentName = student;
            RegistrationNum = regNum;
            Department = dept;
            Score = score;
        }

        // public virtual void GetDept()
        // {
        //     Console.WriteLine("Enter your Department:\n");
        //     string DePartm = Console.ReadLine();
        // }
    }
}