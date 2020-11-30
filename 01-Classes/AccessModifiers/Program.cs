using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1985, 10, 17));
            System.Console.WriteLine(person.GetBirthdate());
        }
    }
}
