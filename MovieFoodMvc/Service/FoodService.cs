using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieFoodMvc.Models;
using MovieFoodMvc.Data;

namespace MovieFoodMvc.Service
{
    public class FoodService : IFoodService
    {
        private readonly GenericRepository<Food> _foodRepo;
        private readonly UnitOfWork _unitOfWork;

        public FoodService(GenericRepository<Food> foodRepo, UnitOfWork unitOfWork)
        {
            _foodRepo = foodRepo;
            _unitOfWork = unitOfWork;
        }

        public List<Food> GetAllSold() => _unitOfWork.FoodRepository.Get();

        public void Delete(int Id)
        {
            _foodRepo.Delete(Id);
        }

        public void Update(Food food)
        {
            _foodRepo.Update(food);
        }
    }
}
