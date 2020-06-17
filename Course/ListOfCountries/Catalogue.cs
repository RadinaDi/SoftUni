using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfCountries
{
    class Catalogue
    {
        private List<Country> countries = null;

        public Catalogue()
        {
            this.countries = new List<Country>();
        }

        public void AddCountryAndCity(string countryName, string cityName, float area, int population)
        {
            Country country = this.countries.FirstOrDefault(x => x.Name.ToLower() == countryName.ToLower());
            if (country == null)
            {
                country = new Country()
                {
                    Name = countryName
                };
                this.countries.Add(country);
            }

            country.AddCity(cityName, area, population);
        }

        public void PrintAreaPerCountry()
        {
            Console.WriteLine("Area per Country:");
            foreach (Country country in this.countries)
            {
                Console.WriteLine($"{country.Name} has area of {country.GetTotalArea():F2} sq. km.");
            }
        }

        public void PrintPopulationPerCountry()
        {
            Console.WriteLine("Population per Country:");
            foreach (Country country in this.countries)
            {
                Console.WriteLine($"{country.Name} has population of {country.GetTotalPopulation():F2} people.");
            }
        }
    } 
}
