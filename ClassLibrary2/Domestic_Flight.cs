using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Domestic_Flight:Airport
    {
        private int number_of_flights;

        public int Number_of_flights
        {
            get { return number_of_flights; }
            set { number_of_flights = value;}
        }
    }
}
