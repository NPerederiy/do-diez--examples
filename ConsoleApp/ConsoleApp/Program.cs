using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ------ digit separstors in numeric literals ------ */
            { 
                var a = 1_000_000;
                Console.WriteLine($"a: {a}");

                // binary litaral can be specified with the 0b prefix
                var b = 0b1010_1011_1100_1101_1110_1111;
                Console.WriteLine($"b: {b}");

                // declaring out variables on the fly
                int.TryParse("12_484_001", out int c);
                Console.WriteLine($"c: {c}");

                int.TryParse("12484001", out int d);
                Console.WriteLine($"d: {d}");
            }
            
            /* ------ out variables and discards ------ */

            // discarding out params we’re uninterested in with the underscore character
            {
                Foo(out _, out _, out int e);
                Console.WriteLine($"e: {e}");

                void Foo(out int a, out int b, out int c)
                {
                    a = b = c = 81;
                }
            }

            /* ------ pattern variables ------ */

            {
                Foo(111);
                Foo("some string");
                Bar(null);
                Bar(true);

                void Foo(object x)
                {
                    if (x is string s)
                        Console.WriteLine(s.Length);
                }

                void Bar(object x)
                {
                    switch (x)
                    {
                        case int i:
                            Console.WriteLine("It's an int!");
                            break;
                        case string s:
                            Console.WriteLine(s.Length); // We can use the s variable
                            break;
                        case bool b when b == true: // Matches only when b is true
                            Console.WriteLine("True");
                            break;
                        case null:
                            Console.WriteLine("Nothing");
                            break;
                    }
                }
            }

            /* ------  ------ */

            Console.WriteLine(Cube(5));

            int Cube(int value) => value * value * value;

            // delay
            Console.ReadKey();
        }        
    }
}
