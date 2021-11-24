using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieFoodMvc.Models;
using MovieFoodMvc.Data;

namespace MovieFoodMvc.Data
{
    public class UnitOfWork : IDisposable
    {
        private MovieFoodMvcContext _context;
        private GenericRepository<Movie> movieRepository;
        private GenericRepository<Food> foodRepository;

        public UnitOfWork(MovieFoodMvcContext context)
        {
            _context = context;
        }

        public GenericRepository<Movie> MovieRepository
        {
            get 
            {
                if (this.movieRepository == null)
                {
                   this.movieRepository = new GenericRepository<Movie>(_context);
                }
                return movieRepository;
            }
        }

        public GenericRepository<Food> FoodRepository
        {
            get
            {
                if (this.foodRepository == null)
                {
                    this.foodRepository = new GenericRepository<Food>(_context);
                }
                return foodRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
