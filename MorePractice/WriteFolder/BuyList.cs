using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorePractice.Constructors;

namespace MorePractice.WriteFolder
{
    // Class implementing IWriteGifts interface,
    // to decide which gifts you will buy and wite them to a text file
    public class WriteBuyList : IWriteGifts
    {
        public void WriteGift(List<Gift> gifts)
        {
            // Local Vars: ---------------------------------------------------------------
            string fullpath = @"C:\Users\brand\source\repos\MorePractice\GiftsToGet.txt";
            string giftsToBuy = "";
            double sum = 0;
            int count = 1;
            //----------------------------------------------------------------------------
            // Loop through gifts in gift list and switch on whether you want to buy or not.
            foreach (Gift gift in gifts)
            {
                
                Console.Write("------------------------------------------------\n");
                Console.WriteLine("Gift #" + count + ":");
                Console.WriteLine(gift.item.Item1 + ": $" + gift.item.Item2 + "\n");
                Console.WriteLine("Press 1 if you want to buy, Press 2 if you don't");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    // Main Case: concat item and price to string, increase sum based on the price.
                    case 1:
                        giftsToBuy += gift.item.Item1 + ": $" + gift.item.Item2 + "\n";
                        sum += gift.item.Item2;

                        Console.WriteLine(gift.item.Item1 + " has been added to your list...");
                        break;
                    case 2:
                        Console.WriteLine(gift.item.Item1 + " will not be added to your list...");
                        break;
                    default:
                        break;

                }
                count += 1;
            }
            // Write the string of gifts indicated to but to the file.
            File.WriteAllText(fullpath, "Gifts to Buy:\n" + giftsToBuy + "Total Cost: $" + sum);
        }
    }
}
