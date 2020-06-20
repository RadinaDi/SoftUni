using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomDictionary<Guid, int> dictionary = new CustomDictionary<Guid, int>();

            dictionary.Add(Guid.NewGuid(), 3);

            Console.WriteLine("Hello World!");
        }
    }
}
