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
        // ClassNameFromEnum NameFromEnum = new ClassNameFromEnum();
        public Bike GetBikeObject(string jsonBikeobj, IRating context)
        {
            try
            {
                string cc = JObject.Parse(jsonBikeobj)["cc"].ToString();
                var obj = Type.GetType($"CSharpSOLIDPrinciples.Ratings.Rating{context.GetClassNameFromEnum(cc)}");
                var bike = JsonConvert.DeserializeObject<Bike>(jsonBikeobj, new StringEnumConverter());
                return bike;

            }
            catch
            {

                return new NullBike();
            }



        }
    }
}
