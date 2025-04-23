using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.FactoryMethod
{
    internal class SmsMessage : Message
    {
        public SmsMessage()
        {
            Console.WriteLine("SendSms");
        }
    }
}
