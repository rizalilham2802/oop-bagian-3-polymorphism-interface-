using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows show = new PrinterWindows();
            PrinterWindows print = new PrinterWindows();

            Console.WriteLine("Pilih Printer :");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canoon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write(" Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            IPrinterWindows printer;

            if (nomorPrinter == 1)
            {
                printer = new Epson();
            }
            else if (nomorPrinter == 2)
            {
                printer = new Canon();
            }
            else
            {
                printer = new LaserJet();
            }
            printer.Show(show);
            printer.Print(print);

            Console.ReadKey();
        }
    }
}
