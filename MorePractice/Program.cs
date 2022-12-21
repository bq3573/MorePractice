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
  
            Gift most = Expensive.MostExpensive(gifts);

            MyDelegate del = new MyDelegate(SumGifts);

            Console.WriteLine("Total Cost: $" + del(gifts));


            Console.WriteLine(most.item.Item1 + ": " + most.item.Item2);

        }



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