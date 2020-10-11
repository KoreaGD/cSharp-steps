using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outputs a carriage-return
            Console.WriteLine();
            // Outputs the greeting and a carriage-return
            Console.WriteLine("Hello CSharp, my name is Everton!");
            // Outputs a formated number and date a carriage-return
            Console.WriteLine("Temperature on {0:D} is {1}°C", DateTime.Today, 23);

        }
    }
}
