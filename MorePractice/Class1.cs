using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MorePractice
{
    public static class Expensive
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
    }
}
