using System;

namespace ShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            Triangle runThis = new Triangle(num1, num2 );
            runThis.Area();
            Cube runThis1 = new Cube(num1, num2);
            runThis1.Area();
            Square runThis2 = new Square(num1, num2);
            runThis2.Area();
            Rectangle runThis3 = new Rectangle(num1, num2);
            runThis3.Area();
        }
    }
}
