using System;
using System.Collections.Generic;
using System.Text;

namespace Class.Model
{
    class Student:Person
    {
        public string course;

        public Student()
        {
            Console.WriteLine("Yeni telebe yaradildi");
        }
        public Student(string name)
        {
            this.name = name;
        }
        public Student(string name, string surname):this(name)
        {
            this.surname = surname;
        }
        public Student(string name, string surname, int age):this(name,surname)
        {
            this.age = age;
        }
    }
}
