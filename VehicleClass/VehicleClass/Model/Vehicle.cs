using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleClass.Model
{
    class Vehicle
    {
        public string model;
        public string color;
        public int cycle;
        public int driveWay;
        public int driveTime;
        public int getSpeed;
        public int passengerCount;

        public void GetInfo()
        {
            Console.WriteLine($"Modeli: {model}, Rengi: {color}, Oturacaqlarin sayi: {passengerCount}");
        }
        public void Speed()
        {
            Console.WriteLine($"Sureti: {driveWay/driveTime}");
        }
        public void Way()
        {
            Console.WriteLine($"Gedilen yol: {getSpeed*driveTime}");
        }
        public void Time()
        {
            Console.WriteLine($"Sureti: {driveWay / getSpeed}");
        }
    }

}
