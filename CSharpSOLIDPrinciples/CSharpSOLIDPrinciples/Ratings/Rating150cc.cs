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
        //private readonly BikeRatingEngine _bikeRatingEngine;
        //private readonly Printer _printer;

        public Rating150cc(IRating context) : base(context)
        {

        }
        public override void Rate(Bike bike)
        {
            _logger.PrintOnConsole("Rating 150 cc bike");
            _logger.PrintOnConsole("Validating Bike");
            if (string.IsNullOrEmpty(bike.Company))
            {
                _logger.PrintOnConsole("Must Sepcify Company");
                return;
            }
            if (bike.Company == "Honda")
            {
                _context.UpdateRating(4.2m);
              

            }
            else if (bike.Company == "Suzuki")
            {
                _context.UpdateRating(5.0m);
            }
        }

    }
}
