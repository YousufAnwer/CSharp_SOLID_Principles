using CSharpSOLIDPrinciples.Factory;
using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.Ratings.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples
{
    public class DefaultRating : IRating
    {
        public BikeRatingEngine Engine { get; set; }

        public Printer Logger => new Printer();

        public Rating CreateRaterForBike(Bike policy, IRating context)
        {
            return new BikeFactory().Create(policy, context);
        }

        public string GetClassNameFromEnum(string enumString)
        {
            return new ClassNameFromEnum().GetClassName(enumString);
        }

        public Bike GetBikeFromJsonString(string bikeJson, IRating context)
        {
            return new JsonToBikeSerializer().GetBikeObject(bikeJson, context);
        }

      

        public string LoadBikeFromFile()
        {
            return new JsonFileReader().Read();
        }

     

        public void Log(string message)
        {
            new Printer().PrintOnConsole(message);
        }

        public void UpdateRating(decimal rating)
        {
            Engine.Rating = rating;
        }
    }
}
