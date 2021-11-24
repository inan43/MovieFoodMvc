using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using MovieFoodMvc.Models;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;
using MovieFoodMvc.Data;

namespace MovieFoodMvc.Data
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal MovieFoodMvcContext context;
        internal DbSet<TEntity> _dbSet;

        public GenericRepository(MovieFoodMvcContext context)
        {
            this.context = context;
            this._dbSet = context.Set<TEntity>();
        }

        public virtual List<TEntity> Get(
                Expression<Func<TEntity, bool>> filter = null,
                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                string includeProperties = "")
        {
            {
                return _dbSet.ToList();
            }
        }

        public virtual List<TEntity> Get()
        {
           return _dbSet.ToList();
        }

        public virtual TEntity GetByID(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(object id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
            
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
