using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //String contents
            string a = "\u00A9\n\u261D isto é um copyright";
            string b = "\u25B2 isto é apenas uma mão a apontar para cima";
            string c = "ah, e aquilo era so uma seta para cima tambem";

            //Print of content
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
