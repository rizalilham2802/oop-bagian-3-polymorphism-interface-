using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class LaserJet:IPrinterWindows
    {
        public void Show(PrinterWindows show)
        {
            Console.WriteLine("LaserJet diplay dimension : 12*12");
        }
        public void Print(PrinterWindows print)
        {
            Console.WriteLine("LaserJet Printer printing. . .");
        }
    }
}
