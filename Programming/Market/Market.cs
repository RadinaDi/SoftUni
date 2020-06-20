using System;
using System.Collections.Generic;
using System.Linq;

namespace Market
{
    class Market
    {
        private List<Product> list = null;

        public Market()
        {
            this.list = new List<Product>();
        }

        public void Add(Product product)
        {
            list.Add(product);
        }

        public void AddQuantity(string name, int quantity)
        {
            Product product = this.list.FirstOrDefault(x => x.Name == name);
            if (product != null)
            {
                product.Quantity += quantity;
            }
        }

        public void Total()
        {
            foreach (var item in this.list.OrderBy(x => x.Name))
            {
                Console.WriteLine($"Product '{item.Name}' has '{item.Quantity}' items with total price of ${item.Quantity * item.Price : F2}");
            }
        }

        //public float GetTotalPrice()
        //{
        //    float price = 0;
        //    foreach(Product item in list)
        //    {
        //        price += item.Price;
        //    }

        //    return price;
        //}
    }
}
