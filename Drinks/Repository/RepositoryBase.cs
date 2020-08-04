using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Drinks.Repository
{
    public abstract class RepositoryBase<T> where T : class
    {
        protected RepositoryContext repositoryContext { get; set; }

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            this.repositoryContext = repositoryContext;
        }
        protected IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.repositoryContext.Set<T>().Where(expression);
        }
        protected IQueryable<T> FindAll()
        {
            return this.repositoryContext.Set<T>();
        }
        protected void Create(T entity)
        {
            this.repositoryContext.Add(entity);
        }
    }
}
