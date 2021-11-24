using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieFoodMvc.Models;
using MovieFoodMvc.Data;

namespace MovieFoodMvc.Service
{
    public class MovieService : IMovieService
    {
        private readonly GenericRepository<Movie> _movieRepo;

        public MovieService(GenericRepository<Movie> movieRepo)
        {
            _movieRepo = movieRepo;
        }

        public List<Movie> GetAllSold() => _movieRepo.Get();

        public void Delete(int Id)
        {
            _movieRepo.Delete(Id);
        }

        public void Update(Movie movie)
        {
            
            _movieRepo.Update(movie);
        }
    }
}
