using System;

namespace ManyStrings
{

    public class Program
    {
        private static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;

            string s1 =$"{xx:f2}";
            string s2 =$"{xx:p1}";

            string s3 =$"{ii:x}";
            string s4 =$"{ii:c}";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            string s ="Um tab\t e um copyright\u03A9" + 2;
            string t ="Isto é um teste";

            Console.WriteLine(s);
            Console.WriteLine(t);
        }
    }
}
