using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal interface ICar
    {
        public double FuelCapacity { get; set; }
        public string MachineType { get; set; }
    }
}
