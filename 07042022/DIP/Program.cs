using System;
using System.Collections.Generic;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SMS sms = new SMS();
            Email email = new Email();

            //sms.Send();
            //email.Send();

            Notification notification = new Notification(new List<IMessage> { sms,email, new Whatsapp()});
            notification.Send();
        }
    }
}
