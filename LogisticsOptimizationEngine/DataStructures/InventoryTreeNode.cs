using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticsOptimizationEngine.Models;

namespace LogisticsOptimizationEngine.DataStructures
{
    public class InventoryTreeNode
    {
        public Product Data;
        public InventoryTreeNode Left;
        public InventoryTreeNode Right;

        public InventoryTreeNode(Product product)
        {
            this.Data = product;
            this.Left = null;
            this.Right = null;
        }
    }
}
