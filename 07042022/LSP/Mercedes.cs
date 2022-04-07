using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    internal class Mercedes : Car,IAirConditioner
    {
        public void StartAirConditioner()
        {
            Console.WriteLine("Kondisoner ise dusdu");
        }

        public override void StartDrive()
        {
            Console.WriteLine("Masin ise dusdu");
        }
    }
}
