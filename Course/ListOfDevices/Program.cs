using System;
using System.Collections.Generic;

namespace ListOfDevices
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Device> devices = new List<Device>();
            string input = string.Empty;

            do
            {
                input = Console.ReadLine();

                    if (input.ToLower() != "end")
                    {
                    string[] deviceData = input.Split();
                     Device device = new Device
                    {
                        Brand = deviceData[0],
                        Type = deviceData[1],
                        Weight = int.Parse(deviceData[2])
                    };

                    devices.Add(device);
                }
            } while(input.ToLower() != "end");

            float laptopAv = AverageWeight(devices, "laptop");
            float cellphoneAv = AverageWeight(devices, "cellphone");

            Console.WriteLine($"Average Weight for device type \"laptop\" is: {laptopAv:f2}");
            Console.WriteLine($"Average Weight for device type \"cellphone\" is: {cellphoneAv:f2}");

        }

        private static float AverageWeight(List<Device> devices, string type)
        {
            int sum = 0;
            int count = 0;

            for(int i = 0; i < devices.Count; i++)
            {
                if(devices[i].Type.ToLower() == type) 
                {
                    sum += devices[i].Weight;
                    count++;
                }
            }

            if (count == 0)
            {
                return 0;
            }
            else
            {
                return (float)sum / count;
            }
        }
    }
}
