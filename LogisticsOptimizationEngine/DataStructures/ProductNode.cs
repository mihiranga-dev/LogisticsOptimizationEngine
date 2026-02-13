using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticsOptimizationEngine.Models;

namespace LogisticsOptimizationEngine.DataStructures
{
    public class ProductNode
    {
        public Product Data;
        public ProductNode Next;

        public ProductNode(Product product)
        {
            this.Data = product;
            this.Next = null;
        }
    }
}
