using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFoodMvc.Models
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal SalePrice { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Profit
        {
            get
            {
                return (SalePrice * Quantity) - (UnitPrice * Quantity);
            }
        }
    }
}
