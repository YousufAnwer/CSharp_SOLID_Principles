using CSharpSOLIDPrinciples.Contants;
using CSharpSOLIDPrinciples.Helpers.IHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Helpers
{
    public class JsonFileReader : IFileReader
    {
        public string Read(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return json;
        }
    }
}
