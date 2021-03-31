using System;

namespace RectangleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(12, 5);

            

            Console.Write($"The Perimeter of a Rectangle is:\n{rect.Perimeter}");
            Console.Write($"\nThe Area of a Rectangle is:\n{rect.Area}");
        }
    }
}
