using System;

namespace CalculateWeightInTheSolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravitationalRatio;
            double weightOnPlanet;
            Console.WriteLine("Enter your weight in kgs as measured on Earth");
            short weight = short.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Enter the code corresponding to the name of the desired planet:");
            Console.WriteLine("1: Mercury");
            Console.WriteLine("2: Venus");
            Console.WriteLine("3: Earth");
            Console.WriteLine("4: Mars");
            Console.WriteLine("5: Jupiter");
            Console.WriteLine("6: Saturn ");
            Console.WriteLine("7: Uranus");
            Console.WriteLine("8: Neptune");
            Console.WriteLine("9: Pluto");
            Console.WriteLine("--------------------------------------------------");

            byte option = byte.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    gravitationalRatio = 0.378;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weight approximately {weightOnPlanet}kg on Mercury");
                    break;
                case 2:
                    gravitationalRatio = 0.907;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weight approximately {weightOnPlanet}kg on Venus");
                    break;
                case 3:
                    gravitationalRatio = 1;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weight approximately {weightOnPlanet}kg on Earth");
                    break;
                case 4:
                    gravitationalRatio = 0.377;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weight approximately {weightOnPlanet}kg on Mars");
                    break;
                case 5:
                    gravitationalRatio = 2.36;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weight approximately {weightOnPlanet}kg on Jupiter");
                    break;
                case 6:
                    gravitationalRatio = 0.916;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weight approximately {weightOnPlanet}kg on Saturn");
                    break;
                case 7:
                    gravitationalRatio = 0.889;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weight approximately {weightOnPlanet}kg on Uranus");
                    break;
                case 8:
                    gravitationalRatio = 1.12;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weight approximately {weightOnPlanet}kg on Neptune");
                    break;
                case 9:
                    gravitationalRatio = 0.071;
                    weightOnPlanet = gravitationalRatio * weight;
                    Console.WriteLine($"You weight approximately {weightOnPlanet}kg on Pluto");
                    break;
                default: Console.WriteLine("Enter a valid code.");
                    break;
            }



            }
    }
}
