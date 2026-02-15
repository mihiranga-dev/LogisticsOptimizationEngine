using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticsOptimizationEngine.Models;

namespace LogisticsOptimizationEngine.Algorithm
{
    public class ProductSorter
    {
        public void QuickSort(Product[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);

                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        private int Partition(Product[] array, int low, int high)
        {
            double pivot = array[high].Price;
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j].Price < pivot)
                {
                    i++;
                    Product temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            Product temp2 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp2;

            return i + 1;
        }

        // ALGORITHM : Bubble Sort 
        // Complexity: O(n^2)
        public void BubbleSort(Product[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].Price > array[j + 1].Price)
                    {
                        // Swap
                        Product temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
