using System;
namespace ShapesTest
{
    public class Triangle : Figure
    {

        public Triangle(double x, double y) : base(x, y)
        {
            // X = x;
            // Y = y;

        }

         public override void Area()
        {
            base.Area();
            double CalculatedTriangArea = 0.5 * X * Y;
            Console.Write($"\nTriangle Area- {CalculatedTriangArea}");
        }
    }
}