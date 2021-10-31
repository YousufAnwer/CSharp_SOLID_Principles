using CSharpSOLIDPrinciples.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Helpers
{
    public class PrinterService:IPrinterService
    {
        public void PrintOnConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
