using CSharpSOLIDPrinciples.Factory;
using CSharpSOLIDPrinciples.Helpers;
using CSharpSOLIDPrinciples.Services;
using System;

namespace CSharpSOLIDPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rating System..");
            var engine = new BikeRatingClient(new FilePrinterService(), new JsonFileReader(), new JsonToBikeSerializer(), new ClassNameFromEnum(), new BikeFactory());
            engine.Rate();
            if (engine.Rating > 0)
            {
                Console.WriteLine($"Rating:{engine.Rating}");

            }
            else
            {
                Console.WriteLine($"No Rating");

            }
        }
    }
}
