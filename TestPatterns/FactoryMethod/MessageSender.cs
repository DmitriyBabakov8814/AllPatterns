using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.FactoryMethod
{
    abstract class MessageSender
    {
        public string Sender { get; set; }
        public MessageSender(string sender) 
        {
            Sender = sender; 
        }

        abstract public Message Send(string text);
    }
}
