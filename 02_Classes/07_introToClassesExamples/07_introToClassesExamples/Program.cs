using System;

namespace _07_introToClassesExamples
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}");
        }


        //create a person object from a string:
        //public Person Parse(string str)
        //{
        //    var person = new Person();
        //    person.Name = str;

        //    return person;
        //}

        //using static method: 
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Mark";
            person.Introduce("Mosh");

            //weirdly you can only call the Parse method on a person object lol, since it is not static yet.
            //var person2 = person.Parse("John");

            var person2 = Person.Parse("John");
            person2.Introduce("Mark");

        }
    }
}
