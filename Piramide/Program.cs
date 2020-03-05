using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string slines;
            int nlines;

            // Register number of lines and convert it
            Console.WriteLine("How many lines do you want?");
            slines = Console.ReadLine();
            nlines = Convert.ToInt32(slines);

            // For cycle, to build the pyramid
            for (int i = 0; i < nlines; i++)
            {
                // Variables for the cycle and respective calculus
                int spaces;
                int asterisks;
                spaces = nlines - i - 1;
                asterisks = i * 2 + 1;
                
                // Print spaces
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks
                for (int j = 0; j < asterisks; j++)
                {
                    Console.Write("*");
                }

                // Make a new line
                Console.WriteLine();
            }
        }
    }
}
