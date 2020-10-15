using System;

namespace ComparingTypes {
    class Program {
        static void Main (string[] args) {
            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3) {
                Console.WriteLine ($"{a} + {b} equals 0.3");
            } else {
                Console.WriteLine ($"{a} + {b} does NOT equal 0.3");
            }

            Console.WriteLine ("Using decimals");

            decimal c = 0.1M; // M suffix means a decimal literal value
            decimal d = 0.2M;

            if (c + d == 0.3M) {
                Console.WriteLine ($"{c}+{d} equals 0.3");
            } else {
                Console.WriteLine ($"{c}+{d} not eaqual 0.3");
            }
        }
    }
}