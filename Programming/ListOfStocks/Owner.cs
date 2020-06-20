using System.Collections.Generic;
using System.Linq;

namespace ListOfStocks
{
    class Owner
    {
        private List<OwnerStocks> ownerStocks = null;

        public Owner(string ownerName)
        {
            this.OwnerName = ownerName;
            this.ownerStocks = new List<OwnerStocks>();
        }

        public string OwnerName { get; set; }
        
        public List<OwnerStocks> OwnerStocks 
        {
            get
            {
                return this.ownerStocks;
            }
        }

        public void AddOrUpdateOwnerStock(string companyName, int stockCount)
        {
            OwnerStocks os = this.ownerStocks.FirstOrDefault(X => X.CompanyName == companyName);
            if(os == null)
            {
                os = new OwnerStocks
                {
                    CompanyName = companyName,
                    StockCount = stockCount
                };
                this.ownerStocks.Add(os);
                
            }
            else
            {
                os.StockCount = stockCount;
            }
        }
        
    }
}
