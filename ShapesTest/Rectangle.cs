using System;
namespace ShapesTest
{
    public class Rectangle : Figure
    {
        public Rectangle(double x, double y) : base(x, y)
        {
            // X = x;
            // Y = y;
        }

        public override void Area()
        {
            base.Area();
            double CalculatedRectArea  = X * Y;
            Console.Write($"\nRectangle Area- {CalculatedRectArea}\n");
        }
    }
}