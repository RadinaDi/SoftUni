using System;
using System.Collections.Generic;
using System.Linq;

namespace Flats
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Building> buildings = new List<Building>();

            do
            {
                input = Console.ReadLine();
                if (input.ToLower() != "end")
                {
                    string[] flatData = input.Split();
                    string flatName = flatData[0];
                    string buildingName = flatData[1];
                    float flatArea = float.Parse(flatData[2]);

                    Building building = buildings.FirstOrDefault(x => x.Name == buildingName);
                    if (building == null)
                    {
                        building = new Building()
                        {
                            Name = buildingName
                        };
                        buildings.Add(building);

                        building.AddFlats(flatName, flatArea);
                    }
                    else
                    {
                        building.AddFlats(flatName, flatArea);
                    }
                }

            } while (input.ToLower() != "end");

            foreach (Building item in buildings)
            {
                Console.WriteLine($"{item.Name} {item.GetTotalFlatsArea():f2}");
            }

        }
    }
}
