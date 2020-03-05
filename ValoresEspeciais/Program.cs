using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            sbyte sbmax = sbyte.MaxValue;
            sbyte sbmin = sbyte.MinValue;

            int imax = int.MaxValue;
            int imin = int.MinValue;

            uint uimax = uint.MaxValue;
            uint uimin = uint.MinValue;

            double dmax = double.MaxValue;
            double dmin = double.MinValue;

            long lmax = long.MaxValue;
            long lmin = long.MinValue;

            ulong ulmax = ulong.MaxValue;
            ulong ulmin = ulong.MinValue;

            float fmax = float.MaxValue;
            float fmin = float.MinValue;

            short smax = short.MaxValue;
            short smin = short.MinValue;

            // Print values
            Console.WriteLine(sbmax);
            Console.WriteLine(sbmin);
            
            Console.WriteLine(imax);
            Console.WriteLine(imin);
            
            Console.WriteLine(uimax);
            Console.WriteLine(uimin);
            
            Console.WriteLine(dmax);
            Console.WriteLine(dmin);
            
            Console.WriteLine(lmax);
            Console.WriteLine(lmin);
            
            Console.WriteLine(ulmax);
            Console.WriteLine(ulmin);

            Console.WriteLine(fmax);
            Console.WriteLine(fmin);

            Console.WriteLine(smax);
            Console.WriteLine(smin);
        }
    }
}
