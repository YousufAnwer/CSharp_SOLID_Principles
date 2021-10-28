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
        public JsonFileReader Reader = new JsonFileReader();
        public JsonToBikeSerializer serializer = new JsonToBikeSerializer();
        public Printer printer = new Printer();
        public decimal Rating { get; set; }

        public void Rate()
        {
            //Now performing same task but delegating details to other classes
            printer.PrintOnConsole("Starting rate");
            printer.PrintOnConsole("Loadig Policy");

            string jsonBikeString = Reader.Read();
            var bike = serializer.GetBikeObject(jsonBikeString);

            var factory = new BikeFactory();
            var bikeRater = factory.Create(bike, this);
            bikeRater.Rate(bike);
            printer.PrintOnConsole("Rating completed.");

        }
    }
}
