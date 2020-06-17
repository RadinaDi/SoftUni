using System.Collections.Generic;

namespace Cakes
{
    class Cake
    {
        private List<Ingredient>  ingredients = new List<Ingredient>();
        public string Name { get; set; }

        public void AddIngredients(string name, float weight)
        {
            Ingredient ingredient1 = new Ingredient
            {
                Name = name,
                Weight = weight
            };
            ingredients.Add(ingredient1);
        }

        public float GetTotalCakeWeight()
        {
            float totalWeight = 0;
            foreach (Ingredient item in ingredients)
            {
                totalWeight += item.Weight;
            }
            return totalWeight;


        }
    }
}
