using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Testing_PracticeProblem
{
    public class PurchaseList
    {
        public int UniquePrice { get; private set; }
        public int DuplicatePrice { get; private set; }

        public void ProcessPurchases(string input)
        {
            string[] prices = input.Split(' ');
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            foreach (string priceString in prices) 
            {
                int price = int.Parse(priceString);
                if(countMap.ContainsKey(price))
                {
                    countMap[price]++;
                }
                else 
                {
                    countMap[price] = 1;
                }
            }

            UniquePrice = GetUniquePrice(countMap, prices);
            DuplicatePrice = GetDuplicatePrice(countMap);

        }
        private int GetUniquePrice(Dictionary<int, int> countMap, string[] prices)
        {
            foreach(string priceString in prices)
            {
                int price = int.Parse(priceString);
                if (countMap[price]==1)
                {
                    return price;
                }
            }
            return -1;
        }

        private int GetDuplicatePrice(Dictionary<int, int> countMap)
        {
            foreach(var pair in countMap) 
            {
                if(pair.Value > 1)
                {
                    return pair.Key;
                }
            }
            return -1;
        }
    }
}
