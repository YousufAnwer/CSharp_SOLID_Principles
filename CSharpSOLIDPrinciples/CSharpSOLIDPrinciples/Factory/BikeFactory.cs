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
                //Here we applying liskov substitution principle that isntead of return null we return a Specific class which is reacting as a null object 
                //It is a concept of "Null Object Pattern"
                return new RatingNull(bikeRatingEngine, bikeRatingEngine.printer);
            }

        }
    }
}
