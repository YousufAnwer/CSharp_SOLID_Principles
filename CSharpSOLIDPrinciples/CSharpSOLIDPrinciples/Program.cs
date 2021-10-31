using System;

namespace CSharpSOLIDPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rating System..");
            var engine = new BikeRatingClient();
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
