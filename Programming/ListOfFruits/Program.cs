using System;

namespace ListOfFruits
{
    class Program
    {
        static void Main(string[] args)
        {
            Basket basket = new Basket();
            string input = string.Empty;

            do
            {
                input = Console.ReadLine();
                if(input.ToLower() != "end")
                {
                    string[] fruitData = input.Split();
                    Fruit fruit = new Fruit
                    {
                        Name = fruitData[0],
                        Price = float.Parse(fruitData[1])
                    };

                    basket.Add(fruit);
                }


            } while (input.ToLower() != "end");

            float price = basket.GetTotalPrice();
            Console.WriteLine($"The items in your basket cost: {price:f2}");
        }
    }
}
