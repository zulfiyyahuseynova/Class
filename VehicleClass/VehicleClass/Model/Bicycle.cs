using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleClass.Model
{
    class Bicycle:Vehicle
    {
        public Bicycle()
        {

        }
        public Bicycle(int cycle)
        {
            this.cycle = cycle;
        }
        public Bicycle(string color)
        {
            this.color = color;
        }
        public Bicycle(string color, string model):this(color)
        {
            this.model = model;
        }
        public Bicycle(string color, string model, int passengerCount):this(color,model)
        {
            this.passengerCount = passengerCount;
        }
    }
}
