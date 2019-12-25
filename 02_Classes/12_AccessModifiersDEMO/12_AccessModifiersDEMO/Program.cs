using System;

namespace _12_AccessModifiersDEMO
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return this._birthdate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1991, 1, 1));

            Console.WriteLine(person.GetBirthDate());
        }
    }
}
