using LogisticsOptimizationEngine.Algorithm;
using LogisticsOptimizationEngine.DataStructures;
using LogisticsOptimizationEngine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeedData();
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

            UpdateExecutiveSummary();
        }

        // Algorithm: Linear Search (Via Linked List)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text)) return;
                int id = int.Parse(txtID.Text);

                // Custom Linked List
                Product result = inventory.FindByID(id);

                if (result != null)
                {
                    lblSearchStatus.Text = "Status: Found via Linear Search (O(n))";
                    MessageBox.Show($"Product: {result.Name}\nMode: Linear Search\nEfficiency: Standard");
                }
                else { MessageBox.Show("Not found in Linear List."); }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); 
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

            UpdateExecutiveSummary();

            MessageBox.Show("Inventory sorted successfully using Quick Sort!");
        }

        // Alogorithm: BST Search (Non-Linear) - O(log n) - professional standard for high-speed lookup
        private void btnTreeSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text)) return;
                int id = int.Parse(txtID.Text);

                // Use Custom Binary Search Tree
                Product result = searchTree.Search(id);

                if (result != null)
                {
                    lblSearchStatus.Text = "Status: Found via BST Search (O(log n))";
                    MessageBox.Show($"Product: {result.Name}\nMode: Tree Search\nEfficiency: High Speed");
                }
                else { MessageBox.Show("Not found in Search Tree."); }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); 
            }
        }

        private void SeedData()
        {
            // Create a list of sample products
            List<Product> sampleData = new List<Product>
    {
            new Product(1, "Workstation PC", 250000.00, 5),
            new Product(2, "Wireless Mouse", 2500.50, 50),
            new Product(3, "Mechanical Keyboard", 12000.00, 20),
            new Product(4, "Gaming Monitor", 45000.00, 15),
            new Product(5, "USB-C Hub", 4500.00, 30)
    };

            // Add each product to BOTH our structures
            foreach (var p in sampleData)
            {
                inventory.AddProduct(p);
                searchTree.Insert(p);

                // Also add them to the UI ListBox on Tab 3 so it's not empty
                lstDisplay.Items.Add($"ID: {p.ProductID} | {p.Name} | LKR {p.Price}");
                lstDisplaySort.Items.Add($"ID: {p.ProductID} | {p.Name} | LKR {p.Price}");
            }

            // Update the Analytics labels immediately
            UpdateExecutiveSummary();
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
            // Clear old data
            deliveryMap.Nodes.Clear();
            cmbStart.Items.Clear();
            cmbEnd.Items.Clear();

            // Create Nodes (Warehouses)
            var colombo = new LocationNode("Colombo");
            var negombo = new LocationNode("Negombo");
            var kandy = new LocationNode("Kandy");
            var galle = new LocationNode("Galle");
            var jaffna = new LocationNode("Jaffna");

            // Add Edges (Roads with KM distances)
            colombo.AddNeighbor(negombo, 35);
            colombo.AddNeighbor(galle, 125);
            negombo.AddNeighbor(kandy, 110);
            galle.AddNeighbor(kandy, 210);
            kandy.AddNeighbor(jaffna, 320);

            // Add to the Graph structure
            deliveryMap.Nodes.AddRange(new[] { colombo, negombo, kandy, galle, jaffna });

            // Update UI Dropdowns
            foreach (var node in deliveryMap.Nodes)
            {
                cmbStart.Items.Add(node.Name);
                cmbEnd.Items.Add(node.Name);
            }

            MessageBox.Show("Business Logistics Network Loaded Successfully!");
        }

        private void btnFindRoute_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckReach_Click(object sender, EventArgs e)
        {
            if (cmbStart.SelectedItem == null || cmbEnd.SelectedItem == null) return;

            RoutePlanner planner = new RoutePlanner();
            bool reachable = planner.CheckConnectivity(deliveryMap, cmbStart.Text, cmbEnd.Text);

            if (reachable)
                MessageBox.Show($"YES: A route exists between {cmbStart.Text} and {cmbEnd.Text}. (Verified via BFS)");
            else
                MessageBox.Show("NO: These warehouses are not connected in the current network.");
        }

        private void btnFindPath_Click(object sender, EventArgs e)
        {
            if (cmbStart.SelectedItem == null || cmbEnd.SelectedItem == null) return;

            RoutePlanner planner = new RoutePlanner();
            string result = planner.FindShortestPath(deliveryMap, cmbStart.Text, cmbEnd.Text);

            lblRouteResult.Text = "Optimal Route: " + result;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblPerformance_Click(object sender, EventArgs e)
        {

        }

        private void btnShort_Click(object sender, EventArgs e)
        {

        }

        private void btnSortAnl_Click(object sender, EventArgs e)
        {
            // Get data from our structure
            Product[] productArray = inventory.ToArray();

            if (productArray.Length < 1)
            {
                MessageBox.Show("No products available to sort.");
                return;
            }

            if (cmbSortMethod.SelectedItem == null)
            {
                MessageBox.Show("Please select a sorting method first.");
                return;
            }

            ProductSorter sorter = new ProductSorter();
            Stopwatch timer = new Stopwatch();

            // Execute based on selection and measure time
            if (cmbSortMethod.Text == "Quick Sort (Optimized)")
            {
                timer.Start();
                sorter.QuickSort(productArray, 0, productArray.Length - 1);
                timer.Stop();
                lblPerformance.Text = $"Execution Time (Quick Sort): {timer.Elapsed.TotalMilliseconds} ms";
            }
            else
            {
                timer.Start();
                sorter.BubbleSort(productArray);
                timer.Stop();
                lblPerformance.Text = $"Execution Time (Bubble Sort): {timer.Elapsed.TotalMilliseconds} ms";
            }

            // Update the UI ListBox
            lstDisplaySort.Items.Clear();
            lstDisplaySort.Items.Add($"--- {cmbSortMethod.Text.ToUpper()} RESULT ---");

            foreach (Product p in productArray)
            {
                lstDisplaySort.Items.Add($"ID: {p.ProductID} | {p.Name} | Price: LKR {p.Price}");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // ALGORITHM : Aggregate Statistics (Traversal Calculation) - O(n)
        private void UpdateExecutiveSummary()
        {
            Product[] products = inventory.ToArray();

            if (products.Length == 0) return;

            int count = products.Length;
            double totalValue = 0;
            double maxPrice = 0;
            string expensiveName = "";

            foreach (var p in products)
            {
                totalValue += (p.Price * p.StockQuantity); // Value = Price * Quantity

                // ALGORITHM : Extremum Search (Finding the Maximum)
                if (p.Price > maxPrice)
                {
                    maxPrice = p.Price;
                    expensiveName = p.Name;
                }
            }

            double avgPrice = totalValue / (products.Sum(p => p.StockQuantity)); // Weighted average

            // Update UI
            lblTotalItems.Text = $"Total Items: {count}";
            lblTotalValue.Text = $"Total Stock Value: LKR {totalValue:N2}";
            lblAvgPrice.Text = $"Avg Price per Unit: LKR {avgPrice:N2}";
            lblMostExpensive.Text = $"Most Expensive: {expensiveName} (LKR {maxPrice})";
        }
    }
}