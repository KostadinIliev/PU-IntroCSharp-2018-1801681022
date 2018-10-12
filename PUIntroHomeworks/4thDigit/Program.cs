using System;

namespace _4thDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 7 digit number here:");
            int number = int.Parse(Console.ReadLine());
            if (number > 9999999 || number < 1000000)
            {
                Console.WriteLine("This number you entered is not a 7 digit number !");
            }
            else
            {
                int fourthDigit = number % 1000000 % 100000 % 10000 / 1000;
                Console.WriteLine($"The fourth digit of {number} is {fourthDigit}");

            }
        }
    }
}
