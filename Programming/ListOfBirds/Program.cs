using System;
using System.Collections.Generic;

namespace ListOfBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird>();
            string input = string.Empty;

            do
            {
                input = Console.ReadLine();

                if (input.ToLower() != "end")
                {
                    string[] birdData = input.Split();
                    Bird bird = new Bird
                    {
                        Name = birdData[0],
                        FlightLength = float.Parse(birdData[1])
                    };
                    birds.Add(bird);
                }

            } while (input.ToLower() != "end");

            Console.WriteLine($"Total length of flight of all birds is: {TotalLengthOfFlight(birds)}");
        }

        private static float TotalLengthOfFlight(List<Bird> birds)
        {
            float total = 0;
            foreach (Bird bird in birds)
            {
                total += bird.FlightLength;
            }
            return total;
        }
    }
}
