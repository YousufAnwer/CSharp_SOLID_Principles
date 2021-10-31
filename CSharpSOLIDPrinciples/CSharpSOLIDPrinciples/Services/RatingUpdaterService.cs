using CSharpSOLIDPrinciples.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples
{
    public class RatingUpdaterService : IRatingUpdaterService
    {
        private readonly BikeRatingClient _engine;

        public RatingUpdaterService(BikeRatingClient engine)
        {
            _engine = engine;
        }
        public void UpdateRating(decimal rating)
        {
            _engine.Rating = rating;
        }
    }
}
