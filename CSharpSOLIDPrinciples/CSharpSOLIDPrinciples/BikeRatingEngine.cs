using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace CSharpSOLIDPrinciples
{
    public class BikeRatingEngine
    {
        public BikeRatingEngine()
        {
        }

        public decimal Rating { get; set; }


        public void Rate()
        {
            Console.WriteLine("Starting rate");
            Console.WriteLine("Loadig Policy");

            string policyJson = File.ReadAllText(@"E:\Github repos\CSharp_SOLID_Principles\CSharpSOLIDPrinciples\CSharpSOLIDPrinciples\BikeData.json");
            var bike = JsonConvert.DeserializeObject<Bike>(policyJson, new StringEnumConverter());

            switch (bike.Cc)
            {
                case BikeType._70cc:
                    Console.WriteLine("Rating 70 CC bike");
                    Console.WriteLine("Validating Bike");
                    if (string.IsNullOrEmpty(bike.Company))
                    {
                        Console.WriteLine("Must Sepcify Company");
                        return;
                    }
                    if (bike.Company == "Honda")
                    {
                        Rating = 3.9m;

                    }
                    else if (bike.Company == "Unique")
                    {
                        Rating = 3.5m;
                    }
                    break;

                case BikeType._125cc:
                    Console.WriteLine("Rating 125 CC bike");
                    Console.WriteLine("Validating Bike");
                    if (string.IsNullOrEmpty(bike.Company))
                    {
                        Console.WriteLine("Must Sepcify Company");
                        return;
                    }
                    if (bike.Company == "Honda")
                    {
                        Rating = 4.9m;

                    }
                    else if (bike.Company == "Unique")
                    {
                        Rating = 4.5m;
                    }
                    break;
                case BikeType._150cc:
                    Console.WriteLine("Rating 150 CC bike");
                    Console.WriteLine("Validating Bike");
                    if (string.IsNullOrEmpty(bike.Company))
                    {
                        Console.WriteLine("Must Sepcify Company");
                        return;
                    }
                    if (bike.Company == "Honda")
                    {
                        Rating = 4.2m;

                    }
                    else if (bike.Company == "Suzuki")
                    {
                        Rating = 5.0m;
                    }
                    break;

                default:
                    Console.WriteLine("Unknown bike type");
                    break;

            }

            Console.WriteLine("Rating completed.");

        }
    }
}
