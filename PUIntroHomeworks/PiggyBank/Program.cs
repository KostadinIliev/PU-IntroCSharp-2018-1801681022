using System;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double sum = 0;

            Console.WriteLine("Enter a real number:");
            string input = Console.ReadLine();

            int inputNum;
            while (!int.TryParse(input, out inputNum))
            {
                Console.WriteLine("You have to enter a valid real number!");
                input = Console.ReadLine();
            }

            for (int i = 1; i <= 31; i++)
            {
                int number = rnd.Next(1, inputNum);
                double rootedNum = Math.Sqrt(number);
                if (rootedNum >= 1 && rootedNum <= 300)
                {
                    rootedNum *= 5.1;
                }
                else if (rootedNum >= 301 && rootedNum <= 600)
                {
                    rootedNum *= 10.098;
                }
                else if (rootedNum >= 601 && rootedNum <= 999)
                {
                    rootedNum *= 100.00001;
                }

                sum += rootedNum;

            }

            if (sum > 0)
            {
                Console.WriteLine($"You managed to save ${sum:0.0000} this month!");
            }
            else
            {

                Console.WriteLine("You didn't manage to save any money.");
            }
        }
    }
}