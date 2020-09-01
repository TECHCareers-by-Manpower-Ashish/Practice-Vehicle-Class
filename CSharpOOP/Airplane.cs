using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    public class Airplane : Vehicle
    {

        public DateTime Date { get; set; }
        public DateTime Date
        {
            get;
            set
            {
                Date = DateTime.Now;
            }
        }

        public void StartEngine()
        {
            Date = DateTime.Now;
            if (StartEngine == on)
            {
                throw new Exception("Engine is satart!");
            }
        
        }

       public void StopEngine()
        {
            Date = DateTime.Now;
            if (StopEngine == off)
            {
                {
                    throw new Exception("Engine is satart!");

                }
            }
            return;


        }






    }
}
