namespace Main_Screen
{
    partial class AddProduct
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
            addProductLabel = new Label();
            idBox3 = new TextBox();
            maxLabel3 = new Label();
            minLabel3 = new Label();
            minBox3 = new TextBox();
            maxBox3 = new TextBox();
            priceLabel3 = new Label();
            inventoryLabel3 = new Label();
            nameLabel3 = new Label();
            idLabel3 = new Label();
            priceBox3 = new TextBox();
            inventoryBox3 = new TextBox();
            nameBox3 = new TextBox();
            dataGridView3 = new DataGridView();
            partID3 = new DataGridViewTextBoxColumn();
            name3 = new DataGridViewTextBoxColumn();
            inventory3 = new DataGridViewTextBoxColumn();
            price3 = new DataGridViewTextBoxColumn();
            min3 = new DataGridViewTextBoxColumn();
            max3 = new DataGridViewTextBoxColumn();
            dataGridView4 = new DataGridView();
            partID4 = new DataGridViewTextBoxColumn();
            name4 = new DataGridViewTextBoxColumn();
            inventory4 = new DataGridViewTextBoxColumn();
            price4 = new DataGridViewTextBoxColumn();
            min4 = new DataGridViewTextBoxColumn();
            max4 = new DataGridViewTextBoxColumn();
            saveButton3 = new Button();
            cancelButton3 = new Button();
            deleteButton3 = new Button();
            addButton3 = new Button();
            partsLabel3 = new Label();
            partsLabel4 = new Label();
            searchBox3 = new TextBox();
            searchButton3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.Location = new Point(28, 27);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(74, 15);
            addProductLabel.TabIndex = 0;
            addProductLabel.Text = "Add Product";
            // 
            // idBox3
            // 
            idBox3.AccessibleRole = AccessibleRole.Outline;
            idBox3.Location = new Point(119, 111);
            idBox3.Name = "idBox3";
            idBox3.Size = new Size(135, 23);
            idBox3.TabIndex = 31;
            // 
            // maxLabel3
            // 
            maxLabel3.AutoSize = true;
            maxLabel3.Location = new Point(45, 273);
            maxLabel3.Name = "maxLabel3";
            maxLabel3.Size = new Size(30, 15);
            maxLabel3.TabIndex = 30;
            maxLabel3.Text = "Max";
            // 
            // minLabel3
            // 
            minLabel3.AutoSize = true;
            minLabel3.Location = new Point(194, 274);
            minLabel3.Name = "minLabel3";
            minLabel3.Size = new Size(28, 15);
            minLabel3.TabIndex = 29;
            minLabel3.Text = "Min";
            // 
            // minBox3
            // 
            minBox3.Location = new Point(236, 271);
            minBox3.Name = "minBox3";
            minBox3.Size = new Size(69, 23);
            minBox3.TabIndex = 28;
            // 
            // maxBox3
            // 
            maxBox3.Location = new Point(119, 271);
            maxBox3.Name = "maxBox3";
            maxBox3.Size = new Size(69, 23);
            maxBox3.TabIndex = 27;
            // 
            // priceLabel3
            // 
            priceLabel3.AutoSize = true;
            priceLabel3.Location = new Point(45, 237);
            priceLabel3.Name = "priceLabel3";
            priceLabel3.Size = new Size(33, 15);
            priceLabel3.TabIndex = 26;
            priceLabel3.Text = "Price";
            // 
            // inventoryLabel3
            // 
            inventoryLabel3.AutoSize = true;
            inventoryLabel3.Location = new Point(45, 202);
            inventoryLabel3.Name = "inventoryLabel3";
            inventoryLabel3.Size = new Size(57, 15);
            inventoryLabel3.TabIndex = 25;
            inventoryLabel3.Text = "Inventory";
            // 
            // nameLabel3
            // 
            nameLabel3.AutoSize = true;
            nameLabel3.Location = new Point(45, 159);
            nameLabel3.Name = "nameLabel3";
            nameLabel3.Size = new Size(39, 15);
            nameLabel3.TabIndex = 24;
            nameLabel3.Text = "Name";
            // 
            // idLabel3
            // 
            idLabel3.AutoSize = true;
            idLabel3.Location = new Point(45, 114);
            idLabel3.Name = "idLabel3";
            idLabel3.Size = new Size(18, 15);
            idLabel3.TabIndex = 23;
            idLabel3.Text = "ID";
            // 
            // priceBox3
            // 
            priceBox3.Location = new Point(119, 234);
            priceBox3.Name = "priceBox3";
            priceBox3.Size = new Size(135, 23);
            priceBox3.TabIndex = 22;
            // 
            // inventoryBox3
            // 
            inventoryBox3.Location = new Point(119, 199);
            inventoryBox3.Name = "inventoryBox3";
            inventoryBox3.Size = new Size(135, 23);
            inventoryBox3.TabIndex = 21;
            // 
            // nameBox3
            // 
            nameBox3.Location = new Point(119, 156);
            nameBox3.Name = "nameBox3";
            nameBox3.Size = new Size(135, 23);
            nameBox3.TabIndex = 20;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { partID3, name3, inventory3, price3, min3, max3 });
            dataGridView3.Location = new Point(619, 92);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(643, 183);
            dataGridView3.TabIndex = 32;
            // 
            // partID3
            // 
            partID3.HeaderText = "Part ID";
            partID3.Name = "partID3";
            // 
            // name3
            // 
            name3.HeaderText = "Name";
            name3.Name = "name3";
            // 
            // inventory3
            // 
            inventory3.HeaderText = "Inventory";
            inventory3.Name = "inventory3";
            // 
            // price3
            // 
            price3.HeaderText = "Price";
            price3.Name = "price3";
            // 
            // min3
            // 
            min3.HeaderText = "Min";
            min3.Name = "min3";
            // 
            // max3
            // 
            max3.HeaderText = "Max";
            max3.Name = "max3";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { partID4, name4, inventory4, price4, min4, max4 });
            dataGridView4.Location = new Point(619, 402);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(643, 183);
            dataGridView4.TabIndex = 33;
            // 
            // partID4
            // 
            partID4.HeaderText = "Part ID";
            partID4.Name = "partID4";
            // 
            // name4
            // 
            name4.HeaderText = "Name";
            name4.Name = "name4";
            // 
            // inventory4
            // 
            inventory4.HeaderText = "Inventory";
            inventory4.Name = "inventory4";
            // 
            // price4
            // 
            price4.HeaderText = "Price";
            price4.Name = "price4";
            // 
            // min4
            // 
            min4.HeaderText = "Min";
            min4.Name = "min4";
            // 
            // max4
            // 
            max4.HeaderText = "Max";
            max4.Name = "max4";
            // 
            // saveButton3
            // 
            saveButton3.Location = new Point(1117, 665);
            saveButton3.Name = "saveButton3";
            saveButton3.Size = new Size(75, 28);
            saveButton3.TabIndex = 35;
            saveButton3.Text = "Save";
            saveButton3.UseVisualStyleBackColor = true;
            // 
            // cancelButton3
            // 
            cancelButton3.Location = new Point(1232, 665);
            cancelButton3.Name = "cancelButton3";
            cancelButton3.Size = new Size(75, 28);
            cancelButton3.TabIndex = 36;
            cancelButton3.Text = "Cancel";
            cancelButton3.UseVisualStyleBackColor = true;
            // 
            // deleteButton3
            // 
            deleteButton3.Location = new Point(1232, 613);
            deleteButton3.Name = "deleteButton3";
            deleteButton3.Size = new Size(75, 23);
            deleteButton3.TabIndex = 37;
            deleteButton3.Text = "Delete";
            deleteButton3.UseVisualStyleBackColor = true;
            // 
            // addButton3
            // 
            addButton3.Location = new Point(1187, 310);
            addButton3.Name = "addButton3";
            addButton3.Size = new Size(75, 23);
            addButton3.TabIndex = 38;
            addButton3.Text = "Add";
            addButton3.UseVisualStyleBackColor = true;
            // 
            // partsLabel3
            // 
            partsLabel3.AutoSize = true;
            partsLabel3.Location = new Point(619, 60);
            partsLabel3.Name = "partsLabel3";
            partsLabel3.Size = new Size(105, 15);
            partsLabel3.TabIndex = 39;
            partsLabel3.Text = "All candidate Parts";
            // 
            // partsLabel4
            // 
            partsLabel4.AutoSize = true;
            partsLabel4.Location = new Point(619, 371);
            partsLabel4.Name = "partsLabel4";
            partsLabel4.Size = new Size(186, 15);
            partsLabel4.TabIndex = 40;
            partsLabel4.Text = "Parts Associated with this Product";
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(1083, 42);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(179, 23);
            searchBox3.TabIndex = 42;
            // 
            // searchButton3
            // 
            searchButton3.Location = new Point(970, 41);
            searchButton3.Name = "searchButton3";
            searchButton3.Size = new Size(75, 23);
            searchButton3.TabIndex = 41;
            searchButton3.Text = "Search";
            searchButton3.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 750);
            Controls.Add(searchBox3);
            Controls.Add(searchButton3);
            Controls.Add(partsLabel4);
            Controls.Add(partsLabel3);
            Controls.Add(addButton3);
            Controls.Add(deleteButton3);
            Controls.Add(cancelButton3);
            Controls.Add(saveButton3);
            Controls.Add(dataGridView3);
            Controls.Add(idBox3);
            Controls.Add(maxLabel3);
            Controls.Add(minLabel3);
            Controls.Add(minBox3);
            Controls.Add(maxBox3);
            Controls.Add(priceLabel3);
            Controls.Add(inventoryLabel3);
            Controls.Add(nameLabel3);
            Controls.Add(idLabel3);
            Controls.Add(priceBox3);
            Controls.Add(inventoryBox3);
            Controls.Add(nameBox3);
            Controls.Add(addProductLabel);
            Controls.Add(dataGridView4);
            Name = "AddProduct";
            Text = "Add Product";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addProductLabel;
        private TextBox idBox3;
        private Label maxLabel3;
        private Label minLabel3;
        private TextBox minBox3;
        private TextBox maxBox3;
        private Label priceLabel3;
        private Label inventoryLabel3;
        private Label nameLabel3;
        private Label idLabel3;
        private TextBox priceBox3;
        private TextBox inventoryBox3;
        private TextBox nameBox3;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn partID3;
        private DataGridViewTextBoxColumn name3;
        private DataGridViewTextBoxColumn inventory3;
        private DataGridViewTextBoxColumn price3;
        private DataGridViewTextBoxColumn min3;
        private DataGridViewTextBoxColumn max3;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn partID4;
        private DataGridViewTextBoxColumn name4;
        private DataGridViewTextBoxColumn inventory4;
        private DataGridViewTextBoxColumn price4;
        private DataGridViewTextBoxColumn min4;
        private DataGridViewTextBoxColumn max4;
        private Button saveButton3;
        private Button cancelButton3;
        private Button deleteButton3;
        private Button addButton3;
        private Label partsLabel3;
        private Label partsLabel4;
        private TextBox searchBox3;
        private Button searchButton3;
    }
}