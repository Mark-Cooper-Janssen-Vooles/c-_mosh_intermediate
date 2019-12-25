using System;

namespace _13_Properties
{
    public class Person
    {
        //public DateTime Birthdate { get; set; }

        //if we only want birthdate to be set once:
        //if this is the case, need to declare a constructor 
        public DateTime Birthdate { get; private set; }
        //can type "prop" and press tab
        public string Name { get; set; }
        public string Username { get; set; }


        public Person(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }

        //we want this age field to be based on the Birthdate.
        public int Age
        {
            //only use the get method, cos we're not setting age.
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            //person.Birthdate = new DateTime(1991, 11, 23); //can't do this with private set

            var person = new Person(new DateTime(1991, 11, 23));


            Console.WriteLine(person.Age);
        }
    }
}
