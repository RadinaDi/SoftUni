using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Animal> animals = new List<Animal>();
            do
            {
                input = Console.ReadLine();
                if (input.ToLower() != "end")
                {
                    string[] animalData = input.Split();
                    Animal animal = new Animal
                    {
                        Name = animalData[0],
                        Type = animalData[1],
                        Weight = float.Parse(animalData[2])
                    };
                    animals.Add(animal);
                }

            } while (input.ToLower() != "end");

            float total = 0;
            int count = 0;
            input = Console.ReadLine();
            foreach (Animal item in animals)
            {
                if (item.Type == input)
                {
                    total += item.Weight;
                    count++;
                }
            }

            Console.WriteLine($"Average weight per animal type is: {total / count:F2}");
        }
    }
}


