using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Canon : IPrinterWindows
    {
        public void Show(PrinterWindows show)
        {
            Console.WriteLine("Canoon diplay dimension : 9.5*12");
        }
        public void Print(PrinterWindows print)
        {
            Console.WriteLine("canon Printer printing. . .");
        }
    }
}
