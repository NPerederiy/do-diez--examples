using System;
using System.Collections.Generic;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = GetRange(new int[] {1, 23, 3, 5, 0, 13, 21});

            Console.WriteLine($"Max: { range.Max }\nMin: { range.Min }");

            // delay
            Console.ReadKey();
        }

        private static (int Max, int Min) GetRange(IEnumerable<int> numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (var n in numbers)
            {
                min = (n < min) ? n : min;
                max = (n > max) ? n : max;
            }
            return (max, min); 
        }
    }
}
