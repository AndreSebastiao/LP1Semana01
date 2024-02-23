using System;
using System.Formats.Asn1;
using System.Globalization;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            //Read the first input
            Console.WriteLine("Please input the first real number");
            string input1 = Console.ReadLine();
            float f1 = float.Parse(input1);

            //Output the results
            Console.WriteLine($"'{f1,6:f2}'");
        }
    }
}
