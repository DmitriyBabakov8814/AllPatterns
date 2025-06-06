﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.FactoryMethod
{
    internal class SmsMessageSender : MessageSender
    {
        public SmsMessageSender(string sender) : base(sender){ }

        public override Message Send(string text)
        {
            return new SmsMessage();
        }
    }
}
