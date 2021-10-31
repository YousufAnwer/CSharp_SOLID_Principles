using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Ratings.Abstract
{
    public abstract class Rating
    {
        protected readonly IRatingUpdaterService _ratingUpdater;
        protected  IPrinterService Logger { get; set; } = new PrinterService();
        public Rating(IRatingUpdaterService ratingUpdater)
        {
            _ratingUpdater = ratingUpdater;
        }
        public abstract void Rate(Bike bike);
    }
}
