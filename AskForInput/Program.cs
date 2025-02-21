using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Escreve um número inteiro:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora escreve um número real:");
            float b = float.Parse(Console.ReadLine());


            float c = a + b;
            Console.WriteLine(c);
        }
    }
}
