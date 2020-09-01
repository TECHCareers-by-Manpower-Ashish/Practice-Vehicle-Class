using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane myAirplane = new Airplane()
            {
               
            };

            Console.WriteLine(myAirplane);

            myAirplane.Drive(30);

            Console.WriteLine(myAirplane);

        }
        
    }
}
