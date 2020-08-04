using Drinks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drinks.Repository
{
    public class DrinkRepository : RepositoryBase<Drink>
    {
        public DrinkRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateDrink(Drink drink)
        {
            Create(drink);
        }
        public List<Drink> FindDrinksByIngredient(string ingredientName)
        {
            List<Drink> returnDrinks = new List<Drink>();
            List<Drink> allDrinks = FindAll().OrderBy(drink => drink.Name).ToList();
            foreach (var drink in allDrinks)
            {
                foreach (var ingredient in drink.Ingredients)
                {
                    if (ingredient.Name == ingredientName)
                    {

                        returnDrinks.Add(drink);
                    }
                }
            }
            return returnDrinks;
        }
        public Drink FindDrinkByName(string drinkName)
        {
            return FindByCondition(drink => drink.Name.Equals(drinkName)).FirstOrDefault();
        }
    }
}
