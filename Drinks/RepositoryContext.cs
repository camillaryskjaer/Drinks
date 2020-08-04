using Drinks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Drinks
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext() : base()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); 
        }
        DbSet<Drink> Drinks { get; set; }
        DbSet<Ingredient> Ingredients { get; set; }
    }
}
