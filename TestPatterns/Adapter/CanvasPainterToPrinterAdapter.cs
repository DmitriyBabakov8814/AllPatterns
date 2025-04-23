using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Adapter
{
    internal class CanvasPainterToPrinterAdapter : IPrinter
    {
        private CanvasPainter canvasPainter;

        public CanvasPainterToPrinterAdapter(CanvasPainter canvasPainter)
        {
            this.canvasPainter = canvasPainter;
        }

        public void Print()
        {
            canvasPainter.Paint();
        }

    }
}
