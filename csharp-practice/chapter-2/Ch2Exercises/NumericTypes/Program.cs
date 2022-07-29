using System;

namespace NumericTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            double recLength;
            double recWidth;
            double recArea;
            string input;

            
            Console.WriteLine("Area of Rectangle");

            Console.WriteLine("What is the length of your rectangle?");
            input = Console.ReadLine();
            recLength = double.Parse(input);

            Console.WriteLine("What is the width of your rectangle?");
            input = Console.ReadLine();
            recWidth = double.Parse(input);

            recArea = recLength * recWidth;
            Console.WriteLine("The area of your rectangle is: " + recArea);
            Console.ReadLine();
        }
    }
}
