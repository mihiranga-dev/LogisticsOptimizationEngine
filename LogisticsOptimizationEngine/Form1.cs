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

namespace LogisticsOptimizationEngine
{
    public partial class Form1 : Form
    {
        // Data structure instance
        ProductLinkedList inventory = new ProductLinkedList();

        public Form1()
        {
            InitializeComponent();
        }

        // Logic for adding product
        private void btnAdd_Product(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                double price = double.Parse(txtPrice.Text);
                int stock = int.Parse(txtStock.Text);

                Product newProd = new Product(id, name, price, stock);
                inventory.AddProduct(newProd);

                lstDisplay.Items.Add($"ID: {id} | {name} | ${price}");

                txtID.Clear(); txtName.Clear(); txtPrice.Clear(); txtStock.Clear();
                MessageBox.Show("Product added to Linked List!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input Error: " + ex.Message);
            }
        }

        // Logic for searching
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
                    MessageBox.Show($"Found: {result.Name}\nPrice: ${result.Price}\nStock: {result.StockQuantity}");
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

        private void Form1_Load(object sender, EventArgs e) { }
    }
}