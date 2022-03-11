using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleClass.Model
{
    class Bus:Vehicle
    {
        public Bus()
        {

        }
        public double motor;

        public Bus(int cycle)
        {
            this.cycle = cycle;
        }
        public Bus(string color)
        {
            this.color = color;
        }
        public Bus(string color, string model) : this(color)
        {
            this.model = model;
        }
        public Bus(string color, string model, int passengerCount) : this(color, model)
        {
            this.passengerCount = passengerCount;
        }
        public Bus(double motor)
        {
            this.motor = motor;
        }
    }
}
