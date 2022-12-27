using MorePractice;
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
            Gift most = Expensive.MostExpensive(gifts);

            // Use of delegate, SumGifts...
            MyDelegate del = new MyDelegate(SumGifts);
            Console.WriteLine("Total Cost: $" + del(gifts));

            // Print Most Expensive Items
            Console.WriteLine("This is the most expensive item:\n");
            Console.WriteLine(most.item.Item1 + ": " + most.item.Item2);


            // Implementation of a simple gift list to create a list of the items you want to buy and print them to
            // a text document titled: GiftsToGet.txt
            CreateShoppingList(gifts);

        }

        // Takes full gift list and gives the option to create a list of the items you wish to buy....
        public static void CreateShoppingList(List<Gift> gifts)
        {
            // Local Vars: ---------------------------------------------------------------
            string fullpath = @"C:\Users\brand\source\repos\MorePractice\GiftsToGet.txt";
            string giftsToBuy = "";
            double sum = 0;
            //----------------------------------------------------------------------------
            // Loop through gifts in gift list and switch on whether you want to buy or not.
            foreach (Gift gift in gifts)
            {
                Console.WriteLine(gift.item.Item1 + ": " + gift.item.Item2);
                Console.WriteLine("Press 1 if you want to buy, Press 2 if you don't");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    // Main Case: concat item and price to string, increase sum based on the price.
                    case 1:
                        giftsToBuy += gift.item.Item1 + ": " + gift.item.Item2 + "\n";
                        sum += gift.item.Item2;
                        break;
                    case 2:
                        break;
                    default:
                        break;

                }
            }
            // Write the string of gifts indicated to but to the file.
            File.WriteAllText(fullpath, giftsToBuy + "Total Cost: $" + sum);
        }

        // Sum total cost of gofts, meant for practicing delegates
        public static double SumGifts(List<Gift> gifts)
        {
            double sum = 0;
            foreach (Gift gift in gifts)
            {
                sum += gift.item.Item2;
            }

            return sum;
        }
    }
}