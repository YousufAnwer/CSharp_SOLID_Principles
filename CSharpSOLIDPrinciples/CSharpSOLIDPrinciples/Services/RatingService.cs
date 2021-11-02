using CSharpSOLIDPrinciples.Factory;
using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.Helpers.IHelper;
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
        private readonly IFileReader _fileReader;
        private readonly IBikeSerializer _bikeSerializer;
        public BikeRatingClient Engine { get; set; }

        public RatingService(IFileReader fileReader, IBikeSerializer bikeSerializer)
        {
            _fileReader = fileReader;
            _bikeSerializer = bikeSerializer;
        }
        public Rating CreateRaterForBike(Bike policy, IPrinterService printerService, IClassNameFromEnum classNameFromEnum)
        {
            return new BikeFactory().Create(policy, printerService, classNameFromEnum);
        }

        public Bike GetBikeFromJsonString(string bikeJson, IClassNameFromEnum classNameFromEnum)
        {
            return _bikeSerializer.GetBikeObject(bikeJson, classNameFromEnum);
        }

        public string LoadBikeFromFile(string filePath)
        {
            return _fileReader.Read(filePath);
        }

        public void Print(string message)
        {
            new ConsolePrinterService().Print(message);
        }

        public void UpdateRating(decimal rating)
        {
            Engine.Rating = rating;
        }
    }
}
