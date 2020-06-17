using System;
using System.Collections.Generic;
using System.Linq;

namespace Quarters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Quarter> quarters = new List<Quarter>();
            string input = string.Empty;

            do
            {
                input = Console.ReadLine();
                if(input.ToLower() != "end")
                {
                    string[] quarterData = input.Split();
                    string quarterName = quarterData[0];
                    int quarterResidents = int.Parse(quarterData[1]);
                    Quarter quarter1 = new Quarter
                    {
                        Name = quarterName,
                        Residents = quarterResidents

                    };
                    quarters.Add(quarter1);
                }

            } while (input.ToLower() != "end");

            do
            {
                input = Console.ReadLine();
                if(input.ToLower() != "end")
                {
                    string[] shopData = input.Split();
                    string shopName = shopData[0];
                    string quarterName = shopData[1];
                    int shopProfit = int.Parse(shopData[2]);

                    Quarter quarter2 = quarters.FirstOrDefault(x => x.Name == quarterName);
                    if(quarter2 != null)
                    {
                        quarter2.AddShop(shopName, shopProfit);
                    }

                }
                

            } while (input.ToLower() != "end");

            
            foreach(Quarter item in quarters)
            {
                Console.WriteLine($"{item.Name} {item.GetAveragePersonSpendings():f2}");
            }
        }
    }
}
