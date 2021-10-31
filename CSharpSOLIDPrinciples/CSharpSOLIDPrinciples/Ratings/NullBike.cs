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

        public RatingNull(IRatingUpdaterService ratingUpdater) : base(ratingUpdater)
        {

        }
        public override void Rate(Bike bike)
        {
            Logger.PrintOnConsole("Un Known Bike");
        }
    }
}
