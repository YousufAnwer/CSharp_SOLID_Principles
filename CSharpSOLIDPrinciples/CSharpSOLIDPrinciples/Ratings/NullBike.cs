using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.IServices;
using CSharpSOLIDPrinciples.Ratings.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Ratings
{
    /// <summary>
    /// using for applying Liskov's substitution principle
    /// </summary>
    public class RatingNull : Rating
    {

        public RatingNull(IPrinterService printerService) : base(printerService)
        {

        }
        public override decimal Rate(Bike bike)
        {
            Logger.Print("Un Known Bike");
            return 0m;
        }
    }
}
