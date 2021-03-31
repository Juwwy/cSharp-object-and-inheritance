using System;

namespace SchoolPortal
{
    public class Science : Student
    {
        public double ComputerNet { get; set; }
        public double DataStr { get; set; }

        public double CSharp { get; set; }
        public Science(string student, string regNum, string dept, double score, double computerNet, double dataStr, double cSharp) : base(student, regNum, dept, score)
        {
            ComputerNet = computerNet;
            DataStr = dataStr;
            CSharp = cSharp;
        }

        public double StudentSciScore()
        {
            double TotalScore = ComputerNet + DataStr + CSharp;
            Score = TotalScore;
            return Score;
        }

        //  public string GetScoreAnaly()
        // {
        //     Console.Write("What is Your department:");
        //     string GetCode = Console.ReadLine();
        //     if(GetCode == "SCI")
        //     {
        //         Console.Write($"{ComputerNet} {DataStr} {CSharp}");
        //     }else{
        //         return $"Scores sheet for your department not available";
        //     }
        //     return GetCode;
            
        // }

        public double Average()
        {
            return Score/3;
        }

        public override string ToString()
        {
           return $"{StudentName} {RegistrationNum} {Department}\nTotal Score is: {Score}\nYour respective Subject scores are:\nComputer Network- {ComputerNet}\nData structure- {DataStr}\nCSharp- {CSharp}\nTotal scores Average is: {Average():F}";
        }
       
    }
}