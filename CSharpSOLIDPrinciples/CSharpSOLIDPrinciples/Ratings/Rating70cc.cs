using CSharpSOLIDPrinciples.Helpers;
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
        private readonly BikeRatingEngine _bikeRatingEngine;
        private readonly Printer _printer;

        public Rating70cc(BikeRatingEngine bikeRatingEngine, Printer printer)
        {
            _bikeRatingEngine = bikeRatingEngine;
            _printer = printer;
        }
        public override void Rate(Bike bike)
        {
            _printer.PrintOnConsole("Rating 70 cc bike");
            _printer.PrintOnConsole("Validating Bike");
            if (string.IsNullOrEmpty(bike.Company))
            {
                _printer.PrintOnConsole("Must Sepcify Company");
                return;
            }
            if (bike.Company == "Honda")
            {
                _bikeRatingEngine.Rating = 3.9m;

            }
            else if (bike.Company == "Unique")
            {
                _bikeRatingEngine.Rating = 3.5m;
            }
        }

    }
}
