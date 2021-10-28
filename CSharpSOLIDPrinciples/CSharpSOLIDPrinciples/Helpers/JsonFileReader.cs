using CSharpSOLIDPrinciples.Contants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Helpers
{
    public class JsonFileReader
    {
        public string Read()
        {
            string json = File.ReadAllText(BikeConst.FilePath);
            return json;
        }
    }
}
