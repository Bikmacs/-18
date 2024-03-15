using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class International_Flight:Airport
    {
        private string destination_Country;
        private string intermediate_landings;

        public string Destination_Country
        {
            get { return destination_Country;  }
            set { destination_Country = value; }
        }
        public string Intermediate_landings
        {
            get { return  intermediate_landings; }
            set { intermediate_landings = value; }
        }
    }
}
