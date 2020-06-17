using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            string input = string.Empty;

            do
            {
                input = Console.ReadLine();
                if(input.ToLower() != "end")
                {
                    names.Add(input);
                }

            } while (input.ToLower() != "end");

            foreach (string item in names.OrderBy(x => x))
            {
                Console.WriteLine(item);
            }

            
        }

    }
}
