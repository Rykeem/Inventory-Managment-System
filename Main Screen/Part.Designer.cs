namespace Main_Screen
{
    partial class Part
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
            houseButton = new RadioButton();
            outsourcedButton = new RadioButton();
            addPartLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            idBox = new TextBox();
            nameBox = new TextBox();
            priceBox = new TextBox();
            inventoryBox = new TextBox();
            idLabel = new Label();
            nameLabel = new Label();
            inventoryLabel = new Label();
            priceLabel = new Label();
            maxBox = new TextBox();
            minBox = new TextBox();
            minLabel = new Label();
            maxLabel = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // houseButton
            // 
            houseButton.AutoSize = true;
            houseButton.Location = new Point(88, 25);
            houseButton.Name = "houseButton";
            houseButton.Size = new Size(74, 19);
            houseButton.TabIndex = 0;
            houseButton.TabStop = true;
            houseButton.Text = "In-House";
            houseButton.UseVisualStyleBackColor = true;
            // 
            // outsourcedButton
            // 
            outsourcedButton.AutoSize = true;
            outsourcedButton.Location = new Point(202, 25);
            outsourcedButton.Name = "outsourcedButton";
            outsourcedButton.Size = new Size(87, 19);
            outsourcedButton.TabIndex = 1;
            outsourcedButton.TabStop = true;
            outsourcedButton.Text = "Outsourced";
            outsourcedButton.UseVisualStyleBackColor = true;
            // 
            // addPartLabel
            // 
            addPartLabel.AutoSize = true;
            addPartLabel.Location = new Point(18, 25);
            addPartLabel.Name = "addPartLabel";
            addPartLabel.Size = new Size(53, 15);
            addPartLabel.TabIndex = 2;
            addPartLabel.Text = "Add Part";
            // 
            // idBox
            // 
            idBox.Location = new Point(117, 78);
            idBox.Name = "idBox";
            idBox.Size = new Size(135, 23);
            idBox.TabIndex = 3;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(117, 118);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(135, 23);
            nameBox.TabIndex = 4;
            nameBox.TextChanged += textBox2_TextChanged;
            // 
            // priceBox
            // 
            priceBox.Location = new Point(117, 200);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(135, 23);
            priceBox.TabIndex = 6;
            // 
            // inventoryBox
            // 
            inventoryBox.Location = new Point(117, 160);
            inventoryBox.Name = "inventoryBox";
            inventoryBox.Size = new Size(135, 23);
            inventoryBox.TabIndex = 5;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(75, 81);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(18, 15);
            idLabel.TabIndex = 7;
            idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(54, 121);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.Location = new Point(43, 160);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(57, 15);
            inventoryLabel.TabIndex = 9;
            inventoryLabel.Text = "Inventory";
            inventoryLabel.Click += label4_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(43, 200);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(68, 15);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "Price / Cost";
            // 
            // maxBox
            // 
            maxBox.Location = new Point(117, 253);
            maxBox.Name = "maxBox";
            maxBox.Size = new Size(69, 23);
            maxBox.TabIndex = 11;
            // 
            // minBox
            // 
            minBox.Location = new Point(243, 253);
            minBox.Name = "minBox";
            minBox.Size = new Size(69, 23);
            minBox.TabIndex = 12;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Location = new Point(209, 256);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(28, 15);
            minLabel.TabIndex = 13;
            minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Location = new Point(70, 256);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(30, 15);
            maxLabel.TabIndex = 14;
            maxLabel.Text = "Max";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(202, 382);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 28);
            saveButton.TabIndex = 15;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(301, 382);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 28);
            cancelButton.TabIndex = 16;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // Part
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 450);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(maxLabel);
            Controls.Add(minLabel);
            Controls.Add(minBox);
            Controls.Add(maxBox);
            Controls.Add(priceLabel);
            Controls.Add(inventoryLabel);
            Controls.Add(nameLabel);
            Controls.Add(idLabel);
            Controls.Add(priceBox);
            Controls.Add(inventoryBox);
            Controls.Add(nameBox);
            Controls.Add(idBox);
            Controls.Add(addPartLabel);
            Controls.Add(outsourcedButton);
            Controls.Add(houseButton);
            Name = "Part";
            Text = "Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton houseButton;
        private RadioButton outsourcedButton;
        private Label addPartLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox idBox;
        private TextBox nameBox;
        private TextBox priceBox;
        private TextBox inventoryBox;
        private Label idLabel;
        private Label nameLabel;
        private Label inventoryLabel;
        private Label priceLabel;
        private TextBox maxBox;
        private TextBox minBox;
        private Label minLabel;
        private Label maxLabel;
        private Button saveButton;
        private Button cancelButton;
    }
}