using System;

namespace Travel2TheSunWithSoundSpeedInWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance2SunFromEarth= 149600000;
            short speedOfSoundIn20DegreeWater = 1481;

            double timeNeeded = (double)distance2SunFromEarth / speedOfSoundIn20DegreeWater;


            Console.WriteLine($"Time needed:{timeNeeded}");
        }
    }
}
