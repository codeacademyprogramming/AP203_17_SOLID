using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal class Email: IMessage
    {
        public void Send()
        {
            Console.WriteLine("Mesaj Email uzerinde gonderildi");
        }
    }
}
