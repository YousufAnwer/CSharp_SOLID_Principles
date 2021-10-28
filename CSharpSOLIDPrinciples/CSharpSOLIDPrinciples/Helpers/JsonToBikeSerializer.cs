using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Helpers
{
    public class JsonToBikeSerializer
    {
        public Bike GetBikeObject(string jsonBikeobj)
        {
            string cc = JObject.Parse(jsonBikeobj)["cc"].ToString();
            var obj = Type.GetType($"CSharpSOLIDPrinciples.Ratings.Rating{cc}");
            if (obj != null)
            {
                var bike = JsonConvert.DeserializeObject<Bike>(jsonBikeobj, new StringEnumConverter());
                return bike;
            }
            return new NullBike();
        }
    }
}
