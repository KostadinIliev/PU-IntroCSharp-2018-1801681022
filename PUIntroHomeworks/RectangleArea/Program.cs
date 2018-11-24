using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int sideA = rnd.Next(1, 50);
            int sideB = rnd.Next(51, 100);

            int area = sideA * sideB;
            Console.WriteLine($"The area of the rectangle is {area:0}");
        }
    }
}