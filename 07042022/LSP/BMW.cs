using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    internal class BMW : Car,IAirConditioner
    {
        public void StartAirConditioner()
        {
            Console.WriteLine("Kondisoner ise dusdu");
        }

        public override void StartDrive()
        {
            Console.WriteLine("Masin uguldadi ve ise dusdu");
        }
    }
}
