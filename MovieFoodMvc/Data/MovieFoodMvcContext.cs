using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieFoodMvc.Models;

namespace MovieFoodMvc.Data
{
    public class MovieFoodMvcContext : DbContext
    {
        public MovieFoodMvcContext (DbContextOptions<MovieFoodMvcContext> options)
            : base(options)
        {
        }

        public DbSet<MovieFoodMvc.Models.Food> Food { get; set; }

        public DbSet<MovieFoodMvc.Models.Movie> Movie { get; set; }
    }
}
