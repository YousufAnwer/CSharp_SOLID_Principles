using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Helpers
{
    public class ClassNameFromEnum
    {
        public string GetClassName(string bikeType)
        {
            string cc = bikeType.Substring(1, bikeType.Length - 1);
            return cc;
        }
    }

}
