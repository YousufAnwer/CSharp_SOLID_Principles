using CSharpSOLIDPrinciples.Ratings;
using CSharpSOLIDPrinciples.Ratings.Abstract;
using System;

namespace CSharpSOLIDPrinciples.Factory
{
    public class BikeFactory
    {
        public Rating Create(Bike bike, BikeRatingEngine bikeRatingEngine)
        {

            try
            {
                string cc = bike.cc.ToString().Substring(1, bike.cc.ToString().Length - 1);
                return (Rating)Activator.CreateInstance
                    (
                    Type.GetType($"CSharpSOLIDPrinciples.Ratings.Rating{cc}"),
                    new object[]
                    {
                        bikeRatingEngine, bikeRatingEngine.printer
                    }


                    );
            }
            catch
            {

                return new RatingNull(bikeRatingEngine, bikeRatingEngine.printer);
            }

        }
    }
}
