using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Vehicle_Catalogue
{
    internal class VehicleCatalog
    {
        public VehicleCatalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; }
        public List<Truck> Trucks { get; }
    }
}
