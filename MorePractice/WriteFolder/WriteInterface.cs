using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorePractice.Constructors;

namespace MorePractice.WriteFolder
{
    // Interface: Defines the method signature for two write to text methods
    public interface IWriteGifts
    {
        void WriteGift(List<Gift> gifts);
    }
}
