using CSharpSOLIDPrinciples.Helpers;
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
    //    private readonly BikeRatingEngine _bikeRatingEngine;
    //    private readonly Printer _printer;

        public RatingNull(IRating context) : base(context)
        {

        }
        public override void Rate(Bike bike)
        {
            _logger.PrintOnConsole("Un Known Bike");
        }
    }
}
