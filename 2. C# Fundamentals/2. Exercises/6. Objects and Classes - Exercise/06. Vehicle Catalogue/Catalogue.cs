using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Vehicle_Catalogue
{
    public class Catalogue
    {
        public Catalogue(string vehicleType, string model, string color, int horsePower)
        {
            VehicleType = vehicleType;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string VehicleType { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}
