using MorePractice.Constructors;
using MorePractice.Constructors.Operations;
using MorePractice.WriteFolder;
using System.Diagnostics.CodeAnalysis;

namespace Program
{
    public class Program
    {
        // Delegate Example -- just to sum the list of gifts...
        public delegate double MyDelegate(List<Gift> gifts);
        public static void Main(string[] args)
        {
            // Example Creation of a gift list
            // 4 Gifts of varying prices
            // Use of collection type: List<Gift>
            List<Gift> gifts= new List<Gift>();

            Gift gift1 = new Gift(("puppy", 1000));
            Gift gift2 = new Gift(("bot", 100));
            Gift gift3 = new Gift(("sled", 30));
            Gift gift4 = new Gift(("train", 12));

            gifts.Add(gift1);
            gifts.Add(gift2);   
            gifts.Add(gift3);
            gifts.Add(gift4);
            // End of Example Gift List


            //Use of MostExpensive
            Gift most = Operations.MostExpensive(gifts);

            // Use of delegate, SumGifts...
            MyDelegate del = new MyDelegate(Operations.SumGifts);
            Console.WriteLine("Total Cost: $" + del(gifts));

            // Print Most Expensive Items
            Console.WriteLine("This is the most expensive item:");
            Console.WriteLine(most.item.Item1 + ": $" + most.item.Item2);


            // Two uses of the IWriteGifts interface
            // Writes all Gifts in giftList to a text file.
            WriteAllGifts writer1 = new WriteAllGifts();
            writer1.WriteGift(gifts);

            // Writes only the gifts you want to buy to a text file
            WriteBuyList writer2 = new WriteBuyList();
            writer2.WriteGift(gifts);

        }


    }
}