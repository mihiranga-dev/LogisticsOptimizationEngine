using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogisticsOptimizationEngine.Models;
using LogisticsOptimizationEngine.DataStructures;
using LogisticsOptimizationEngine.Algorithm;

namespace LogisticsOptimizationEngine
{
    public partial class Form1 : Form
    {
        // Linked List
        ProductLinkedList inventory = new ProductLinkedList();

        // Binary Search Tree - O(log n) searching
        InventoryTree searchTree = new InventoryTree();

        // Graph
        LogisticsGraph deliveryMap = new LogisticsGraph();

        public Form1()
        {
            InitializeComponent();
        }

        // Add Product
        private void btnAdd_Product(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                double price = double.Parse(txtPrice.Text);
                int stock = int.Parse(txtStock.Text);

                Product newProd = new Product(id, name, price, stock);

                // Add to Linear structure
                inventory.AddProduct(newProd);

                // Add to Non-Linear structure
                searchTree.Insert(newProd);

                lstDisplay.Items.Add($"ID: {id} | {name} | ${price}");

                txtID.Clear(); txtName.Clear(); txtPrice.Clear(); txtStock.Clear();
                MessageBox.Show("Product added Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input Error: " + ex.Message);
            }
        }

        // Algorithm: Linear Search (Via Linked List)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Please enter an ID to search.");
                    return;
                }

                int searchID = int.Parse(txtID.Text);
                Product result = inventory.FindByID(searchID);

                if (result != null)
                {
                    MessageBox.Show($"[LINEAR SEARCH] Found: {result.Name}\nPrice: ${result.Price}\nStock: {result.StockQuantity}");
                }
                else
                {
                    MessageBox.Show("Product not found in the list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        // Alogorithm - Quick Sort - O(n log n) - Efficient
        private void btnSort_Click(object sender, EventArgs e)
        {
            // Extract from Linked List to Array for Random Access sorting
            Product[] productArray = inventory.ToArray();

            if (productArray.Length < 2)
            {
                MessageBox.Show("Need at least 2 products to sort!");
                return;
            }

            ProductSorter sorter = new ProductSorter();
            sorter.QuickSort(productArray, 0, productArray.Length - 1);

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add("--- SORTED BY PRICE (Low to High) ---");

            foreach (Product p in productArray)
            {
                lstDisplay.Items.Add($"ID: {p.ProductID} | {p.Name} | ${p.Price}");
            }

            MessageBox.Show("Inventory sorted successfully using Quick Sort!");
        }

        // Alogorithm: BST Search (Non-Linear) - O(log n) - professional standard for high-speed lookup
        private void btnTreeSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text)) return;

                int id = int.Parse(txtID.Text);
                Product result = searchTree.Search(id);

                if (result != null)
                    MessageBox.Show($"[TREE SEARCH] Found: {result.Name} (Price: ${result.Price})");
                else
                    MessageBox.Show("Product not found in Tree");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbStart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbEnd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInitializeMap_Click(object sender, EventArgs e)
        {
            // Clear existing data to prevent duplicates if clicked twice
            deliveryMap.Nodes.Clear();
            cmbStart.Items.Clear();
            cmbEnd.Items.Clear();

            // Create Warehouse Locations (Nodes)
            LocationNode colombo = new LocationNode("Colombo");
            LocationNode kandy = new LocationNode("Kandy");
            LocationNode galle = new LocationNode("Galle");
            LocationNode jaffna = new LocationNode("Jaffna");
            LocationNode negombo = new LocationNode("Negombo");

            // Create the "Roads" (Edges) with distances in km
            colombo.AddNeighbor(negombo, 35);
            colombo.AddNeighbor(galle, 125);
            negombo.AddNeighbor(kandy, 110);
            kandy.AddNeighbor(jaffna, 320);
            galle.AddNeighbor(kandy, 210);

            // Add them to Graph
            deliveryMap.Nodes.AddRange(new[] { colombo, negombo, kandy, galle, jaffna });

            // Fill the UI Dropdowns
            foreach (var node in deliveryMap.Nodes)
            {
                cmbStart.Items.Add(node.Name);
                cmbEnd.Items.Add(node.Name);
            }

            MessageBox.Show("Delivery Network Loaded Successfully!");
        }

        private void btnFindRoute_Click(object sender, EventArgs e)
        {
            if (cmbStart.SelectedItem == null || cmbEnd.SelectedItem == null)
            {
                MessageBox.Show("Please select both a Start and Destination.");
                return;
            }

            string startCity = cmbStart.SelectedItem.ToString();
            string endCity = cmbEnd.SelectedItem.ToString();

            // Call our Algorithm
            RoutePlanner planner = new RoutePlanner();
            string finalPath = planner.FindShortestPath(deliveryMap, startCity, endCity);

            // Display the result
            lblResult.Text = finalPath;
        }
    }
}