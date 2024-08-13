namespace Main_Screen
{
    partial class ModifyPart
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
            idBox2 = new TextBox();
            companyoridlabel2 = new Label();
            idorcompanyBox2 = new TextBox();
            cancelButton2 = new Button();
            saveButton2 = new Button();
            maxLabel2 = new Label();
            minLabel2 = new Label();
            minBox2 = new TextBox();
            maxBox2 = new TextBox();
            priceLabel2 = new Label();
            inventoryLabel2 = new Label();
            nameLabel2 = new Label();
            idLabel2 = new Label();
            priceBox2 = new TextBox();
            inventoryBox2 = new TextBox();
            nameBox2 = new TextBox();
            modifyPartLabel = new Label();
            outsourcedButton2 = new RadioButton();
            houseButton2 = new RadioButton();
            SuspendLayout();
            // 
            // idBox2
            // 
            idBox2.AccessibleRole = AccessibleRole.Outline;
            idBox2.Location = new Point(114, 86);
            idBox2.Name = "idBox2";
            idBox2.Size = new Size(135, 23);
            idBox2.TabIndex = 38;
            // 
            // companyoridlabel2
            // 
            companyoridlabel2.AutoSize = true;
            companyoridlabel2.Location = new Point(15, 320);
            companyoridlabel2.Name = "companyoridlabel2";
            companyoridlabel2.Size = new Size(67, 15);
            companyoridlabel2.TabIndex = 37;
            companyoridlabel2.Text = "Machine ID";
            // 
            // idorcompanyBox2
            // 
            idorcompanyBox2.Location = new Point(114, 317);
            idorcompanyBox2.Name = "idorcompanyBox2";
            idorcompanyBox2.Size = new Size(135, 23);
            idorcompanyBox2.TabIndex = 36;
            // 
            // cancelButton2
            // 
            cancelButton2.Location = new Point(298, 390);
            cancelButton2.Name = "cancelButton2";
            cancelButton2.Size = new Size(75, 28);
            cancelButton2.TabIndex = 35;
            cancelButton2.Text = "Cancel";
            cancelButton2.UseVisualStyleBackColor = true;
            // 
            // saveButton2
            // 
            saveButton2.Location = new Point(199, 390);
            saveButton2.Name = "saveButton2";
            saveButton2.Size = new Size(75, 28);
            saveButton2.TabIndex = 34;
            saveButton2.Text = "Save";
            saveButton2.UseVisualStyleBackColor = true;
            // 
            // maxLabel2
            // 
            maxLabel2.AutoSize = true;
            maxLabel2.Location = new Point(67, 264);
            maxLabel2.Name = "maxLabel2";
            maxLabel2.Size = new Size(30, 15);
            maxLabel2.TabIndex = 33;
            maxLabel2.Text = "Max";
            // 
            // minLabel2
            // 
            minLabel2.AutoSize = true;
            minLabel2.Location = new Point(206, 264);
            minLabel2.Name = "minLabel2";
            minLabel2.Size = new Size(28, 15);
            minLabel2.TabIndex = 32;
            minLabel2.Text = "Min";
            // 
            // minBox2
            // 
            minBox2.Location = new Point(240, 261);
            minBox2.Name = "minBox2";
            minBox2.Size = new Size(69, 23);
            minBox2.TabIndex = 31;
            // 
            // maxBox2
            // 
            maxBox2.Location = new Point(114, 261);
            maxBox2.Name = "maxBox2";
            maxBox2.Size = new Size(69, 23);
            maxBox2.TabIndex = 30;
            // 
            // priceLabel2
            // 
            priceLabel2.AutoSize = true;
            priceLabel2.Location = new Point(40, 208);
            priceLabel2.Name = "priceLabel2";
            priceLabel2.Size = new Size(68, 15);
            priceLabel2.TabIndex = 29;
            priceLabel2.Text = "Price / Cost";
            // 
            // inventoryLabel2
            // 
            inventoryLabel2.AutoSize = true;
            inventoryLabel2.Location = new Point(40, 168);
            inventoryLabel2.Name = "inventoryLabel2";
            inventoryLabel2.Size = new Size(57, 15);
            inventoryLabel2.TabIndex = 28;
            inventoryLabel2.Text = "Inventory";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Location = new Point(51, 129);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new Size(39, 15);
            nameLabel2.TabIndex = 27;
            nameLabel2.Text = "Name";
            // 
            // idLabel2
            // 
            idLabel2.AutoSize = true;
            idLabel2.Location = new Point(72, 89);
            idLabel2.Name = "idLabel2";
            idLabel2.Size = new Size(18, 15);
            idLabel2.TabIndex = 26;
            idLabel2.Text = "ID";
            // 
            // priceBox2
            // 
            priceBox2.Location = new Point(114, 208);
            priceBox2.Name = "priceBox2";
            priceBox2.Size = new Size(135, 23);
            priceBox2.TabIndex = 25;
            // 
            // inventoryBox2
            // 
            inventoryBox2.Location = new Point(114, 168);
            inventoryBox2.Name = "inventoryBox2";
            inventoryBox2.Size = new Size(135, 23);
            inventoryBox2.TabIndex = 24;
            // 
            // nameBox2
            // 
            nameBox2.Location = new Point(114, 126);
            nameBox2.Name = "nameBox2";
            nameBox2.Size = new Size(135, 23);
            nameBox2.TabIndex = 23;
            // 
            // modifyPartLabel
            // 
            modifyPartLabel.AutoSize = true;
            modifyPartLabel.Location = new Point(10, 35);
            modifyPartLabel.Name = "modifyPartLabel";
            modifyPartLabel.Size = new Size(69, 15);
            modifyPartLabel.TabIndex = 22;
            modifyPartLabel.Text = "Modfiy Part";
            modifyPartLabel.Click += addPartLabel_Click;
            // 
            // outsourcedButton2
            // 
            outsourcedButton2.AutoSize = true;
            outsourcedButton2.Location = new Point(199, 33);
            outsourcedButton2.Name = "outsourcedButton2";
            outsourcedButton2.Size = new Size(87, 19);
            outsourcedButton2.TabIndex = 21;
            outsourcedButton2.TabStop = true;
            outsourcedButton2.Text = "Outsourced";
            outsourcedButton2.UseVisualStyleBackColor = true;
            outsourcedButton2.CheckedChanged += outsourcedButton2_CheckedChanged;
            // 
            // houseButton2
            // 
            houseButton2.AutoSize = true;
            houseButton2.Location = new Point(85, 33);
            houseButton2.Name = "houseButton2";
            houseButton2.Size = new Size(74, 19);
            houseButton2.TabIndex = 20;
            houseButton2.TabStop = true;
            houseButton2.Text = "In-House";
            houseButton2.UseVisualStyleBackColor = true;
            houseButton2.CheckedChanged += houseButton2_CheckedChanged;
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 450);
            Controls.Add(idBox2);
            Controls.Add(companyoridlabel2);
            Controls.Add(idorcompanyBox2);
            Controls.Add(cancelButton2);
            Controls.Add(saveButton2);
            Controls.Add(maxLabel2);
            Controls.Add(minLabel2);
            Controls.Add(minBox2);
            Controls.Add(maxBox2);
            Controls.Add(priceLabel2);
            Controls.Add(inventoryLabel2);
            Controls.Add(nameLabel2);
            Controls.Add(idLabel2);
            Controls.Add(priceBox2);
            Controls.Add(inventoryBox2);
            Controls.Add(nameBox2);
            Controls.Add(modifyPartLabel);
            Controls.Add(outsourcedButton2);
            Controls.Add(houseButton2);
            Name = "ModifyPart";
            Text = "ModifyPart";
            Load += ModifyPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idBox2;
        private Label companyoridlabel2;
        private TextBox idorcompanyBox2;
        private Button cancelButton2;
        private Button saveButton2;
        private Label maxLabel2;
        private Label minLabel2;
        private TextBox minBox2;
        private TextBox maxBox2;
        private Label priceLabel2;
        private Label inventoryLabel2;
        private Label nameLabel2;
        private Label idLabel2;
        private TextBox priceBox2;
        private TextBox inventoryBox2;
        private TextBox nameBox2;
        private Label modifyPartLabel;
        private RadioButton outsourcedButton2;
        private RadioButton houseButton2;
    }
}