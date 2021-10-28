using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.Ratings.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Ratings
{
    public class RatingNull : Rating
    {
        private readonly BikeRatingEngine _bikeRatingEngine;
        private readonly Printer _printer;

        public RatingNull(BikeRatingEngine bikeRatingEngine, Printer printer)
        {
            _bikeRatingEngine = bikeRatingEngine;
            _printer = printer;
        }
        public override void Rate(Bike bike)
        {
            Console.WriteLine("Un Known Bike");
        }
    }
}
