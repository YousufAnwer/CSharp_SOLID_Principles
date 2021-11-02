using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Ratings.Abstract
{
    public abstract class Rating
    {
        protected  IPrinterService Logger { get; set; } = new ConsolePrinterService();
        public Rating(IPrinterService logger)
        {
            Logger = logger;
        }
        public abstract decimal Rate(Bike bike);
    }
}
