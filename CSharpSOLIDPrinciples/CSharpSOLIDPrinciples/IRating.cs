using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.Ratings.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples
{
    public interface IRating
    {
        void Log(string message);
        string LoadBikeFromFile();
        string GetClassNameFromEnum(string enumString);
        Bike GetBikeFromJsonString(string policyJson, IRating context);
        Rating CreateRaterForBike(Bike policy, IRating context);
        void UpdateRating(decimal rating);
        BikeRatingEngine Engine { get; set; }
        Printer Logger { get; }
    }
}
