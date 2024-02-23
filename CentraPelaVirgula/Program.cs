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

            //Read the second input
            Console.WriteLine("Please input the second real number");
            string input2 = Console.ReadLine();
            float f2 = float.Parse(input2);

            //Read the third input
            Console.WriteLine("Please input the third real number");
            string input3 = Console.ReadLine();
            float f3 = float.Parse(input2);

            //Read the forth input
            Console.WriteLine("Please input the forth real number");
            string input4 = Console.ReadLine();
            float f4 = float.Parse(input2);

            //Output the results
            Console.WriteLine($"'{f1,6:f2}'");
            Console.WriteLine($"'{f2,6:f2}'");
            Console.WriteLine($"'{f3,6:f2}'");
            Console.WriteLine($"'{f4,6:f2}'");
        }
    }
}
