using MorePractice.Constructors;
using MorePractice.Constructors.Operations;
using MorePractice.WriteFolder;
using System.Diagnostics.CodeAnalysis;

namespace Program
{
    // Program.cs file. Runs the Main method for the practice CLI app.
    // Overall goal of this project is to learn and implement C# fundamentals such as:
    // - Collections
    // - Delegates
    // - Tuples
    // - Switch Case
    

    // Create a Gift List of items you want (this is static and does not take input).
    // Pass this list a long to someone who would choose which gifts from that list
    // that they intend to buy.
    // Both lists are outputted to seperate test files.
    public class Program
    {
        // Delegate Example -- just to sum the list of gifts...
        public delegate double MyDelegate(List<Gift> gifts);
        public static void Main(string[] args)
        {
            // Creates mock Gift List
            List<Gift> gifts = createGiftList();

            //Use of MostExpensive
            Gift most = Operations.MostExpensive(gifts);

            // Create Delegate to use in both write methods.
            MyDelegate del = new MyDelegate(Operations.SumGifts);

            // Print Most Expensive Items
            Console.WriteLine("This is the most expensive item:");
            Console.WriteLine(most.item.Item1 + ": $" + most.item.Item2);


            // Two uses of the IWriteGifts interface
            // Writes all Gifts in giftList to a text file.
            WriteAllGifts writer1 = new WriteAllGifts();
            writer1.WriteGift(gifts, del);

            // Writes only the gifts you want to buy to a text file
            WriteBuyList writer2 = new WriteBuyList();
            writer2.WriteGift(gifts, del);

        }

        public static List<Gift> createGiftList()
        {
            // Example Creation of a gift list
            // 4 Gifts of varying prices
            // Use of collection type: List<Gift>
            List<Gift> gifts = new List<Gift>();

            Gift gift1 = new Gift(("puppy", 1000));
            Gift gift2 = new Gift(("bot", 100));
            Gift gift3 = new Gift(("sled", 30));
            Gift gift4 = new Gift(("train", 12));

            gifts.Add(gift1);
            gifts.Add(gift2);
            gifts.Add(gift3);
            gifts.Add(gift4);
            // End of Example Gift List

            return gifts;
        }


    }
}