using System;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public Person(DateTime birtdate)
        {
            Birthdate = birtdate;
        }
        public DateTime Birthdate {get; private set;}

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years  = timeSpan.Days/365;

                return years;
            }
        }
    }
}