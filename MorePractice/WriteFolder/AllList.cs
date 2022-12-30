using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorePractice.Constructors;
using static Program.Program;

namespace MorePractice.WriteFolder
{
    // Class that implements the IWriteGifts interface, and writes all gifts desired to
    // a text file.

    // The delegate is less efficient because it calls a method with O(n) complexity
    // but is used to implement a delegate as a method parameter
    public class WriteAllGifts : IWriteGifts
    {

        public void WriteGift(List<Gift> gifts, MyDelegate SumGifts)
        {
            
            string fullpath = @"C:\Users\brand\source\repos\MorePractice\MorePractice\Output\GiftList.txt";
            string giftList = "";

            foreach (Gift gift in gifts)
            {
                giftList += gift.item.Item1 + ": $" + gift.item.Item2 + "\n";
            }

            File.WriteAllText(fullpath, "Gift List: \n" + giftList + "Total Cost: $" + SumGifts(gifts));
        }
    }
}
