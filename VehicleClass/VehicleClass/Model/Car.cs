using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleClass.Model
{
    class Car:Vehicle
    {
        public double motor;
        public Car()
        {

        }
        public Car(int cycle)
        {
            this.cycle = cycle;
        }
        public Car(string color)
        {
            this.color = color;
        }
        public Car(string color, string model) : this(color)
        {
            this.model = model;
        }
        public Car(string color, string model, int passengerCount) : this(color, model)
        {
            this.passengerCount = passengerCount;
        }
        public Car(double motor)
        {
            this.motor = motor;
        }
    }
}
