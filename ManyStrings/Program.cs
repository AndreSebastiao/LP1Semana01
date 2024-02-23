using System;
using System.Security.Cryptography.X509Certificates;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            char u = '\u261E';
            float x = 3.1415f;
            double xx = 1.23456;
            int ii = 19;

            //String contents
            string a = "\u00A9\n\u261D isto é um copyright";
            string b = "\u25B2 isto é apenas uma mão a apontar para cima";
            string c = "ah, e aquilo era so uma seta para cima tambem";
            string d = "Eu vou naquela " + u + " direção";
            string e = $"o valor de x é {x}";
            string f = $"xx = {xx:f2}";
            string g = $"xx = {xx:p1}";
            string h = $"ii = {ii:x}";
            string i = $"ii = {ii:c}";

            //Print of content
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
        }
    }
}
