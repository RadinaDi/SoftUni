using System;
using System.Collections.Generic;
using System.Text;

namespace Flats
{
    class Building
    {
        private List<Flat> flats = new List<Flat>();
        public string Name { get; set; }

        public void AddFlats(string name, float area)
        {
            Flat flat = new Flat
            {
                Name = name,
                Area = area
            };
            flats.Add(flat);
        }

        public float GetTotalFlatsArea()
        {
            float totalArea = 0;
            foreach (Flat item in flats)
            {
                totalArea += item.Area;
            }
            return totalArea;


        }
    }
}
