using System;

namespace ListOfCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            string input = string.Empty;

            do
            {
                input = Console.ReadLine();
                if (input.ToLower() != "end")
                {
                    string[] countryData = input.Split();
                    catalogue.AddCountryAndCity(countryData[0], countryData[1], float.Parse(countryData[2]), int.Parse(countryData[3]));
                }

            } while (input.ToLower() != "end");

            catalogue.PrintAreaPerCountry();
            catalogue.PrintPopulationPerCountry();

        }
    }
}
