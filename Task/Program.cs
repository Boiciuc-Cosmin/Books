using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task
{
    public class Person
    {
        private string[] nume;
        private int[] id;
        public string FilePath;

        public string Name { get; set; }
        public int Id { get; set; }

        public string Display()
        {
            return Id + " " + Name;
        }

        public void Displaya()
        {
            var total = id.Zip(nume, (first, second) => first + " " + second);
            foreach (var item in total)
            {
                Console.WriteLine(item);
            }
        }

        public void GetPerson(int i)
        {
            var total = id.Zip(nume, (first, second) => first + " " + second);
            foreach (var item in total)
            {
                string[] items = item.Split(" ");
                int ia = int.Parse(items[0]);
                if (ia == i)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public Person()
        {
        }

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public Person(string[] nume, int[] id)
        {
            this.nume = nume;
            this.id = id;
        }
    }

    public class Attendees
    {
        public List<Person> People { get; } = new List<Person>();
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string filepath = @"D:\Learning_Projects\02_Books\Task\bin\Debug\netcoreapp3.1\ceva.txt";
            string[] nume = { "ceva", "altceva", "altceva" };
            int[] id = { 5, 6, 7 };

            List<Person> people = new List<Person>()
            {
                new Person {Id = 3 , Name = "Georgeta Maria"},
                new Person {Id = 4 , Name = "ASD ASD"},
                new Person {Id = 5 , Name = "AasdD ASD"},
                new Person (nume, id)
            };

            people = people.Where(person => person.Id == 5).ToList();

            var person1 = new Person(nume, id);
            Attendees attendees = new Attendees();

            foreach (var items in people)
            {
                attendees.People.Add(items);
            }
            foreach (var item in attendees.People)
            {
                Console.WriteLine(item.Display());
                
            }
            person1.Displaya();

            //Add from file
            List<Person> peopleFromFile = new List<Person>();
            List<string> lines = File.ReadAllLines(filepath).ToList();

            //foreach (var line in lines)
            //{
            //    string[] entries = line.Split(',');

            //    Person newPerson = new Person();
            //    newPerson.Name = entries[1];
            //    newPerson.Id = int.Parse(entries[0]);

            //    peopleFromFile.Add(newPerson);
            //}

            foreach (var item in peopleFromFile)
            {
                Console.WriteLine($"{item.Name} {item.Id}");
            }

            person1.GetPerson(3);
        }
    }
}