namespace SavingAccountTask
{
    public class SavingAccount
    {
        public static double AnnualInterstRate { get; set; }=0.04D;
        private double savingBalance;

        public double SavingBalance
        {
            get{return savingBalance;}
            set{
                if(value > 0)
                {
                    savingBalance = value;
                }
            }
        }
        
        

         public SavingAccount(double deposit)
         {
             SavingBalance = deposit;
         }


        public double CalculateMonthlyInterest()
        {
            double calculatedRate = (SavingBalance * AnnualInterstRate)/12;
            double newBalance = SavingBalance + calculatedRate;
            return newBalance;
        }

        public void ModifyInterestRate(double rates)
        {
           AnnualInterstRate = rates/100;
        }

        public override string ToString()
        {
            return $"Your current balance is {SavingBalance} and Monthly interest rate is:{CalculateMonthlyInterest()}";
        }
    }
}