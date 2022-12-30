using MorePractice.Constructors;
using MorePractice.Constructors.Operations;
using MorePractice.WriteFolder;
using NuGet.Frameworks;
using System.IO;
using Program;
using static Program.Program;

namespace GiftTests
{
    // Basic Test Class...
    // Tests all basic methods and classes for correct calculations and outputs.
    // Practice with Unit Tests in C#
    public class BasicTets
    {
        [Fact]
        public void Test1()
        {
            // First test assert...
            Assert.True(true);
        }

        // Tetsing Gift consturctor method
        [Fact]
        public void TestGiftConstructor()
        {
            //Create new gift, Assert name and price Tuple.
            Gift gift1 = new Gift(("puppy", 1000));
            Assert.Equal("puppy", gift1.item.Item1);
            Assert.Equal(1000, gift1.item.Item2);
        }

        // Test MostExpensive method
        [Fact]
        public void TestExpensive() 
        {
            // Create list of gifts, assert the MostExpensive method retrieves the correct gift.
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

        // Test basic sum method
        [Fact]
        public void TestSum()
        {
            // Create and populate List of Gift objects. Assert the total is correct.
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


        // Make sure the text file output is correct.
        [Fact]
        public void TestAllGiftsWrite()
        {
            // Instantiate SumGifts Delegate for method param.
            MyDelegate SumGifts = new MyDelegate(Operations.SumGifts);
            // Create and populate List of Gift objects.
            List<Gift> gifts = new List<Gift>();
            Gift gift1 = new Gift(("puppy", 1000));
            Gift gift2 = new Gift(("bot", 100));
            Gift gift3 = new Gift(("sled", 30));
            Gift gift4 = new Gift(("train", 12));

            gifts.Add(gift1);
            gifts.Add(gift2);
            gifts.Add(gift3);
            gifts.Add(gift4);

            // Instantiate WriteAllGifts object... to implement WriteInterface to correct method.
            WriteAllGifts writer  = new WriteAllGifts();
            writer.WriteGift(gifts, SumGifts);

            string check = File.ReadAllText(@"C:\Users\brand\source\repos\MorePractice\MorePractice\Output\GiftList.txt");
            //check.Replace("\n", "\\r\\");
            Assert.Equal("Gift List: \npuppy: $1000\nbot: $100\nsled: $30\ntrain: $12\nTotal Cost: $1142", check);
        }
    }
}