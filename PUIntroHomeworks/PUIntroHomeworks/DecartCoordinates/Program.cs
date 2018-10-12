using System;

namespace DecartCoordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some calculation!" );
            Console.WriteLine("Enter Xa: ");
            double xA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ya: ");
            double yA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Xb: ");
            double xB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Yb: ");
            double yB = double.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------------");
            Console.WriteLine("The point have the following coordinates: ");
            Console.WriteLine($"Point A{xA},{yA}");
            Console.WriteLine($"Point B{xB},{yB}");
            Console.WriteLine("------------------------------------");
            double distanceBetweenTwoPoints = Math.Sqrt(Math.Pow((xB-xA),2) + Math.Pow((yB-yA),2));
            Console.WriteLine($"The distance between two points is {distanceBetweenTwoPoints}");
        }
    }
}
