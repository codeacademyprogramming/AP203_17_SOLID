using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    internal class Notification
    {
        
        List<IMessage> _messages { get; set; }

        public Notification(List<IMessage> messages)
        {
            _messages = messages;  
        }

        public void Send()
        {
            foreach (var item in _messages)
            {
                item.Send();
            }
        }
    }
}
