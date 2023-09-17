using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string[] infoPerson = Console.ReadLine().Split();

            while (infoPerson[0] != "end")
            {
                Person person = new Person();
                person.FirstName = infoPerson[0];
                person.LastName = infoPerson[1];
                person.Age = int.Parse(infoPerson[2]);
                person.HomeTown = infoPerson[3];

                if (ExistingStudent(persons, infoPerson[0], infoPerson[1]))
                {
                    Person people = Get
                }



                persons.Add(person);
                infoPerson = Console.ReadLine().Split();
            }
            string city = Console.ReadLine();

            foreach (Person person in persons)
            {
                if (person.HomeTown == city)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");
                }
            }
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
        static bool ExistingStudent (List<Person> people, string firstName, string lastName)
        {
            foreach (Person person in people) 
            {
                if (person.FirstName == firstName && person.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
