using System;
using System.Collections.Generic;
using System.Linq;

namespace Cakes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Cake> cakes = new List<Cake>();

            //do
            //{
            //    input = Console.ReadLine(); 
            //    if(input.ToLower() != "end")
            //    {
            //        string[] cakeData = input.Split();
            //        string cakeName = cakeData[0];
            //        Cake cake1 = new Cake
            //        {
            //            Name = cakeName,
            //        };
            //        cakes.Add(cake1);
            //    }

            //} while (input.ToLower() != "end");

            do
            {
                input = Console.ReadLine();
                if (input.ToLower() != "end")
                {
                    string[] ingredientData = input.Split();
                    string ingredientName = ingredientData[0];
                    string cakeName = ingredientData[1];
                    float ingredientWeight = float.Parse(ingredientData[2]);

                    Cake cake1 = cakes.FirstOrDefault(x => x.Name == cakeName);
                    if (cake1 == null)
                    {
                        cake1 = new Cake()
                        {
                            Name = cakeName
                        };
                        cakes.Add(cake1);

                        cake1.AddIngredients(ingredientName, ingredientWeight);
                    }
                    else
                    {
                        cake1.AddIngredients(ingredientName, ingredientWeight);
                    }
                }

            } while (input.ToLower() != "end");

            foreach (Cake item in cakes)
            {
                Console.WriteLine($"{item.Name} {item.GetTotalCakeWeight():f2}");
            }

        }
    }
}
