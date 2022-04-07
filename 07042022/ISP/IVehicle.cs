using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal interface IVehicle
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Millage { get; set; }
        public void Drive(int km);
    }
}
