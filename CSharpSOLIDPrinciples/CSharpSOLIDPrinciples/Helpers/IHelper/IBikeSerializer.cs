using CSharpSOLIDPrinciples.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Helpers.IHelper
{
    public interface IBikeSerializer
    {
        Bike GetBikeObject(string jsonBikeobj, IClassNameFromEnum classNameFromEnum);
    }
}
