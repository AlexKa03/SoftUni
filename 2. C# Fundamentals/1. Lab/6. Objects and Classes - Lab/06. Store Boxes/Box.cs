using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Store_Boxes
{
    internal class Box
    {
        public Box()
        {
            ItemName = new Item();
        }

        public int SerialNumber { get; set; }
        public Item ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public double BoxPrice { get; set; }
    }
}
