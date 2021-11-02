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
    public class Rating125cc : Rating
    {

        public Rating125cc(IPrinterService printerService) : base(printerService)
        {

        }
        public override decimal Rate(Bike bike)
        {
            Logger.Print("Rating 125 cc bike");
            Logger.Print("Validating Bike");
            if (string.IsNullOrEmpty(bike.Company))
            {
                Logger.Print("Must Sepcify Company");
                return 0m;
            }
            if (bike.Company == "Honda")
            {
                return 4.9m;

            }
            else if (bike.Company == "Unique")
            {
                return 4.5m;
            }
            return 0m;
        }

    }
}
