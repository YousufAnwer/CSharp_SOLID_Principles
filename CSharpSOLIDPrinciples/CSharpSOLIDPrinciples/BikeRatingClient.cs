using CSharpSOLIDPrinciples.Contants;
using CSharpSOLIDPrinciples.Factory;
using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.Helpers.IHelper;
using CSharpSOLIDPrinciples.IServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace CSharpSOLIDPrinciples
{
    public class BikeRatingClient
    {
        private IClassNameFromEnum _classNameFromEnum { get; set; }
        private readonly IPrinterService _printerService;
        private readonly IFileReader _fileReader;
        private readonly IBikeSerializer _bikeSerializer;
        private readonly BikeFactory _bikeFactory;
        public decimal Rating { get; set; }

        public BikeRatingClient(IPrinterService printerService, IFileReader fileReader, IBikeSerializer bikeSerializer, IClassNameFromEnum classNameFromEnum, BikeFactory bikeFactory)
        {
            _printerService = printerService;
            _fileReader = fileReader;
            _bikeSerializer = bikeSerializer;
            _classNameFromEnum = classNameFromEnum;
            _bikeFactory = bikeFactory;
        }
        public void Rate()
        {
            //Now performing same task but delegating details to other classes
            _printerService.Print("Starting rate");
            _printerService.Print("Loadig Policy");

            string jsonBikeString = _fileReader.Read(BikeConstants.FilePath);
            var bike = _bikeSerializer.GetBikeObject(jsonBikeString, _classNameFromEnum);
            var bikeRater = _bikeFactory.Create(bike, _printerService, _classNameFromEnum);

            //Just because of using Liskov substitution principle we don't have to check for bikeRater object is null or not 
            this.Rating = bikeRater.Rate(bike);
            _printerService.Print("Rating completed.");


        }
    }
}
