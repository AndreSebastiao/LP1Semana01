using System;
using System.Text;

namespace VariousTypes
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Declaring simple Literals variables and it's values//
            double x    = 3.1415;
            float y     = 3.1415f;
            decimal z   = 3.1415m;
            int i       = 3;
            uint j      = 3U;
            long k      = 3L;
            ulong n     = 3UL;
            int a       = 0x10;
            uint b      = 0x10U;
            int c       = 0b10110110;
            int d       = 0b1011_0110;
            int e       = 0xFF_2B_4A;
            double f    = 1_712_432.23;
            double g    = 5.0e-10;

            char blackUpPointingTriangle = '\u25B2';
            char pointingUpIndex = '\u261D';
            char copyrightSymbol = '\u00A9';

            //Print values from the variables//
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(n);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(blackUpPointingTriangle);
            Console.WriteLine(pointingUpIndex);
        }
    }
}
