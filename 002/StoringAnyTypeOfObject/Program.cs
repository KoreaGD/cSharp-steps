using System;

namespace StoringAnyTypeOfObject
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // storing a double in an object
            object name = "Anir"; // storing a string in an object

            Console.WriteLine($"{name} is {height} metres tall.");

            // int length1 = name.Length; // gives compie error!
            int length2 = ((string)name).Length; // tell compiler it is a string

            Console.WriteLine($"{name} has {length2} caracters.");

        }
    }
}
