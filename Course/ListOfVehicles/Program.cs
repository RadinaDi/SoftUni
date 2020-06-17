using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string input = string.Empty;

            do
            {
                input = Console.ReadLine();
                if(input.ToLower() != "end")
                {
                    string[] vehicleData = input.Split();
                    Vehicle vehicle = new Vehicle()
                    {
                        Model = vehicleData[0],
                        Brand = vehicleData[1]
                    };

                    vehicles.Add(vehicle);
                }

            } while (input.ToLower() != "end");

            foreach(Vehicle item in vehicles.OrderBy(x => x.Brand))
            {
                Console.WriteLine(item);
            }

        }
    }
}
