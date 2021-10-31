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
    public class Rating150cc:Rating
    {

        public Rating150cc(IRatingUpdaterService ratingUpdater) : base(ratingUpdater)
        {

        }
        public override void Rate(Bike bike)
        {
            Logger.PrintOnConsole("Rating 150 cc bike");
            Logger.PrintOnConsole("Validating Bike");
            if (string.IsNullOrEmpty(bike.Company))
            {
                Logger.PrintOnConsole("Must Sepcify Company");
                return;
            }
            if (bike.Company == "Honda")
            {
                _ratingUpdater.UpdateRating(4.2m);
              

            }
            else if (bike.Company == "Suzuki")
            {
                _ratingUpdater.UpdateRating(5.0m);
            }
        }

    }
}
