﻿using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for Input
            Console.WriteLine("Please submit a whole number");

            //Read Input
            string input = Console.ReadLine();

            //Transform the input in to a int
            int i = int.Parse(input);
            Console.WriteLine($"this is in i: {i}");
             
            //Input of a new number
            Console.WriteLine("Please summit a real number");
            string input2 = Console.ReadLine();
            
            //Save the input in to a float
            float f = float.Parse(input2);

            //Give the result
            var result = 1 + f;
            Console.WriteLine($"Here's the result = {result}");
        }
    }
}