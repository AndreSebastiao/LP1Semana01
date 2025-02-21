using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = 
            CultureInfo.InvariantCulture;

            Console.WriteLine("Insere 4 números reais entre 0 e 1:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            string s1 =$"{a,8:p2}";
            string s2 =$"{b,8:p2}";
            string s3 =$"{c,8:p2}";
            string s4 =$"{d,8:p2}";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }
    }
}
