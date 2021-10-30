using CSharpSOLIDPrinciples.Factory;
using CSharpSOLIDPrinciples.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace CSharpSOLIDPrinciples
{
    public class BikeRatingEngine
    {
        //public JsonFileReader Reader = new JsonFileReader();
        //public JsonToBikeSerializer serializer = new JsonToBikeSerializer();
        //public Printer printer = new Printer();
        public IRating Context { get; set; } = new DefaultRating();
        public decimal Rating { get; set; }

        public BikeRatingEngine()
        {
            Context.Engine = this;
        }
        public void Rate()
        {
            //Now performing same task but delegating details to other classes
            Context.Log("Starting rate");
            Context.Log("Loadig Policy");

            string jsonBikeString = Context.LoadBikeFromFile();
            var bike = Context.GetBikeFromJsonString(jsonBikeString,Context);

            //var factory = new BikeFactory();
            var bikeRater = Context.CreateRaterForBike(bike, Context);

            //Just because of using Liskov substitution principle we don't have to check for bikeRater object is null or not 
            bikeRater.Rate(bike);
            Context.Log("Rating completed.");

        }
    }
}
