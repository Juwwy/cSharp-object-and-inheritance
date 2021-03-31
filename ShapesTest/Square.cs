using System;
namespace ShapesTest
{
    public class Square : Figure
    {
       
        public Square(double x, double y) : base(x, y)
        {
            // X = x;
            // Y = y;
        }
         public override void Area()
        {
            base.Area();
            double CalculatedSquareArea = 0;
            if(X==Y)
            {
               CalculatedSquareArea = X * Y;
            }
            Console.Write($"\nSquare Area- {CalculatedSquareArea}\n");
            // return CalCulatedSquareArea;
        }
    }
}