using System;

namespace ListOfFurniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Market market = new Market();

            string input = string.Empty;

            do
            {
                input = Console.ReadLine();

                if (input.ToLower() != "end of items")
                {
                    string[] marketData = input.Split();
                    string name = marketData[0];
                    float price = float.Parse(marketData[1]);
                    market.AddFurniture(name, price);
                }

            } while (input.ToLower() != "end of items");

            do
            {
                input = Console.ReadLine();

                if (input.ToLower() != "end of orders")
                {
                    string[] orderData = input.Split();
                    string name = orderData[0];
                    int count = int.Parse(orderData[1]);
                    market.AddOrder(name, count);
                }

            } while (input.ToLower() != "end of orders");

            Console.WriteLine($"The total price of all items is: {market.GetTotalPrice():f2}");
        }

    }
}
