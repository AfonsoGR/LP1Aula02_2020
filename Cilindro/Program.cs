using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string height;
            float h;
            string radius;
            float r;
            float v;
            float sa;
            const float pi = 3.1415926f;

            // Ask for user inputs
            Console.WriteLine("What's the height of the cylinder?");
            height = Console.ReadLine();
            Console.WriteLine("What's the radius of the cylinder?");
            radius = Console.ReadLine();   

            // Convert floats into strings
            h = float.Parse(height);
            r = float.Parse(radius);

            // Calculating volume and surface area
            v = pi * (r * r) * h;
            sa = 2 * pi * r * (r + h); 

            // Presenting results
            Console.WriteLine("The volume of the cylinder is " + v); 
            Console.WriteLine("The surface area of the cylinder is " + sa); 
        }
    }
}
