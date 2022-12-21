using MorePractice;

namespace Program
{
    public class Program
    {

        public delegate Gift Del((string, double) newGift);
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


            Console.WriteLine(most.item.Item1 + ": " + most.item.Item2);

        }

        //public Gift DelegateMehtod((string, double) newGift)
        //{
        //    return new Gift(newGift);
        //}
    }
}