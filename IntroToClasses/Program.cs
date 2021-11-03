using System;

namespace IntroToClasses
{
    public class Constructors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write three names and press enter key");
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public Person(string name) //constructor
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Hello my name is {Name}...slim shady";
        }

        ~Person() //indicates a destructor
        {
            Name = string.Empty;
        }
    }
}
