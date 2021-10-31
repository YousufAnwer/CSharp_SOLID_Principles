using CSharpSOLIDPrinciples.Factory;
using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.IServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace CSharpSOLIDPrinciples
{
    public class BikeRatingClient
    {
        public IRatingService Context { get; set; } = new RatingService();
        public IRatingUpdaterService ratingUpdater { get; set; }
        public IClassNameFromEnum classNameFromEnum { get; set; }
        public decimal Rating { get; set; }

        public BikeRatingClient()
        {
            Context.Engine = this;
            ratingUpdater = new RatingUpdaterService(this);
            classNameFromEnum = new ClassNameFromEnum();
        }
        public void Rate()
        {
            //Now performing same task but delegating details to other classes
            Context.PrintOnConsole("Starting rate");
            Context.PrintOnConsole("Loadig Policy");

            string jsonBikeString = Context.LoadBikeFromFile();
            var bike = Context.GetBikeFromJsonString(jsonBikeString, classNameFromEnum);

            //var factory = new BikeFactory();
            var bikeRater = Context.CreateRaterForBike(bike, ratingUpdater, classNameFromEnum);

            //Just because of using Liskov substitution principle we don't have to check for bikeRater object is null or not 
            bikeRater.Rate(bike);
            Context.PrintOnConsole("Rating completed.");

        }
    }
}
