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
    public class Rating150cc : Rating
    {

        public Rating150cc(IPrinterService printerService) : base(printerService)
        {

        }
        public override decimal Rate(Bike bike)
        {
            Logger.Print("Rating 150 cc bike");
            Logger.Print("Validating Bike");
            if (string.IsNullOrEmpty(bike.Company))
            {
                Logger.Print("Must Sepcify Company");
                return 0m;
            }
            if (bike.Company == "Honda")
            {
                // _ratingUpdater.UpdateRating(4.2m);
                return 4.2m;


            }
            else if (bike.Company == "Suzuki")
            {
                // _ratingUpdater.UpdateRating(5.0m);
                return 5.0m;
            }
            return 0m;
        }

    }
}
