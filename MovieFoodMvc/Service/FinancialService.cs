using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieFoodMvc.Data;
using MovieFoodMvc.Models;

namespace MovieFoodMvc.Service
{
    public class FinancialService : IFinancialService
    {
        private readonly GenericRepository<Movie> _movieRepo;
        private readonly GenericRepository<Food> _foodRepo;
        private readonly UnitOfWork _unitOfWork;

        public FinancialService(GenericRepository<Movie> movieRepo, GenericRepository<Food> foodRepo, UnitOfWork unitOfWork)
        {
            _movieRepo = movieRepo;
            _foodRepo = foodRepo;
            _unitOfWork = unitOfWork;
        }

        public FinancialStats GetStats()
        {
            FinancialStats stats = new FinancialStats();
            //var foodSold = _foodRepo.Get();
            var foodSold = _unitOfWork.FoodRepository.Get();
            //var moviesSold = _movieRepo.Get();
            var moviesSold = _unitOfWork.MovieRepository.Get();

            stats.AverageMovieProfit = moviesSold.Sum(x => x.Profit) / moviesSold.Sum(x => x.Quantity);
            stats.AverageFoodItemProfit =
          foodSold.Sum(x => x.Profit) / foodSold.Sum(x => x.Quantity);

            return stats;
        }
    }
}
