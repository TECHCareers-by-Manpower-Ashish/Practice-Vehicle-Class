using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public abstract class Vehicle : Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaxOccupancy { get; set; }
        public double FuelEfficiency { get; set; }
               
        public FuelTank FuelTank { get; set; }



    }
}
