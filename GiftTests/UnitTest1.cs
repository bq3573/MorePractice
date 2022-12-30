using MorePractice.Constructors;
using MorePractice.Constructors.Operations;
using MorePractice.WriteFolder;
using NuGet.Frameworks;
using System.IO;
using Program;
using static Program.Program;

namespace GiftTests
{
    public class BasicTets
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestGiftConstructor()
        {
            Gift gift1 = new Gift(("puppy", 1000));
            Assert.Equal("puppy", gift1.item.Item1);
            Assert.Equal(1000, gift1.item.Item2);
        }

        [Fact]
        public void TestExpensive() 
        {
            List<Gift> gifts= new List<Gift>();
            Gift gift1 = new Gift(("puppy", 1000));
            Gift gift2 = new Gift(("bot", 100));
            Gift gift3 = new Gift(("sled", 30));
            Gift gift4 = new Gift(("train", 12));

            gifts.Add(gift1);
            gifts.Add(gift2);
            gifts.Add(gift3);
            gifts.Add(gift4);
            Assert.Equal(1000, Operations.MostExpensive(gifts).item.Item2);
        }

        [Fact]
        public void TestSum()
        {
            List<Gift> gifts= new List<Gift>();
            Gift gift1 = new Gift(("puppy", 1000));
            Gift gift2 = new Gift(("bot", 100));
            Gift gift3 = new Gift(("sled", 30));
            Gift gift4 = new Gift(("train", 12));

            gifts.Add(gift1);
            gifts.Add(gift2);
            gifts.Add(gift3);
            gifts.Add(gift4);


            Assert.Equal(1142, Operations.SumGifts(gifts));
        }

        [Fact]
        public void TestAllGiftsWrite()
        {
            MyDelegate SumGifts = new MyDelegate(Operations.SumGifts);
            List<Gift> gifts = new List<Gift>();
            Gift gift1 = new Gift(("puppy", 1000));
            Gift gift2 = new Gift(("bot", 100));
            Gift gift3 = new Gift(("sled", 30));
            Gift gift4 = new Gift(("train", 12));

            gifts.Add(gift1);
            gifts.Add(gift2);
            gifts.Add(gift3);
            gifts.Add(gift4);

            WriteAllGifts writer  = new WriteAllGifts();
            writer.WriteGift(gifts, SumGifts);

            string check = File.ReadAllText(@"C:\Users\brand\source\repos\MorePractice\MorePractice\Output\GiftList.txt");
            //check.Replace("\n", "\\r\\");
            Assert.Equal("Gift List: \npuppy: $1000\nbot: $100\nsled: $30\ntrain: $12\nTotal Cost: $1142", check);
        }
    }
}