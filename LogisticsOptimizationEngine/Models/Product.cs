using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsOptimizationEngine.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public Product(int id, string name, double price, int stock)
        {
            ProductID = id; 
            Name = name; 
            Price = price; 
            StockQuantity = stock;
        }
    }
}
