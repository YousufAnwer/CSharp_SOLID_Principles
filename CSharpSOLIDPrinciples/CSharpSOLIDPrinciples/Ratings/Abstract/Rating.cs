using CSharpSOLIDPrinciples.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSOLIDPrinciples.Ratings.Abstract
{
    public abstract class Rating
    {
        protected readonly IRating _context;
        protected readonly Printer _logger;
        public Rating(IRating context)
        {
            _context = context;
            _logger = _context.Logger;
        }
        public abstract void Rate(Bike bike);
    }
}
