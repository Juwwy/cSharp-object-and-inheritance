using System;
namespace ShapesTest
{
    public class Figure
    {
        public string Name { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public Figure(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y;
        }

        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }
        public virtual void Area()
        {
            Console.WriteLine("\nEnter value for X:");
            X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter value for Y: ");
            Y = Convert.ToDouble(Console.ReadLine());

        }
    }
}