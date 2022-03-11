using System;
using Class.Model;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student telebe1 = new Student();
            telebe1.name = "Zulfiyye";
            telebe1.surname = "Huseynova";
            telebe1.age = 19;
            telebe1.FullName();
            Student telebe2 = new Student { name = "Ayse", surname = "Uluxanova", age = 20 };
            telebe2.FullName();
            Student telebe3 = new Student { name = "Aysu", surname = "Memmedova", age = 19 };
            telebe3.GetInfo();
            Student telebe4 = new Student("Sebine", "Novruzova", 21);
            Console.WriteLine($"Ad: {telebe4.name}, Soyad: {telebe4.surname}, Yas:{telebe4.age}");
            Teacher muellim1 = new Teacher("Ulvi","Abdullazade");
            Console.WriteLine($"Ad: {muellim1.name}, Soyad: {muellim1.surname}, Yas:{muellim1.age}");
        }
    }
}
