using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
  
    public class FuelTank
    {
        private double _capacity;
        public double Capacity { 
            get
            {
                return _capacity;
            }
            private set
            {
               
                 _capacity = value < 0 ? 0 : value;
            }
        }
        private double _level;
        public double Level {
            get
            {
                return _level;
            }
            private set
            {
                
                _level = value < 0 ? throw new Exception("Value less than 0!") : value > Capacity ? Capacity : value; 
            }
        }

        public FuelTank()
        {
            Capacity = 50;
            Level = 50;
        }

        public void BurnFuel(double litres)
        {
            
            Level -= litres;
        }

        public void Fill(double litres)
        {
           
            Level += litres;
        }
    }
}
