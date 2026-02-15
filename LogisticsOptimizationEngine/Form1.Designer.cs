namespace LogisticsOptimizationEngine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTreeSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnInitializeMap = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStart = new System.Windows.Forms.ComboBox();
            this.cmbEnd = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFindPath = new System.Windows.Forms.Button();
            this.lblRouteResult = new System.Windows.Forms.Label();
            this.lblSearchStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckReach = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSortMethod = new System.Windows.Forms.ComboBox();
            this.btnSortAnl = new System.Windows.Forms.Button();
            this.lstDisplaySort = new System.Windows.Forms.ListBox();
            this.lblPerformance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.lblMostExpensive = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSearchStatus);
            this.tabPage1.Controls.Add(this.btnSort);
            this.tabPage1.Controls.Add(this.lstDisplay);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnTreeSearch);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtStock);
            this.tabPage1.Controls.Add(this.txtPrice);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventory Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCheckReach);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lblRouteResult);
            this.tabPage2.Controls.Add(this.btnFindPath);
            this.tabPage2.Controls.Add(this.cmbEnd);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cmbStart);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnInitializeMap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logistics & Map";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.lblPerformance);
            this.tabPage3.Controls.Add(this.lstDisplaySort);
            this.tabPage3.Controls.Add(this.btnSortAnl);
            this.tabPage3.Controls.Add(this.cmbSortMethod);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Analytics & Reports";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(42, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Product);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 69);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(202, 20);
            this.txtID.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(124, 160);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(202, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(124, 203);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(202, 20);
            this.txtStock.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stock";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(190, 261);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 29);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Linear Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTreeSearch
            // 
            this.btnTreeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreeSearch.Location = new System.Drawing.Point(84, 318);
            this.btnTreeSearch.Name = "btnTreeSearch";
            this.btnTreeSearch.Size = new System.Drawing.Size(166, 29);
            this.btnTreeSearch.TabIndex = 16;
            this.btnTreeSearch.Text = "Fast Tree Search";
            this.btnTreeSearch.UseVisualStyleBackColor = true;
            this.btnTreeSearch.Click += new System.EventHandler(this.btnTreeSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Inventory Management";
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(391, 69);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(351, 290);
            this.lstDisplay.TabIndex = 18;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(598, 365);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(144, 29);
            this.btnSort.TabIndex = 19;
            this.btnSort.Text = "Sort by Price";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnInitializeMap
            // 
            this.btnInitializeMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitializeMap.Location = new System.Drawing.Point(283, 88);
            this.btnInitializeMap.Name = "btnInitializeMap";
            this.btnInitializeMap.Size = new System.Drawing.Size(202, 29);
            this.btnInitializeMap.TabIndex = 0;
            this.btnInitializeMap.Text = "Initialize Logistics Network";
            this.btnInitializeMap.UseVisualStyleBackColor = true;
            this.btnInitializeMap.Click += new System.EventHandler(this.btnInitializeMap_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Starting Warehouse:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbStart
            // 
            this.cmbStart.FormattingEnabled = true;
            this.cmbStart.Location = new System.Drawing.Point(357, 139);
            this.cmbStart.Name = "cmbStart";
            this.cmbStart.Size = new System.Drawing.Size(218, 21);
            this.cmbStart.TabIndex = 2;
            this.cmbStart.SelectedIndexChanged += new System.EventHandler(this.cmbStart_SelectedIndexChanged);
            // 
            // cmbEnd
            // 
            this.cmbEnd.FormattingEnabled = true;
            this.cmbEnd.Location = new System.Drawing.Point(357, 176);
            this.cmbEnd.Name = "cmbEnd";
            this.cmbEnd.Size = new System.Drawing.Size(218, 21);
            this.cmbEnd.TabIndex = 4;
            this.cmbEnd.SelectedIndexChanged += new System.EventHandler(this.cmbEnd_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Destination Warehouse:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnFindPath
            // 
            this.btnFindPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPath.Location = new System.Drawing.Point(219, 265);
            this.btnFindPath.Name = "btnFindPath";
            this.btnFindPath.Size = new System.Drawing.Size(312, 32);
            this.btnFindPath.TabIndex = 5;
            this.btnFindPath.Text = "Calculate Shortest Path (Dijkstra)";
            this.btnFindPath.UseVisualStyleBackColor = true;
            this.btnFindPath.Click += new System.EventHandler(this.btnFindPath_Click);
            // 
            // lblRouteResult
            // 
            this.lblRouteResult.AutoSize = true;
            this.lblRouteResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRouteResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteResult.Location = new System.Drawing.Point(65, 330);
            this.lblRouteResult.Name = "lblRouteResult";
            this.lblRouteResult.Size = new System.Drawing.Size(150, 26);
            this.lblRouteResult.TabIndex = 6;
            this.lblRouteResult.Text = "Path Result: ---";
            // 
            // lblSearchStatus
            // 
            this.lblSearchStatus.AutoSize = true;
            this.lblSearchStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStatus.Location = new System.Drawing.Point(39, 372);
            this.lblSearchStatus.Name = "lblSearchStatus";
            this.lblSearchStatus.Size = new System.Drawing.Size(126, 16);
            this.lblSearchStatus.TabIndex = 20;
            this.lblSearchStatus.Text = "Search Comparison";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(426, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Delivery Route Optimization Engine";
            // 
            // btnCheckReach
            // 
            this.btnCheckReach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckReach.Location = new System.Drawing.Point(249, 216);
            this.btnCheckReach.Name = "btnCheckReach";
            this.btnCheckReach.Size = new System.Drawing.Size(257, 32);
            this.btnCheckReach.TabIndex = 8;
            this.btnCheckReach.Text = "Verify Connectivity (BFS)";
            this.btnCheckReach.UseVisualStyleBackColor = true;
            this.btnCheckReach.Click += new System.EventHandler(this.btnCheckReach_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(173, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(434, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Inventory Analytics and Performance";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cmbSortMethod
            // 
            this.cmbSortMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortMethod.FormattingEnabled = true;
            this.cmbSortMethod.Items.AddRange(new object[] {
            "Quick Sort (Optimized)",
            "Bubble Sort (Baseline)"});
            this.cmbSortMethod.Location = new System.Drawing.Point(49, 61);
            this.cmbSortMethod.Name = "cmbSortMethod";
            this.cmbSortMethod.Size = new System.Drawing.Size(242, 24);
            this.cmbSortMethod.TabIndex = 1;
            // 
            // btnSortAnl
            // 
            this.btnSortAnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAnl.Location = new System.Drawing.Point(69, 95);
            this.btnSortAnl.Name = "btnSortAnl";
            this.btnSortAnl.Size = new System.Drawing.Size(200, 34);
            this.btnSortAnl.TabIndex = 2;
            this.btnSortAnl.Text = "Run Sorting Algorithm";
            this.btnSortAnl.UseVisualStyleBackColor = true;
            this.btnSortAnl.Click += new System.EventHandler(this.btnSortAnl_Click);
            // 
            // lstDisplaySort
            // 
            this.lstDisplaySort.FormattingEnabled = true;
            this.lstDisplaySort.Location = new System.Drawing.Point(34, 135);
            this.lstDisplaySort.Name = "lstDisplaySort";
            this.lstDisplaySort.Size = new System.Drawing.Size(268, 238);
            this.lstDisplaySort.TabIndex = 3;
            // 
            // lblPerformance
            // 
            this.lblPerformance.AutoSize = true;
            this.lblPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformance.Location = new System.Drawing.Point(81, 386);
            this.lblPerformance.Name = "lblPerformance";
            this.lblPerformance.Size = new System.Drawing.Size(174, 20);
            this.lblPerformance.TabIndex = 4;
            this.lblPerformance.Text = "Execution Time: 0ms";
            this.lblPerformance.Click += new System.EventHandler(this.lblPerformance_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMostExpensive);
            this.panel1.Controls.Add(this.lblAvgPrice);
            this.panel1.Controls.Add(this.lblTotalValue);
            this.panel1.Controls.Add(this.lblTotalItems);
            this.panel1.Location = new System.Drawing.Point(368, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 196);
            this.panel1.TabIndex = 5;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(19, 10);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(134, 24);
            this.lblTotalItems.TabIndex = 0;
            this.lblTotalItems.Text = "Total Items: 0";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(19, 59);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(235, 24);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "Total Stock Value: $0.00";
            // 
            // lblAvgPrice
            // 
            this.lblAvgPrice.AutoSize = true;
            this.lblAvgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPrice.Location = new System.Drawing.Point(19, 106);
            this.lblAvgPrice.Name = "lblAvgPrice";
            this.lblAvgPrice.Size = new System.Drawing.Size(204, 24);
            this.lblAvgPrice.TabIndex = 2;
            this.lblAvgPrice.Text = "Average Price: $0.00";
            // 
            // lblMostExpensive
            // 
            this.lblMostExpensive.AutoSize = true;
            this.lblMostExpensive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostExpensive.Location = new System.Drawing.Point(19, 153);
            this.lblMostExpensive.Name = "lblMostExpensive";
            this.lblMostExpensive.Size = new System.Drawing.Size(221, 24);
            this.lblMostExpensive.TabIndex = 3;
            this.lblMostExpensive.Text = "Most Expensive: None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 446);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTreeSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.ComboBox cmbStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInitializeMap;
        private System.Windows.Forms.Button btnFindPath;
        private System.Windows.Forms.ComboBox cmbEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRouteResult;
        private System.Windows.Forms.Label lblSearchStatus;
        private System.Windows.Forms.Button btnCheckReach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSortMethod;
        private System.Windows.Forms.Label lblPerformance;
        private System.Windows.Forms.ListBox lstDisplaySort;
        private System.Windows.Forms.Button btnSortAnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMostExpensive;
        private System.Windows.Forms.Label lblAvgPrice;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalItems;
    }
}

