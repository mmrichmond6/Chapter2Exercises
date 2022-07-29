using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesDriven;
            double gallonsUsed;
            double milesPerGallon;
            string input;
            
            Console.WriteLine("Calculate Your Mileage");
            Console.WriteLine("How many miles did you drive?");
            input = Console.ReadLine();
            milesDriven = double.Parse(input);

            Console.WriteLine("How many gallons did you use?");
            input = Console.ReadLine();
            gallonsUsed = double.Parse(input);

            milesPerGallon = milesDriven / gallonsUsed;
            Console.WriteLine("Your miles per gallon calculation is:  " + milesPerGallon + " mpg");
            Console.ReadLine();
        }
    }
}
