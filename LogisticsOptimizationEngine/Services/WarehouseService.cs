using LogisticsOptimizationEngine.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticsOptimizationEngine.Models;

namespace LogisticsOptimizationEngine.Services
{
    public class WarehouseService
    {
        public ProductLinkedList Inventory { get; private set; }
        public InventoryTree SearchTree { get; private set;  }

        public WarehouseService()
        {
            Inventory = new ProductLinkedList(); 
            SearchTree = new InventoryTree();
        }

        public void RegisterProduct(Product p)
        {
            Inventory.AddProduct(p);
            SearchTree.Insert(p);
        }
    }
}
