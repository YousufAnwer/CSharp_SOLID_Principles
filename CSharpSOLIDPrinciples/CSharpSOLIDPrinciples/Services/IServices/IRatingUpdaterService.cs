using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.IServices
{
    public interface IRatingUpdaterService
    {
        void UpdateRating(decimal rating);
    }
}
