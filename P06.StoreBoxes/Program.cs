using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace P06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> info = new List<Box>();
            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                Box information = new Box();
                information.SerialNumber = int.Parse(input[0]);
                information.Item.Name = input[1];
                information.ItemQuantity = int.Parse(input[2]);
                information.Item.Price = double.Parse(input[3]);
                information.PriceForTheBox = (int.Parse(input[2])) * (double.Parse(input[3]));
                info.Add(information);

                input = Console.ReadLine().Split();
            }
            List<Box> sorted = new List<Box>();
            int indexList = 0;
            int countForLoop = info.Count;
            for (int i = 0; i < countForLoop; i++)
            {
            double biggest = 0.0;
                for (int j = 0; j < info.Count; j++)
                {
                    if (info[j].PriceForTheBox > biggest)
                    {
                        biggest = info[j].PriceForTheBox;
                        indexList = j;
                    }
                    else
                    {
                        continue;
                    }
                }
                sorted.Add(info[indexList]);
                info.RemoveAt(indexList);
            }

            foreach (Box informartion in sorted)
            {
                Console.WriteLine(informartion.SerialNumber);
                Console.WriteLine($"-- {informartion.Item.Name} - ${informartion.Item.Price:f2}: {informartion.ItemQuantity}");
                Console.WriteLine($"-- ${informartion.PriceForTheBox:f2}");
            }
        }

    }
        public class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
        class Box
        {
            public Box()
            {
                Item = new Item();
            }
            public BigInteger SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public double PriceForTheBox { get; set; }
        }
}
