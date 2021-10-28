using CSharpSOLIDPrinciples.Ratings;
using CSharpSOLIDPrinciples.Ratings.Abstract;

namespace CSharpSOLIDPrinciples.Factory
{
    public class BikeFactory
    {
        public Rating Create(Bike bike, BikeRatingEngine bikeRatingEngine)
        {
            switch (bike.cc)
            {
                case BikeType._70cc:
                    return new Rating70cc(bikeRatingEngine, bikeRatingEngine.printer);
                case BikeType._125cc:
                    return new Rating125cc(bikeRatingEngine, bikeRatingEngine.printer);
                case BikeType._150cc:
                    return new Rating150cc(bikeRatingEngine, bikeRatingEngine.printer);

                default:
                    // Implement Null Object Pattern
                    return new RatingNull(bikeRatingEngine, bikeRatingEngine.printer);


            }
        }
    }
}
