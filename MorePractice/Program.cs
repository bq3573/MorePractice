using MorePractice;
using System.Diagnostics.CodeAnalysis;

namespace Program
{
    public class Program
    {

        public delegate double MyDelegate(List<Gift> gifts);
        public static void Main(string[] args)
        {
            //Del creator = DelegateMehtod(());


            //(string, double) t1 = ("puppy", 100);
            //Gift gift1 = creator(t1);

            List<Gift> gifts= new List<Gift>();

            Gift gift1 = new Gift(("puppy", 1000));
            Gift gift2 = new Gift(("bot", 100));
            Gift gift3 = new Gift(("sled", 30));
            Gift gift4 = new Gift(("train", 12));

            gifts.Add(gift1);
            gifts.Add(gift2);   
            gifts.Add(gift3);
            gifts.Add(gift4);
            //Use of MostExpensive
            Gift most = Expensive.MostExpensive(gifts);

            MyDelegate del = new MyDelegate(SumGifts);

            Console.WriteLine("Total Cost: $" + del(gifts));

            Console.WriteLine("This is the most expensive item:\n");
            Console.WriteLine(most.item.Item1 + ": " + most.item.Item2);


            // Implementation of a simple gift list to create a list of the items you want to buy and print them to
            // a text document titled: GiftsToGet.txt
            CreateShoppingList(gifts);

        }


        public static void CreateShoppingList(List<Gift> gifts)
        {
            string fullpath = @"C:\Users\brand\source\repos\MorePractice\GiftsToGet.txt";
            string giftsToBuy = "";
            double sum = 0;
            foreach (Gift gift in gifts)
            {
                Console.WriteLine(gift.item.Item1 + ": " + gift.item.Item2);
                Console.WriteLine("Press 1 if you want to buy, Press 2 if you don't");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
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
            File.WriteAllText(fullpath, giftsToBuy + "Total Cost: $" + sum);
            // return giftsToBuy;
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