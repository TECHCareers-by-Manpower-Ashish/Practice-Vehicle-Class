using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CSharpOOP
{
    public class RunTimeCounter
    {



        private int _runtime;
        public int Runtime
        {
            get
            {
                return _runtime;
            }
            private set
            {
                
                _runtime = value > 999999 ? value % 1000000 : value;
            }






        }

    }
}
