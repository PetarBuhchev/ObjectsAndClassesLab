using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog sparky = new Dog(Console.ReadLine(), int.Parse(Console.ReadLine()));
            sparky.Bark();
        }
    }
    public class Dog
    {
        public Dog(string name, int age) 
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get;set; }

        public void Bark()
        {
            Console.WriteLine($"My name is {Name} and I am {Age} years old, bark!!");
        }
    }
}
