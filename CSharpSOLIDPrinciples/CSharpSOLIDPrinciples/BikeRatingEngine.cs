using CSharpSOLIDPrinciples.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace CSharpSOLIDPrinciples
{
    public class BikeRatingEngine
    {
        private JsonFileReader Reader = new JsonFileReader();
        private JsonToBikeSerializer serializer = new JsonToBikeSerializer();
        private Printer printer = new Printer();
        public decimal Rating { get; set; }

        public void Rate()
        {
            //Now performing same task but delegating details to other classes
            printer.PrintOnConsole("Starting rate");
            printer.PrintOnConsole("Loadig Policy");

            string jsonBikeString = Reader.Read();
            var bike = serializer.GetBikeObject(jsonBikeString);

            switch (bike.Cc)
            {
                case BikeType._70cc:
                    printer.PrintOnConsole("Rating 70 CC bike");
                    printer.PrintOnConsole("Validating Bike");
                    if (string.IsNullOrEmpty(bike.Company))
                    {
                        printer.PrintOnConsole("Must Sepcify Company");
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
                    printer.PrintOnConsole("Rating 125 CC bike");
                    printer.PrintOnConsole("Validating Bike");
                    if (string.IsNullOrEmpty(bike.Company))
                    {
                        printer.PrintOnConsole("Must Sepcify Company");
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
                    printer.PrintOnConsole("Rating 150 CC bike");
                    printer.PrintOnConsole("Validating Bike");
                    if (string.IsNullOrEmpty(bike.Company))
                    {
                        printer.PrintOnConsole("Must Sepcify Company");
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
                    printer.PrintOnConsole("Unknown bike type");
                    break;

            }

            printer.PrintOnConsole("Rating completed.");

        }
    }
}
