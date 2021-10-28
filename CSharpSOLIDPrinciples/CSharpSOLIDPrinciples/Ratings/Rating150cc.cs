using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.Ratings.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Ratings
{
    public class Rating150cc:Rating
    {
        private readonly BikeRatingEngine _bikeRatingEngine;
        private readonly Printer _printer;

        public Rating150cc(BikeRatingEngine bikeRatingEngine, Printer printer)
        {
            _bikeRatingEngine = bikeRatingEngine;
            _printer = printer;
        }
        public override void Rate(Bike bike)
        {
            _printer.PrintOnConsole("Rating 150 cc bike");
            _printer.PrintOnConsole("Validating Bike");
            if (string.IsNullOrEmpty(bike.Company))
            {
                _printer.PrintOnConsole("Must Sepcify Company");
                return;
            }
            if (bike.Company == "Honda")
            {
                _bikeRatingEngine.Rating = 4.2m;

            }
            else if (bike.Company == "Suzuki")
            {
                _bikeRatingEngine.Rating = 5.0m;
            }
        }

    }
}
