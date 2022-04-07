using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal class SMS: IMessage
    {
        public void Send()
        {
            Console.WriteLine("Mesaj SMS uzerinden gonderildi");
        }
    }
}
