using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticsOptimizationEngine.Models;

namespace LogisticsOptimizationEngine.DataStructures
{
    public class ProductLinkedList
    {
        private ProductNode head;

        public void AddProduct(Product newProduct)
        {
            ProductNode newNode = new ProductNode(newProduct);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                ProductNode current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public Product FindByID(int id)
        {
            ProductNode current = head;

            while (current != null)
            {
                if (current.Data.ProductID == id)
                {
                    return current.Data;
                }
                current = current.Next;
            }
            return null;
        }
    }
}