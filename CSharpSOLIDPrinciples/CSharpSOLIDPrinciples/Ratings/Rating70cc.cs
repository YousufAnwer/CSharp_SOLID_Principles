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
    public class Rating70cc : Rating
    {

        public Rating70cc(IPrinterService printerService) : base(printerService)
        {

        }
        public override decimal Rate(Bike bike)
        {
            Logger.Print("Rating 70 cc bike");
            Logger.Print("Validating Bike");
            if (string.IsNullOrEmpty(bike.Company))
            {
                Logger.Print("Must Sepcify Company");
                return 0m;
            }
            if (bike.Company == "Honda")
            {
                //_ratingUpdater.UpdateRating(3.9m);
                return 3.9m;

            }
            else if (bike.Company == "Unique")
            {
                // _ratingUpdater.UpdateRating(3.5m);
                return 3.5m;
            }
            return 0m;
        }

    }
}
