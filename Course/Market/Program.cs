using System;


namespace Market
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
                if (input.ToLower() != "end")
                {
                    string[] productdata = input.Split();
                    Product products = new Product
                    {
                        Name = productdata[0],
                        Price = float.Parse(productdata[1])
                    };
                    market.Add(products);

                }

            } while (input.ToLower() != "end");

            do
            {
                input = Console.ReadLine();
                if (input.ToLower() != "end")
                {
                    string[] productdata = input.Split();

                    string Name = productdata[0];
                    int Quantity = int.Parse(productdata[1]);

                    market.AddQuantity(Name, Quantity);
                }

            } while (input.ToLower() != "end");

            //float price = market.GetTotalPrice();
            //Console.WriteLine($"The total price of all products in the market is: {price:f2}");

            market.Total();
        }

    }
}



 

