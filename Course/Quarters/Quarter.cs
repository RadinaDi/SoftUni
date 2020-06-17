using System.Collections.Generic;

namespace Quarters
{
    class Quarter
    {
        private List<Shop> shops = null;
        public Quarter()
        {
            this.shops = new List<Shop>();
        }
        public string Name { get; set; }

        public int Residents { get; set; }

        public void AddShop(string name, int profit)
        {
            Shop shop = new Shop
            {
                Name = name,
                Profit = profit
            };
            shops.Add(shop);
        }

        public float GetAveragePersonSpendings()
        {
            float totalProfit = 0;
            foreach(Shop item in this.shops)
            {
                totalProfit += item.Profit;
            }
            return totalProfit / this.Residents;
        }
    }
    
}
