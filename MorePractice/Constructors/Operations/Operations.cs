using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace MorePractice.Constructors.Operations
{
    public static class Operations
    {
        public static Gift MostExpensive(List<Gift> gifts)
        {

            double max = 0;
            (string, double) MostExpensiveGift = ("placeholder", 0.0);
            foreach (Gift x in gifts)
            {
                if (x.item.Item2 >= max)
                {
                    max = x.item.Item2;
                    MostExpensiveGift = x.item;

                }
            }

            Gift expensive = new Gift(MostExpensiveGift);
            return expensive;
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
