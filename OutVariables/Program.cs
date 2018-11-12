using System;

namespace OutVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring out variables on the fly
            int.TryParse("12_484_001", out int c);
            Console.WriteLine($"c: {c}");

            int.TryParse("12484001", out int d);
            Console.WriteLine($"d: {d}");

            // discarding out params we’re uninterested in with the underscore character
            {
                Foo(out _, out _, out int e);
                Console.WriteLine($"e: {e}");

                void Foo(out int a, out int b, out int c)
                {
                    a = b = c = 81;
                }
            }

            // delay
            Console.ReadKey();
        }
    }
}
