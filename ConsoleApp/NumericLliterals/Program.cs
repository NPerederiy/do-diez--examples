using System;

namespace NumericLliterals
{
    class Program
    {
        static void Main(string[] args)
        {
            // numeric literals in C# 7 can include underscores to improve readability
            var a = 1_000_000;
            Console.WriteLine($"a: {a}");

            // binary litaral can be specified with the 0b prefix
            var b = 0b1010_1011_1100_1101_1110_1111;
            Console.WriteLine($"b: {b}");

            // delay
            Console.ReadKey();
        }
    }
}
