using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.IServices;
using CSharpSOLIDPrinciples.Ratings;
using CSharpSOLIDPrinciples.Ratings.Abstract;
using System;

namespace CSharpSOLIDPrinciples.Factory
{
    public class BikeFactory
    {
        // ClassNameFromEnum NameFromEnum = new ClassNameFromEnum();
        public Rating Create(Bike bike, IRatingUpdaterService ratingUpdater, IClassNameFromEnum classNameFromEnum)
        {

            try
            {
                return (Rating)Activator.CreateInstance
                    (
                    Type.GetType($"CSharpSOLIDPrinciples.Ratings.Rating{classNameFromEnum.GetClassName(bike.cc.ToString())}"),
                    new object[]
                    {
                       ratingUpdater
                    }


                    );
            }
            catch
            {
                //Here we applying liskov substitution principle that isntead of return null we return a Specific class which is reacting as a null object 
                //It is a concept of "Null Object Pattern"
                return new RatingNull(ratingUpdater);
            }

        }
    }
}
