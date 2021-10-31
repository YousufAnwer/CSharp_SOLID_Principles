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
    public class Rating125cc : Rating
    {

        public Rating125cc(IRatingUpdaterService ratingUpdater) : base(ratingUpdater)
        {

        }
        public override void Rate(Bike bike)
        {
            Logger.PrintOnConsole("Rating 125 cc bike");
            Logger.PrintOnConsole("Validating Bike");
            if (string.IsNullOrEmpty(bike.Company))
            {
                Logger.PrintOnConsole("Must Sepcify Company");
                return;
            }
            if (bike.Company == "Honda")
            {
                _ratingUpdater.UpdateRating(4.9m);

            }
            else if (bike.Company == "Unique")
            {
                _ratingUpdater.UpdateRating(4.5m);
            }
        }

    }
}
