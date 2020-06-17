using System.Collections.Generic;
using System.Linq;

namespace ListOfCountries
{
    class Country
    {
        private List<City> cities = null;

        public Country()
        {
            this.cities = new List<City>();
        }

        public string Name { get; set; }

        

        public void AddCity(string name, float area, int population)
        {
            City city = this.cities.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            if (city == null)
            {
                city = new City()
                {
                    Name = name,
                    Area = area,
                    Population = population
                };
                this.cities.Add(city);
            }
            else
            {
                city.Name = name;
                city.Area = area;
                city.Population = population;
            }
        }

        public float GetTotalArea()
        {
            float total = 0;

            foreach (City city in this.cities)
            {
                total += city.Area;
            }

            return total;
        }

        public int GetTotalPopulation()
        {
            int total = 0;

            foreach (City city in this.cities)
            {
                total += city.Population;
            }

            return total;
        }
    }
}
