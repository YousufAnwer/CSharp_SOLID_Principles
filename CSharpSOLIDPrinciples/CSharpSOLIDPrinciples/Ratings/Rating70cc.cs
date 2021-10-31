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
    public class Rating70cc : Rating
    {

        public Rating70cc(IRatingUpdaterService ratingUpdater) : base(ratingUpdater)
        {

        }
        public override void Rate(Bike bike)
        {
            Logger.PrintOnConsole("Rating 70 cc bike");
            Logger.PrintOnConsole("Validating Bike");
            if (string.IsNullOrEmpty(bike.Company))
            {
                Logger.PrintOnConsole("Must Sepcify Company");
                return;
            }
            if (bike.Company == "Honda")
            {
                _ratingUpdater.UpdateRating(3.9m);

            }
            else if (bike.Company == "Unique")
            {
                _ratingUpdater.UpdateRating(3.5m);
            }
        }

    }
}
