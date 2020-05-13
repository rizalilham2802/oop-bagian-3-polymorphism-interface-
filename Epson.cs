using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Epson : IPrinterWindows
    {
        public void Show(PrinterWindows show)
        {
            Console.WriteLine("Epson diplay dimension : 10*11");
        }
        public void Print(PrinterWindows print)
        {
            Console.WriteLine("Epson Printer printing. . .");
        }
    }
}
