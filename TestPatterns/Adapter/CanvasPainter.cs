using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Adapter
{
    internal class CanvasPainter : IPainter
    {
        public void Paint()
        {
            Console.WriteLine("Holst");
        }
    }
}
