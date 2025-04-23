using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Adapter
{
    internal class PaperPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Paper");
        }
    }
}
