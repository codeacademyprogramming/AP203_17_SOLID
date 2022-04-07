using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    internal class Bicycle : IVehicle
    {
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Brand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Millage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive(int km)
        {
            throw new NotImplementedException();
        }
    }
}
