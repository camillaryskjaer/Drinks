using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Drinks.Models
{
    public class Drink
    {
        [Key]
        public string Name { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }

    }
}
