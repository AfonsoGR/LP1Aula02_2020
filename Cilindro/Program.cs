using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string height;
            double h;
            string radius;
            double r;
            double v;
            double sa;

            // Ask for user inputs
            Console.WriteLine("What's the height of the cylinder?");
            height = Console.ReadLine();
            Console.WriteLine("What's the radius of the cylinder?");
            radius = Console.ReadLine();   

            // Convert floats into strings
            h = double.Parse(height);
            r = double.Parse(radius);

            // Calculating volume and surface area
            v = Math.PI * Math.Pow(r, 2) * h;
            sa = 2 * Math.PI * r * (r + h); 

            // Presenting results
            Console.WriteLine("The volume of the cylinder is " + v); 
            Console.WriteLine("The surface area of the cylinder is " + sa); 
        }
    }
}
