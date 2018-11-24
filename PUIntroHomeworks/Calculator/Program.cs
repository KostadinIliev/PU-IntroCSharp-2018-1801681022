using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            char[] operations = { '+', '-', '*', '/' };
            double result = 0;
            while (true)
            {
                Console.WriteLine("Do you want to calculate some numbers? (yes,no)");
                input = Console.ReadLine();
                if (input == "no")
                {
                    break;
                }
                else if (input == "yes")
                {
                    Console.WriteLine("Enter first number:");
                    double firstNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    double secondNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter operation:");
                    string inputOperation = Console.ReadLine();
                    char operation;

                    bool successfullyParsed = char.TryParse(inputOperation, out operation);
                    while (!successfullyParsed || !operations.Contains(operation))
                    {
                        Console.WriteLine("Invalid input! You have to enter a character [+, -, *, /]");
                        inputOperation = Console.ReadLine();
                        successfullyParsed = char.TryParse(inputOperation, out operation);
                    }
                    switch (operation)
                    {
                        case '+':
                            result = firstNumber + secondNumber;
                            result *= 1.1;
                            Console.WriteLine($"Result is {result:0.00}");
                            Console.WriteLine("\n****************************\n****************************\n****************************\n");
                            break;
                        case '-':
                            double maxNum = Math.Max(firstNumber, secondNumber);
                            double minNum = Math.Min(firstNumber, secondNumber);
                            result = Math.Pow(maxNum, 2) - minNum;
                            Console.WriteLine($"Result is {result:0.00}");
                            Console.WriteLine("\n****************************\n****************************\n****************************\n");
                            break;
                        case '*':
                            result = firstNumber * Math.Sqrt(secondNumber);

                            Console.WriteLine($"Result is {result:0.00}");
                            Console.WriteLine("\n****************************\n****************************\n****************************\n");
                            break;
                        case '/':
                            if (secondNumber == 0)
                            {
                                Console.WriteLine("Error! You can't devide with 0!!");
                            }
                            else
                            {
                                result = firstNumber / secondNumber;
                                Console.WriteLine($"Result is {result:0.00}");
                                Console.WriteLine("\n****************************\n****************************\n****************************\n");
                            }
                            break;

                    }
                }
            }
        }
    }
}