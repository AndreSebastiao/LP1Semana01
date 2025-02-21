using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string s ="Um tab\t e um copyright\u03A9" + 2;
            string t ="Isto é um teste";

            Console.WriteLine(s);
            Console.WriteLine(t);
        }
    }
}
