namespace Main_Screen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            addButton1 = new Button();
            modifyButton1 = new Button();
            deleteButton1 = new Button();
            PartsLabel = new Label();
            productsLabel = new Label();
            InventoryManagmentLabel = new Label();
            modifyButton2 = new Button();
            addButton2 = new Button();
            deleteButton2 = new Button();
            searchButton1 = new Button();
            searchButton2 = new Button();
            searchBox1 = new TextBox();
            searchBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // addButton1
            // 
            addButton1.Location = new Point(423, 338);
            addButton1.Name = "addButton1";
            addButton1.Size = new Size(75, 23);
            addButton1.TabIndex = 0;
            addButton1.Text = "Add";
            addButton1.UseVisualStyleBackColor = true;
            addButton1.Click += addButton1_Click;
            // 
            // modifyButton1
            // 
            modifyButton1.Location = new Point(504, 338);
            modifyButton1.Name = "modifyButton1";
            modifyButton1.Size = new Size(75, 23);
            modifyButton1.TabIndex = 1;
            modifyButton1.Text = "Modify";
            modifyButton1.UseVisualStyleBackColor = true;
            modifyButton1.Click += modifyButton1_Click;
            // 
            // deleteButton1
            // 
            deleteButton1.Location = new Point(585, 338);
            deleteButton1.Name = "deleteButton1";
            deleteButton1.Size = new Size(75, 23);
            deleteButton1.TabIndex = 2;
            deleteButton1.Text = "Delete";
            deleteButton1.UseVisualStyleBackColor = true;
            deleteButton1.Click += deleteButton1_Click;
            // 
            // PartsLabel
            // 
            PartsLabel.AutoSize = true;
            PartsLabel.Location = new Point(16, 101);
            PartsLabel.Name = "PartsLabel";
            PartsLabel.Size = new Size(33, 15);
            PartsLabel.TabIndex = 3;
            PartsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Location = new Point(717, 101);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(54, 15);
            productsLabel.TabIndex = 4;
            productsLabel.Text = "Products";
            // 
            // InventoryManagmentLabel
            // 
            InventoryManagmentLabel.AutoSize = true;
            InventoryManagmentLabel.Location = new Point(16, 8);
            InventoryManagmentLabel.Name = "InventoryManagmentLabel";
            InventoryManagmentLabel.Size = new Size(166, 15);
            InventoryManagmentLabel.TabIndex = 5;
            InventoryManagmentLabel.Text = "Inventory Managment System";
            // 
            // modifyButton2
            // 
            modifyButton2.Location = new Point(1205, 338);
            modifyButton2.Name = "modifyButton2";
            modifyButton2.Size = new Size(75, 23);
            modifyButton2.TabIndex = 6;
            modifyButton2.Text = "Modify";
            modifyButton2.UseVisualStyleBackColor = true;
            modifyButton2.Click += modifyButton2_Click;
            // 
            // addButton2
            // 
            addButton2.Location = new Point(1112, 338);
            addButton2.Name = "addButton2";
            addButton2.Size = new Size(75, 23);
            addButton2.TabIndex = 7;
            addButton2.Text = "Add";
            addButton2.UseVisualStyleBackColor = true;
            addButton2.Click += addButton2_Click;
            // 
            // deleteButton2
            // 
            deleteButton2.Location = new Point(1286, 338);
            deleteButton2.Name = "deleteButton2";
            deleteButton2.Size = new Size(75, 23);
            deleteButton2.TabIndex = 8;
            deleteButton2.Text = "Delete";
            deleteButton2.UseVisualStyleBackColor = true;
            deleteButton2.Click += deleteButton2_Click;
            // 
            // searchButton1
            // 
            searchButton1.Location = new Point(423, 92);
            searchButton1.Name = "searchButton1";
            searchButton1.Size = new Size(75, 23);
            searchButton1.TabIndex = 9;
            searchButton1.Text = "Search";
            searchButton1.UseVisualStyleBackColor = true;
            searchButton1.Click += searchButton1_Click;
            // 
            // searchButton2
            // 
            searchButton2.Location = new Point(1138, 97);
            searchButton2.Name = "searchButton2";
            searchButton2.Size = new Size(75, 23);
            searchButton2.TabIndex = 10;
            searchButton2.Text = "Search";
            searchButton2.UseVisualStyleBackColor = true;
            searchButton2.Click += searchButton2_Click;
            // 
            // searchBox1
            // 
            searchBox1.Location = new Point(536, 93);
            searchBox1.Name = "searchBox1";
            searchBox1.Size = new Size(124, 23);
            searchBox1.TabIndex = 11;
            // 
            // searchBox2
            // 
            searchBox2.Location = new Point(1242, 98);
            searchBox2.Name = "searchBox2";
            searchBox2.Size = new Size(119, 23);
            searchBox2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 140);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(644, 183);
            dataGridView1.TabIndex = 13;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(717, 140);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(644, 183);
            dataGridView2.TabIndex = 14;
            dataGridView2.DataBindingComplete += myBindingComplete;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1426, 415);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 15;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1513, 450);
            Controls.Add(exitButton);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(searchBox2);
            Controls.Add(searchBox1);
            Controls.Add(searchButton2);
            Controls.Add(searchButton1);
            Controls.Add(deleteButton2);
            Controls.Add(addButton2);
            Controls.Add(modifyButton2);
            Controls.Add(InventoryManagmentLabel);
            Controls.Add(productsLabel);
            Controls.Add(PartsLabel);
            Controls.Add(deleteButton1);
            Controls.Add(modifyButton1);
            Controls.Add(addButton1);
            Name = "Form1";
            Text = "Main Screen";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton1;
        private Button modifyButton1;
        private Button deleteButton1;
        private Label PartsLabel;
        private Label productsLabel;
        private Label InventoryManagmentLabel;
        private Button modifyButton2;
        private Button addButton2;
        private Button deleteButton2;
        private Button searchButton1;
        private Button searchButton2;
        private TextBox searchBox1;
        private TextBox searchBox2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button exitButton;
    }
}
