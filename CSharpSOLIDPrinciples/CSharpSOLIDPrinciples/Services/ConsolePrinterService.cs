using CSharpSOLIDPrinciples.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Helpers
{
    public class ConsolePrinterService:IPrinterService
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
