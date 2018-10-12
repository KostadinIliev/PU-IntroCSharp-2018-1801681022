using System;

namespace TravelingToSunWithSoundSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            double speedofSound = 1234.8;
            //speed of sound in dry air at 20 °C
            int distancetoSun = 149600000;
            //This distance to Sun is in km7
            double timeNeeded = Math.Round(distancetoSun / speedofSound);
            double timeNeededInYears = Math.Floor(timeNeeded / 8760);
            double leftOverDays = Math.Floor(((timeNeeded / 8760) - timeNeededInYears) * 365);
            Console.WriteLine($"The time needed to travel from the Earth to the Sun is {timeNeeded} hours,or " + $"{timeNeededInYears} years and { leftOverDays} days.");

        }
    }
}
