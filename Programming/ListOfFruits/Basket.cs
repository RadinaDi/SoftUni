using System.Collections.Generic;

namespace ListOfFruits
{
    class Basket
    {
        private List<Fruit> list = null;

        public Basket()
        {
            this.list = new List<Fruit>();
        }

        public void Add(Fruit fruit)
        {
            this.list.Add(fruit);
        }

        public float GetTotalPrice()
        {
            float price = 0;
            foreach(Fruit item in this.list)
            {
                price += item.Price;
            }
            return price;
        }
    }
}
