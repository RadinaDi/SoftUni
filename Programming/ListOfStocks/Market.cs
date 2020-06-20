using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfStocks
{
    class Market
    {
        private List<Stock> stocks = null;

        private List<Owner> owners = null;

        public Market()
        {
            this.stocks = new List<Stock>();
            this.owners = new List<Owner>();
        }

        public void AddOrUpdateStock(string companyName, float price)
        {
            Stock stock = this.stocks.FirstOrDefault( x => x.CompanyName == companyName);

            if(stock == null)
            {
                stock = new Stock
                {
                    CompanyName = companyName,
                    Price = price
                };

                this.stocks.Add(stock);
            }
            else
            {
                stock.Price = price;
            }
        }

        public void AddOrUpdateOwner(string ownerName, string companyName, int stockCount)
        {
            Owner owner = this.owners.FirstOrDefault(x => x.OwnerName == ownerName);
            if (owner == null)
            {
                owner = new Owner(ownerName);
                owner.AddOrUpdateOwnerStock(companyName, stockCount);

                this.owners.Add(owner);
            }
            else
            {
                owner.AddOrUpdateOwnerStock(companyName, stockCount);
            }
        }

        public void GetStocksByOwner(string ownerName)
        {
            Owner owner = this.owners.FirstOrDefault(x => x.OwnerName == ownerName);
            if(owner != null)
            {
                Console.WriteLine($"Stocks of {owner.OwnerName}:");
                foreach(OwnerStocks item in owner.OwnerStocks)
                {
                    Stock stock = this.stocks.FirstOrDefault(x => x.CompanyName == item.CompanyName);
                    if(stock != null)
                    {
                        Console.WriteLine($"{item.CompanyName} stocks price is ${item.StockCount * stock.Price}");
                    }
                }
            }
        }

        public void RemoveOwnerStocks(string ownerName, string companyName)
        {
            Owner owner = owners.FirstOrDefault(x => x.OwnerName == ownerName);
            if(owner != null)
            {
                owner.OwnerStocks.RemoveAll(x => x.CompanyName == companyName);
            }
        }
    }
}
