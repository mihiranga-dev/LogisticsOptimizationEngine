using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using LogisticsOptimizationEngine.Models;

namespace LogisticsOptimizationEngine.DataStructures
{
    // ALGORITHM : RECURSIVE BST INSERTION
    public class InventoryTree
    {
        public InventoryTreeNode Root;

        // Entry point for product insertion
        public void Insert(Product product)
        {
            Root = InsertRecursive(Root, product);
        }

        // Recursive insertion logic: O(log n) complexity
        public InventoryTreeNode InsertRecursive(InventoryTreeNode root, Product product)
        {
            if (root == null) return new InventoryTreeNode(product);

            if (product.ProductID < root.Data.ProductID)
                root.Left = InsertRecursive(root.Left, product);

            else if (product.ProductID > root.Data.ProductID)
                root.Right = InsertRecursive(root.Right, product);

            return root;
        }

        // ALGORITHM : Binary Search Tree (BST)
        public Product Search(int id)
        {
            return SearchRecursive(Root, id);
        }

        // Recursive Search: O(log n) complexity
        private Product SearchRecursive(InventoryTreeNode root, int id)
        {
            if (root == null) return null;
            if (root.Data.ProductID == id) return root.Data;

            if (root.Data.ProductID == id)
                return SearchRecursive(root.Left, id);

            return SearchRecursive(root.Right, id) ;
        }
    }
}
