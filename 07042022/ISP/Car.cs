using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal class Car : IVehicle,ICar
    {
        public string Model { get ; set ; }
        public string Brand { get; set; }
        public double FuelCapacity { get; set; }
        public int Millage { get; set; }

        public void Drive(int km)
        {
            Millage += km;
        }
    }
}
