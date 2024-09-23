namespace Main_Screen
{
    partial class ModifyProduct
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
            searchBox4 = new TextBox();
            searchButton4 = new Button();
            PartsLabel4 = new Label();
            AddPartsLabel3 = new Label();
            addButton4 = new Button();
            deleteButton4 = new Button();
            cancelButton4 = new Button();
            saveButton4 = new Button();
            dataGridView5 = new DataGridView();
            idBox4 = new TextBox();
            maxLabel4 = new Label();
            minLabel4 = new Label();
            minBox4 = new TextBox();
            maxBox4 = new TextBox();
            priceLabel4 = new Label();
            inventoryLabel4 = new Label();
            nameLabel4 = new Label();
            idLabel4 = new Label();
            priceBox4 = new TextBox();
            inventoryBox4 = new TextBox();
            nameBox4 = new TextBox();
            modifyProductLabel = new Label();
            dataGridView6 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            SuspendLayout();
            // 
            // searchBox4
            // 
            searchBox4.Location = new Point(1079, 38);
            searchBox4.Name = "searchBox4";
            searchBox4.Size = new Size(179, 23);
            searchBox4.TabIndex = 65;
            // 
            // searchButton4
            // 
            searchButton4.Location = new Point(966, 37);
            searchButton4.Name = "searchButton4";
            searchButton4.Size = new Size(75, 23);
            searchButton4.TabIndex = 64;
            searchButton4.Text = "Search";
            searchButton4.UseVisualStyleBackColor = true;
            searchButton4.Click += searchButton4_Click;
            // 
            // PartsLabel4
            // 
            PartsLabel4.AutoSize = true;
            PartsLabel4.Location = new Point(615, 367);
            PartsLabel4.Name = "PartsLabel4";
            PartsLabel4.Size = new Size(186, 15);
            PartsLabel4.TabIndex = 63;
            PartsLabel4.Text = "Parts Associated with this Product";
            // 
            // AddPartsLabel3
            // 
            AddPartsLabel3.AutoSize = true;
            AddPartsLabel3.Location = new Point(615, 56);
            AddPartsLabel3.Name = "AddPartsLabel3";
            AddPartsLabel3.Size = new Size(127, 15);
            AddPartsLabel3.TabIndex = 62;
            AddPartsLabel3.Text = "All candidate AddParts";
            // 
            // addButton4
            // 
            addButton4.Location = new Point(1183, 306);
            addButton4.Name = "addButton4";
            addButton4.Size = new Size(75, 23);
            addButton4.TabIndex = 61;
            addButton4.Text = "Add";
            addButton4.UseVisualStyleBackColor = true;
            addButton4.Click += addButton4_Click;
            // 
            // deleteButton4
            // 
            deleteButton4.Location = new Point(1228, 609);
            deleteButton4.Name = "deleteButton4";
            deleteButton4.Size = new Size(75, 23);
            deleteButton4.TabIndex = 60;
            deleteButton4.Text = "Delete";
            deleteButton4.UseVisualStyleBackColor = true;
            deleteButton4.Click += deleteButton4_Click;
            // 
            // cancelButton4
            // 
            cancelButton4.Location = new Point(1228, 661);
            cancelButton4.Name = "cancelButton4";
            cancelButton4.Size = new Size(75, 28);
            cancelButton4.TabIndex = 59;
            cancelButton4.Text = "Cancel";
            cancelButton4.UseVisualStyleBackColor = true;
            cancelButton4.Click += cancelButton4_Click;
            // 
            // saveButton4
            // 
            saveButton4.Location = new Point(1113, 661);
            saveButton4.Name = "saveButton4";
            saveButton4.Size = new Size(75, 28);
            saveButton4.TabIndex = 58;
            saveButton4.Text = "Save";
            saveButton4.UseVisualStyleBackColor = true;
            saveButton4.Click += saveButton4_Click;
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(615, 88);
            dataGridView5.MultiSelect = false;
            dataGridView5.Name = "dataGridView5";
            dataGridView5.ReadOnly = true;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.Size = new Size(643, 183);
            dataGridView5.TabIndex = 56;
            // 
            // idBox4
            // 
            idBox4.AccessibleRole = AccessibleRole.Outline;
            idBox4.Location = new Point(115, 107);
            idBox4.Name = "idBox4";
            idBox4.Size = new Size(135, 23);
            idBox4.TabIndex = 55;
            // 
            // maxLabel4
            // 
            maxLabel4.AutoSize = true;
            maxLabel4.Location = new Point(41, 269);
            maxLabel4.Name = "maxLabel4";
            maxLabel4.Size = new Size(30, 15);
            maxLabel4.TabIndex = 54;
            maxLabel4.Text = "Max";
            // 
            // minLabel4
            // 
            minLabel4.AutoSize = true;
            minLabel4.Location = new Point(190, 270);
            minLabel4.Name = "minLabel4";
            minLabel4.Size = new Size(28, 15);
            minLabel4.TabIndex = 53;
            minLabel4.Text = "Min";
            // 
            // minBox4
            // 
            minBox4.Location = new Point(232, 267);
            minBox4.Name = "minBox4";
            minBox4.Size = new Size(69, 23);
            minBox4.TabIndex = 52;
            minBox4.TextChanged += minBox4_TextChanged;
            // 
            // maxBox4
            // 
            maxBox4.Location = new Point(115, 267);
            maxBox4.Name = "maxBox4";
            maxBox4.Size = new Size(69, 23);
            maxBox4.TabIndex = 51;
            maxBox4.TextChanged += maxBox4_TextChanged;
            // 
            // priceLabel4
            // 
            priceLabel4.AutoSize = true;
            priceLabel4.Location = new Point(41, 233);
            priceLabel4.Name = "priceLabel4";
            priceLabel4.Size = new Size(33, 15);
            priceLabel4.TabIndex = 50;
            priceLabel4.Text = "Price";
            // 
            // inventoryLabel4
            // 
            inventoryLabel4.AutoSize = true;
            inventoryLabel4.Location = new Point(41, 198);
            inventoryLabel4.Name = "inventoryLabel4";
            inventoryLabel4.Size = new Size(57, 15);
            inventoryLabel4.TabIndex = 49;
            inventoryLabel4.Text = "Inventory";
            // 
            // nameLabel4
            // 
            nameLabel4.AutoSize = true;
            nameLabel4.Location = new Point(41, 155);
            nameLabel4.Name = "nameLabel4";
            nameLabel4.Size = new Size(39, 15);
            nameLabel4.TabIndex = 48;
            nameLabel4.Text = "Name";
            // 
            // idLabel4
            // 
            idLabel4.AutoSize = true;
            idLabel4.Location = new Point(41, 110);
            idLabel4.Name = "idLabel4";
            idLabel4.Size = new Size(18, 15);
            idLabel4.TabIndex = 47;
            idLabel4.Text = "ID";
            // 
            // priceBox4
            // 
            priceBox4.Location = new Point(115, 230);
            priceBox4.Name = "priceBox4";
            priceBox4.Size = new Size(135, 23);
            priceBox4.TabIndex = 46;
            priceBox4.TextChanged += priceBox4_TextChanged;
            // 
            // inventoryBox4
            // 
            inventoryBox4.Location = new Point(115, 195);
            inventoryBox4.Name = "inventoryBox4";
            inventoryBox4.Size = new Size(135, 23);
            inventoryBox4.TabIndex = 45;
            inventoryBox4.TextChanged += inventoryBox4_TextChanged;
            // 
            // nameBox4
            // 
            nameBox4.Location = new Point(115, 152);
            nameBox4.Name = "nameBox4";
            nameBox4.Size = new Size(135, 23);
            nameBox4.TabIndex = 44;
            nameBox4.TextChanged += nameBox4_TextChanged;
            // 
            // modifyProductLabel
            // 
            modifyProductLabel.AutoSize = true;
            modifyProductLabel.Location = new Point(24, 23);
            modifyProductLabel.Name = "modifyProductLabel";
            modifyProductLabel.Size = new Size(90, 15);
            modifyProductLabel.TabIndex = 43;
            modifyProductLabel.Text = "Modify Product";
            // 
            // dataGridView6
            // 
            dataGridView6.AllowUserToAddRows = false;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(615, 398);
            dataGridView6.MultiSelect = false;
            dataGridView6.Name = "dataGridView6";
            dataGridView6.ReadOnly = true;
            dataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView6.Size = new Size(643, 183);
            dataGridView6.TabIndex = 57;
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 750);
            Controls.Add(searchBox4);
            Controls.Add(searchButton4);
            Controls.Add(PartsLabel4);
            Controls.Add(AddPartsLabel3);
            Controls.Add(addButton4);
            Controls.Add(deleteButton4);
            Controls.Add(cancelButton4);
            Controls.Add(saveButton4);
            Controls.Add(dataGridView5);
            Controls.Add(idBox4);
            Controls.Add(maxLabel4);
            Controls.Add(minLabel4);
            Controls.Add(minBox4);
            Controls.Add(maxBox4);
            Controls.Add(priceLabel4);
            Controls.Add(inventoryLabel4);
            Controls.Add(nameLabel4);
            Controls.Add(idLabel4);
            Controls.Add(priceBox4);
            Controls.Add(inventoryBox4);
            Controls.Add(nameBox4);
            Controls.Add(modifyProductLabel);
            Controls.Add(dataGridView6);
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            Load += ModifyProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox4;
        private Button searchButton4;
        private Label PartsLabel4;
        private Label AddPartsLabel3;
        private Button addButton4;
        private Button deleteButton4;
        private Button cancelButton4;
        private Button saveButton4;
        private DataGridView dataGridView5;
        private TextBox idBox4;
        private Label maxLabel4;
        private Label minLabel4;
        private TextBox minBox4;
        private TextBox maxBox4;
        private Label priceLabel4;
        private Label inventoryLabel4;
        private Label nameLabel4;
        private Label idLabel4;
        private TextBox priceBox4;
        private TextBox inventoryBox4;
        private TextBox nameBox4;
        private Label modifyProductLabel;
        private DataGridView dataGridView6;
    }
}