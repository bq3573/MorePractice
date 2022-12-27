using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePractice.Constructors
{
    // Sample Gift class to mess with creating a class to use for LINQ.
    public class Gift
    {
        public (string, double) item;
        public Gift((string, double) gift)
        {
            item = gift;
        }

    }
}
