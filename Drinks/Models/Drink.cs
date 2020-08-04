using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Drinks.Models
{
    public class Drink
    {
        [Key]
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }

    }
}
