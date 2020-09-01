using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class Airplane : Vehicle
    {

        public DateTime DateTime { get; set; }
      

        public void StartEngine()
        {
            
            if (StartEngine == on)
            {
                throw new Exception("Engine is satart!");
            }
        
        }

       public void StopEngine()
        {
            
            if (StopEngine == off)
            {
                {
                    throw new Exception("Engine is off!");

                }
            }
            return;


        }






    }
}
