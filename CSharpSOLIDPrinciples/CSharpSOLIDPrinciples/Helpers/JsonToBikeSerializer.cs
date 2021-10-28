using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Helpers
{
    public  class JsonToBikeSerializer
    {
        public  Bike GetBikeObject(string jsonBikeobj)
        {
            var bike = JsonConvert.DeserializeObject<Bike>(jsonBikeobj, new StringEnumConverter());
            return bike;
        }
    }
}
