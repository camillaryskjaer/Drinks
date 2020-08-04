using Drinks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drinks.Repository
{
    public class IngerdientRepository : RepositoryBase<Ingredient>
    {
        public IngerdientRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
