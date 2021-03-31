using System;

namespace SchoolPortal
{
    public class Commercial : School
    {
        public double ElectCircuit { get; set; }
        public double CircuitAnalysis { get; set; }

        public double AnalogCom { get; set; }
        public Commercial(string student, string regNum, string dept, double score, double electCircuit, double circuitAnaly, double analogCom) : base(student, regNum, dept, score)
        {
            ElectCircuit = electCircuit;
            CircuitAnalysis = circuitAnaly;
            AnalogCom = analogCom;
        }

        public double StudentComScore()
        {
            double TotalScore = ElectCircuit + CircuitAnalysis + AnalogCom;
            double ComScore = TotalScore;
            return ComScore;
        }

        public double Average()
        {
            return Score/3;

        }

        public override string ToString()
        {
            return $"{StudentName} {RegistrationNum} {Department}\nTotal Score is: {Score}\n Your respective Subject scores are:\nElectric Circuit- {ElectCircuit}\nCircuit Analysis- {CircuitAnalysis}\nAnalog communication- {AnalogCom}\nTotal scores Average is: {Average()}";
        }
    }    
       
}