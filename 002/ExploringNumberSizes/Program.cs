using System;

namespace ExploringNumberSizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:NO} to {int.MaxValue:NO}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:NO} to {double.MaxValue:NO}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:NO} to {decimal.MaxValue:NO}.");
        }
    }
}
