using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.FactoryMethod
{
    internal class EmaiMessage : Message
    {
        public EmaiMessage() 
        {
            Console.WriteLine("SendEmail");
        }
    }
}
