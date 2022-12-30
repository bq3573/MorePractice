using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MorePractice.Constructors;
using static Program.Program;

namespace MorePractice.WriteFolder
{
    // Class implementing IWriteGifts interface,
    // to decide which gifts you will buy and wite them to a text file

    // The delegate is less efficient because it calls a method with O(n) complexity
    // but is used to implement a delegate as a method parameter
    public class WriteBuyList : IWriteGifts
    {
        public void WriteGift(List<Gift> gifts, MyDelegate SumGifts)
        {
            // Local Vars: ---------------------------------------------------------------
            string fullpath = @"C:\Users\brand\source\repos\MorePractice\MorePractice\Output\GiftsToGet.txt";
            string giftsToBuy = "";
            int count = 1;
            List<Gift> giftsList = new List<Gift>();
            //----------------------------------------------------------------------------
            // Loop through gifts in gift list and switch on whether you want to buy or not.
            foreach (Gift gift in gifts)
            {
                // Prints formatting and returns switch case choice... (Mostly to keep method smaller).
                int choice = PrintFormatting(gift, count);

                switch (choice)
                {
                    // Main Case: concat item and price to string, increase sum based on the price.
                    case 1:
                        giftsToBuy += gift.item.Item1 + ": $" + gift.item.Item2 + "\n";
                        giftsList.Add(gift);

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
            File.WriteAllText(fullpath, "Gifts to Buy:\n" + giftsToBuy + "Total Cost: $" + SumGifts(giftsList));
        }

        // Prints the formatting output to the CLI and returns the choice for the Switch Case
        public static int PrintFormatting(Gift gift, int count)
        {
            Console.Write("------------------------------------------------\n");
            Console.WriteLine("Gift #" + count + ":");
            Console.WriteLine(gift.item.Item1 + ": $" + gift.item.Item2 + "\n");
            Console.WriteLine("Press 1 if you want to buy, Press 2 if you don't");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        
    }


}
