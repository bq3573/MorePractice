using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorePractice.Constructors;

namespace MorePractice.WriteFolder
{
    // Class that implements the IWriteGifts interface, and writes all gifts desired to
    // a text file.
    public class WriteAllGifts : IWriteGifts
    {
        public void WriteGift(List<Gift> gifts)
        {
            string fullpath = @"C:\Users\brand\source\repos\MorePractice\GiftList.txt";
            string giftList = "";
            double sum = 0;
            foreach (Gift gift in gifts)
            {
                giftList += gift.item.Item1 + ": $" + gift.item.Item2 + "\n";
                sum += gift.item.Item2;

            }

            File.WriteAllText(fullpath, "Gift List: \n" + giftList + "Total Cost: $" + sum);
        }
    }
}
