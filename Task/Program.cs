using System;
using System.Collections.Generic;

namespace Task
{
    public class Person 
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Display()
        {
            return Id + " " + Name;
        }

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public Person()
        {

        }

    }
    public class Attendees
    {
        public List<Person> People { get; } = new List<Person>();
      
    }    

   
    class Program
    {
        static void Main(string[] args)
        {
            string nume = "ceva";
            int id = 7;
            List<Person> people = new List<Person>()
            {
                new Person {Id = 3 , Name = "Georgeta Maria"},
                new Person {Id = 4 , Name = "ASD ASD"},
                new Person {Id = 5 , Name = "AasdD ASD"},
                new Person(nume, id)
            };
            
            
            Attendees attendees = new Attendees();
            
            foreach (var items in people)
            {
                attendees.People.Add(items);
            }
            foreach (var item in attendees.People)
            {
                Console.WriteLine(item.Display());
            }
            
            
        }
    }
}
