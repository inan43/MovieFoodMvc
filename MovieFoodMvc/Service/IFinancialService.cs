using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieFoodMvc.Models;

namespace MovieFoodMvc.Service
{
    public interface IFinancialService
    {
        FinancialStats GetStats();
    }
}
