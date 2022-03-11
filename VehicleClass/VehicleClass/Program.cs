using System;
using VehicleClass.Model;

namespace VehicleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { model = "Sedan", color = "Qara", passengerCount = 4 };
            car1.GetInfo();
            Car car2 = new Car { driveWay = 120, driveTime = 2 };
            car2.Speed();
            Bicycle bc1 = new Bicycle("Qirmizi");
            Console.WriteLine($"Rengi:{bc1.color}");
            Bus bus1 = new Bus(3.6);
            Console.WriteLine($"Motoru:{bus1.motor}");

        }
    }
}
