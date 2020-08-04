using Drinks.Models;
using Drinks.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient() { Name = "Vodka" });
            ingredients.Add(new Ingredient() { Name = "Redbull" });
            using (var ctx = new RepositoryContext())
            {
                DrinkRepository DR = new DrinkRepository(ctx);
                List<Drink> loopDrinks = DR.FindDrinksByIngredient("Vodka");
                foreach (var item in loopDrinks)
                {
                    Console.WriteLine(item.Name);
                }
                
            }
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
