using System;

namespace PatternVariables
{
    class Program
    {
        static void Main(string[] args)
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

            // delay
            Console.ReadKey();
        }
    }
}
