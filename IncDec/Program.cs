using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int a = 3;
            int b = -7;
            int c1;
            int c2;
            int c3;
            int c4;
            int c5;
            int c6;
            int c7;
            int c8;

            // Suffix
            c1 = a++ + b++;
            c2 = a-- + b--;
            c3 = a++ - b++;
            c4 = a-- - b--;

            // Preffix
            c5 = ++a + ++b;
            c6 = --a + --b;
            c7 = ++a - ++b;
            c8 = --a - --b;

            // Prints results
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
        }
    }
}
