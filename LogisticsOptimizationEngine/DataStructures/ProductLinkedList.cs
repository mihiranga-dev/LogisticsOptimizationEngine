using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticsOptimizationEngine.Models;

namespace LogisticsOptimizationEngine.DataStructures
{
    // ALGORITHM : Linear Data Structure (Singly Linked List)
    // Purpose: Dynamic memory allocation for sequential data storage
    public class ProductLinkedList
    {
        private ProductNode head;

        // O(n) Insertion at the end of the list
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

        // Algorithm: Linear Search - Complexity: O(n)
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

        // Converts Linked List to Array for Sorting/UI compatibility
        public Product[] ToArray()
        {
            int count = 0;
            ProductNode current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            Product[] arr = new Product[count];

            current = head;
            for (int i = 0; i < count; i++)
            {
                arr[i] = current.Data;
                current = current.Next;
            }

            return arr;
        }
    }
}