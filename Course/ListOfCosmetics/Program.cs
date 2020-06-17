using System;
using System.Collections.Generic;

namespace ListOfCosmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cosmetic> cosmetics = new List<Cosmetic>();
            string input = string.Empty;

            do
            {
                input = Console.ReadLine();
                if(input.ToLower() != "end")
                {
                    string[] cosmeticData = input.Split();
                    Cosmetic cosmetic = new Cosmetic
                    {
                        Name = cosmeticData[0],
                        Weight = float.Parse(cosmeticData[1])
                    };
                    cosmetics.Add(cosmetic);
                }

            } while (input.ToLower() != "end");

            Console.WriteLine(GetTotalWeight(cosmetics));
        }

        private static float GetTotalWeight(List<Cosmetic> cosmetics)
        {
            float total = 0;
            foreach(Cosmetic cosmetic in cosmetics)
            {
                total += cosmetic.Weight;
            }

            return total;
        }
    }
}
