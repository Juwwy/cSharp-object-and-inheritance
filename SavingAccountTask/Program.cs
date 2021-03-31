using System;

namespace SavingAccountTask
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount saver1 = new SavingAccount(40000);
            SavingAccount saver2 = new SavingAccount(16000);

            // saver1.ModifyInterestRate(0.04);
            Console.WriteLine($"{saver1} {saver1.CalculateMonthlyInterest():F}\n");
            saver1.ModifyInterestRate(5);
            Console.WriteLine($"{saver1}  New Month interest is- {saver1.CalculateMonthlyInterest():F}\n\n");

            Console.WriteLine($"{saver2} {saver2.CalculateMonthlyInterest():F}\n");
            saver1.ModifyInterestRate(5);
            Console.WriteLine($"{saver2}  New Month interest is- {saver2.CalculateMonthlyInterest():F}");
        }
    }
}
