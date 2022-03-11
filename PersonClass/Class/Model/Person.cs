using System;
using System.Collections.Generic;
using System.Text;

namespace Class.Model
{
    class Person
    {
        public string name;
        public string surname;
        public int age;

        public void FullName()
        {
            Console.WriteLine($"{name} {surname}");
        }

        public void GetInfo()
        {
            Console.WriteLine($"{name} {surname} {age}");
        }
    }
}
