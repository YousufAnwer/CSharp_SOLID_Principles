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
    public interface IRatingService : IPrinterService
    {
        string LoadBikeFromFile();
        Bike GetBikeFromJsonString(string bikeJson, IClassNameFromEnum classNameFromEnum);
        Rating CreateRaterForBike(Bike policy, IRatingUpdaterService ratingUpdater, IClassNameFromEnum classNameFromEnum);
        BikeRatingClient Engine { get; set; }
    }
}
