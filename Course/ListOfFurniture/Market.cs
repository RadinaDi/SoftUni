using System.Collections.Generic;
using System.Linq;

namespace ListOfFurniture
{
    class Market
    {
        private List<Furniture> furniture = null;

        private List<Order> orders = null;

        public Market()
        {
            this.furniture = new List<Furniture>();
            this.orders = new List<Order>();
        }

        public void AddFurniture(string name, float price)
        {
            Furniture furn = new Furniture
            {
                Name = name,
                Price = price
            };
            this.furniture.Add(furn);
        }

        public void AddOrder(string name, int count)
        {
            Order order = new Order
            {
                FurnitureName = name,
                Count = count
            };
            this.orders.Add(order);
        }

        public float GetTotalPrice()
        {
            float total = 0;
            foreach (Order order in orders)
            {
                Furniture furn = this.furniture.FirstOrDefault(x => x.Name == order.FurnitureName);
                if (furn != null)
                {
                    total += order.Count * furn.Price;
                }
            }

            return total;
        }
    }
}
