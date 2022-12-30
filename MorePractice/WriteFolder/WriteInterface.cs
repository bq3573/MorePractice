using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorePractice.Constructors;
using MorePractice.Constructors.Operations;
using Program;
using static Program.Program;

namespace MorePractice.WriteFolder
{
    // Interface: Defines the method signature for two write to text methods
    //public delegate double MyDelegate(List<Gift> gifts);

    // The delegate is less efficient because it calls a method with O(n) complexity
    // but is used to implement a delegate as a method parameter
    public interface IWriteGifts
    {
        void WriteGift(List<Gift> gifts, MyDelegate SumGifts);
    }
}
