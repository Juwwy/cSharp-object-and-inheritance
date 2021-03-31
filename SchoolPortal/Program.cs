using System;

namespace SchoolPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Commercial studentOfCom = new Commercial("Olowu Juwon", "12/OB76","Commercial", 207, 87, 45, 75);
            Science studentOfSci = new Science("Adams Kamal", "15/YT008", "Science", 209, 56, 67, 86);

            Console.WriteLine($"{studentOfCom}\n\n");
            Console.WriteLine($"{studentOfSci}" );
        }
    }
}
