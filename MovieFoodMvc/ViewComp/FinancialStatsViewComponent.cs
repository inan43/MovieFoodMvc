using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieFoodMvc.Service;
using MovieFoodMvc.Models;


namespace MovieFoodMvc.ViewComp
{
    public class FinancialStatsViewComponent : ViewComponent
    {
        private readonly IFinancialService _financialService;

        public FinancialStatsViewComponent(IFinancialService financialService)
        {
            _financialService = financialService;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var stats = _financialService.GetStats();
            return Task.FromResult<IViewComponentResult>(View(stats));
        }
    }
}
