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
        //private readonly BikeRatingEngine _bikeRatingEngine;
        //private readonly Printer _printer;

        public Rating70cc(IRating context) : base(context)
        {

        }
        public override void Rate(Bike bike)
        {
            _logger.PrintOnConsole("Rating 70 cc bike");
            _logger.PrintOnConsole("Validating Bike");
            if (string.IsNullOrEmpty(bike.Company))
            {
                _logger.PrintOnConsole("Must Sepcify Company");
                return;
            }
            if (bike.Company == "Honda")
            {
                _context.UpdateRating(3.9m);

            }
            else if (bike.Company == "Unique")
            {
                _context.UpdateRating(3.5m);
            }
        }

    }
}
