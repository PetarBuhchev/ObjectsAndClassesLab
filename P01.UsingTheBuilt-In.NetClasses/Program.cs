using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.UsingTheBuilt_In.NetClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Random random = new Random();

            for (int i = 0; i < input.Length; i++) 
            {
                string temp = input[i];
                int randomIndex = random.Next(0, input.Length);
                string randomized = input[randomIndex];

                input[i] = randomized;
                input[randomIndex] = temp;
            }
            foreach (string value in input)
            {
                Console.WriteLine(value);
            }
        }
    }
}
