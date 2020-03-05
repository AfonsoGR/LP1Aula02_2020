using System;
using System.Text;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Variables Phase 01
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

            // Print values Phase 01
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

            // Variables Phase 02
            double dp = double.PositiveInfinity;
            double dn = double.NegativeInfinity;

            float fp = float.PositiveInfinity;
            float fn = float.PositiveInfinity;

            double x = double.PositiveInfinity;
            float y = float.NaN;

            // Print values Phase 02
            Console.WriteLine(dp);
            Console.WriteLine(dn);
            Console.WriteLine(fp);
            Console.WriteLine(fn);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
