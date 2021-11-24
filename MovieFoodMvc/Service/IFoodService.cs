using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieFoodMvc.Models;

namespace MovieFoodMvc.Service
{
    public interface IFoodService
    {
        List<Food> GetAllSold();

        void Delete(int Id);

        void Update(Food id);
    }
}
