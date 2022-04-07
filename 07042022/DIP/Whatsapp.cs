using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal class Whatsapp : IMessage
    {
        public void Send()
        {
            Console.WriteLine("MEsaj whatsapp userinden gonderildi");
        }
    }
}
