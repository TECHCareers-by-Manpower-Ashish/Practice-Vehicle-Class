using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car()
            {
                Make = "Who Knows",
                Model = "Badge Missing",
                Color = "Rusty",
                MaxOccupancy = 1,
                FuelEfficiency = 4,
                Odometer = new Odometer(564291),
                FuelTank = new FuelTank()
            };

            Console.WriteLine(myCar);

            myCar.Drive(30);

            Console.WriteLine(myCar);

        }
        
    }
}
