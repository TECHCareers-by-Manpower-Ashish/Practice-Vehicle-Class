using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    /*
        Create a “Car” class that has the following properties:
        Make (Chevrolet, Nissan, Toyota)
        Model (Camry, Corolla, Cruze)
        Color (Red, Green, Blue, Black)
        Maximum Occupancy (Number of Seats)
        FuelEfficiency (Number of KM per Litre, can have decimals)
        Odometer - object reference
        FuelTank - object reference.
        and methods:
        Drive() and Drive(km) - call BurnFuel() and Increment() on the fuel tank and odometer, respectively, according to fuel efficiency.
        A ToString() override that will output the format “A Blue Chevy Cruze with 60050KM on the odometer, that has enough fuel to travel 65KM.”
        Both a default and greedy constructor (initialize object references as a new instance).
    */
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

        public Car()
        {
            Make = "Toyota";
            Model = "Camry";
            Color = "Grey";
            MaxOccupancy = 5;
            FuelEfficiency = 10;
            Odometer = new Odometer();
            FuelTank = new FuelTank();
        }
        public Car(string make, string model, string color, int maxOccupancy, double fuelEfficiency)
        {
            Make = make;
            Model = model;
            Color = color;
            MaxOccupancy = maxOccupancy;
            FuelEfficiency = fuelEfficiency;
            Odometer = new Odometer();
            FuelTank = new FuelTank();
        }

        public override string ToString()
        {
            return $"A {Color} {Make} {Model} with {Odometer} on the odometer, that has enough fuel to travel {FuelTank.Level * FuelEfficiency}KM.";
        }
    }
}
