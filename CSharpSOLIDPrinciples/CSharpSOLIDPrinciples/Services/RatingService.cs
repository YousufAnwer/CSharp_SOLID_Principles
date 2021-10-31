using CSharpSOLIDPrinciples.Factory;
using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.IServices;
using CSharpSOLIDPrinciples.Ratings.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples
{
    public class RatingService : IRatingService
    {
        public BikeRatingClient Engine { get; set; }


        public Rating CreateRaterForBike(Bike policy, IRatingUpdaterService ratingUpdater, IClassNameFromEnum classNameFromEnum)
        {
            return new BikeFactory().Create(policy, ratingUpdater, classNameFromEnum);
        }

        public Bike GetBikeFromJsonString(string bikeJson, IClassNameFromEnum classNameFromEnum)
        {
            return new JsonToBikeSerializer().GetBikeObject(bikeJson, classNameFromEnum);
        }

        public string LoadBikeFromFile()
        {
            return new JsonFileReader().Read();
        }

        public void PrintOnConsole(string message)
        {
            new PrinterService().PrintOnConsole(message);
        }

        public void UpdateRating(decimal rating)
        {
            Engine.Rating = rating;
        }
    }
}
