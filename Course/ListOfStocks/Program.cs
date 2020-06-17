using System;

namespace ListOfStocks
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
                if(input.ToLower() != "end")
                {
                    string[] commandData = input.Split();
                    switch (commandData[0].ToLower())
                    {
                        case "add-stock":
                            market.AddOrUpdateStock(commandData[1], float.Parse(commandData[2]));
                            break;
                        case "add-owner":
                            market.AddOrUpdateOwner(commandData[1], commandData[2], int.Parse(commandData[3]));
                            break;
                        case "get-stocks-by-owner":
                            market.GetStocksByOwner(commandData[1]);
                            break;
                        case "remove-owner-stocks":
                            market.RemoveOwnerStocks(commandData[1], commandData[2]);
                            break;
                    }
                }

            } while (input.ToLower() != "end");
        }
    }
}
