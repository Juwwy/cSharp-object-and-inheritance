using System;
namespace ShapesTest
{
    public class Cube : Figure
    {
        
        public Cube(double x, double y) : base(x, y)
        {
            // X = x;
            // Y = y;
        }

        public override void Area()
        {
            base.Area();
            double CalculatedCubeArea = 0;
            if(X==Y)
            {
              CalculatedCubeArea =  6 * (X * Y);
            }
            
            Console.Write($"\nCube Area - {CalculatedCubeArea}\n");
            
        }
    }
}