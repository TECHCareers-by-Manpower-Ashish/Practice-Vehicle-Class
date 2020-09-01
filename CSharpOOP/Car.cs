using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
   
    public class Car : Vehicle
    {
        public string Make {get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaxOccupancy { get; set; }
        public double FuelEfficiency { get; set; }

        public Odometer Odometer { get; set; }
        public FuelTank FuelTank { get; set; }

        public void Drive()
        {
            Drive(100);
        }

        public void Drive(int km)
        {
            Odometer.Increment(km);
            FuelTank.BurnFuel(km / FuelEfficiency);
        }

        
        public override string ToString()
        {
            return $"A {Color} {Make} {Model} with {Odometer} on the odometer, that has enough fuel to travel {FuelTank.Level * FuelEfficiency}KM.";
        }
    }
}
