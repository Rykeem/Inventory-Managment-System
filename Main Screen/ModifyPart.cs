using Main_Screen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Screen
{
    public partial class ModifyPart : Form
    {
        private Inventory _inventory;
        private int _index;
        public ModifyPart(int index, Part part, Inventory inventory)
        {
            InitializeComponent();
            _inventory = inventory;
            idBox2.ReadOnly = true;
            idBox2.Text = part.PartID.ToString();
            nameBox2.Text = part.Name;
            inventoryBox2.Text = part.InStock.ToString();
            priceBox2.Text = part.Price.ToString();
            maxBox2.Text = part.Max.ToString();
            minBox2.Text = part.Min.ToString();

            this._index = index;

            if (part is Inhouse)
            {
                houseButton2.Checked = true;
                idorcompanyBox2.Text = ((Inhouse)part).MachineID.ToString();
            }
            else if (part is Outsourced)
            {
                outsourcedButton2.Checked = true;
                idorcompanyBox2.Text = ((Outsourced)part).CompanyName;
            }
        }

        private void addAddPartLabel_Click(object sender, EventArgs e)
        {

        }

        private void houseButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (houseButton2.Checked)
            {
                companyoridlabel2.Text = "MachineID";

                if (string.IsNullOrWhiteSpace(idorcompanyBox2.Text) || !int.TryParse(idorcompanyBox2.Text, out int almostDone))
                {
                    idorcompanyBox2.BackColor = Color.Red;
                    //saveButton.Enabled = false;

                }
                else
                {
                    idorcompanyBox2.BackColor = Color.White;
                }
                SaveButton();
            }

        }

        private void outsourcedButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (outsourcedButton2.Checked)
            {
                companyoridlabel2.Text = "CompanyName";
                if (string.IsNullOrWhiteSpace(idorcompanyBox2.Text))
                {
                    idorcompanyBox2.BackColor = Color.Red;
                    //saveButton.Enabled = false;

                }
                else
                {
                    {
                        idorcompanyBox2.BackColor = Color.White;

                    }
                    SaveButton();
                }
            }
        }

        private void ModifyAddPart_Load(object sender, EventArgs e)
        {


        }

        private void saveButton2_Click(object sender, EventArgs e)

        {

            if (int.Parse(maxBox2.Text) < int.Parse(inventoryBox2.Text) || int.Parse(inventoryBox2.Text) < int.Parse(minBox2.Text))
            { MessageBox.Show("Inventory is out of bounds"); }
            if (int.Parse(maxBox2.Text) < int.Parse(minBox2.Text))
            {
                MessageBox.Show("Min can not be greater than max");
            }
            if (int.Parse(maxBox2.Text) >= int.Parse(inventoryBox2.Text) && int.Parse(maxBox2.Text) >= int.Parse(inventoryBox2.Text) && (int.Parse(maxBox2.Text) > int.Parse(minBox2.Text)))
            {
                {
                    if (companyoridlabel2.Text == "MachineID")
                    {
                        Inhouse tempPart = new Inhouse(
                        0,
                        nameBox2.Text,
                        int.Parse(inventoryBox2.Text),
                        decimal.Parse(priceBox2.Text),
                        int.Parse(minBox2.Text),
                        int.Parse(maxBox2.Text),
                        int.Parse(idorcompanyBox2.Text))
                        ;
                        _inventory.updatePart(_index,tempPart);
                       
                        this.Close();
                        Form1.Instance?.Show();
                    }
                    if (companyoridlabel2.Text == "CompanyName")
                    {
                        Outsourced tempPart = new Outsourced(
                        0,
                        nameBox2.Text,
                        int.Parse(inventoryBox2.Text),
                        decimal.Parse(priceBox2.Text),
                        int.Parse(minBox2.Text),
                        int.Parse(maxBox2.Text),
                        idorcompanyBox2.Text
                        );
                        _inventory.updatePart(_index,tempPart);
                        
                        this.Close();
                        Form1.Instance?.Show();
                    }

                    
                }
            }

        }

        private void cancelButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Instance.Show();
        }
        private void SaveButton()
        {

            if (nameBox2.BackColor == Color.White &&
            inventoryBox2.BackColor == Color.White &&
            priceBox2.BackColor == Color.White &&
            maxBox2.BackColor == Color.White &&
            minBox2.BackColor == Color.White &&
            idorcompanyBox2.BackColor == Color.White)
            {
                saveButton2.Enabled = true;
            }
            else { saveButton2.Enabled = false; }
        }
        private void nameBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox2.Text) || int.TryParse(nameBox2.Text, out int almostDone))
            {
                nameBox2.BackColor = Color.Red;
                saveButton2.Enabled = false;
            }
            else
            {
                nameBox2.BackColor = Color.White;
            }
            SaveButton();
        }

        private void inventoryBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryBox2.Text) || !int.TryParse(inventoryBox2.Text, out int almostDone))
            {
                inventoryBox2.BackColor = Color.Red;
                saveButton2.Enabled = false;
            }
            else
            {
                inventoryBox2.BackColor = Color.White;
            }
            SaveButton();
        }

        private void priceBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceBox2.Text) || !decimal.TryParse(priceBox2.Text, out decimal almostDone))
            { priceBox2.BackColor = Color.Red; saveButton2.Enabled = false; }
            else
            { priceBox2.BackColor = Color.White; }
            SaveButton();
        }

        private void maxBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maxBox2.Text) || !int.TryParse(maxBox2.Text, out int almostDone))
            { maxBox2.BackColor = Color.Red; saveButton2.Enabled = false; }
            else
            { maxBox2.BackColor = Color.White; }
            SaveButton();
        }

        private void minBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minBox2.Text) || !int.TryParse(minBox2.Text, out int almostDone))
            {
                minBox2.BackColor = Color.Red;
                saveButton2.Enabled = false;
            }
            else
            { minBox2.BackColor = Color.White; }
            SaveButton();
        }

        private void idorcompanyBox2_TextChanged(object sender, EventArgs e)
        {
            if (companyoridlabel2.Text == "MachineID")
            {
                if (string.IsNullOrWhiteSpace(idorcompanyBox2.Text) || !int.TryParse(idorcompanyBox2.Text, out int almostDone))
                {
                    idorcompanyBox2.BackColor = Color.Red;
                    saveButton2.Enabled = false;

                }
                else
                {
                    idorcompanyBox2.BackColor = Color.White;
                }
            }
            else if (companyoridlabel2.Text == "CompanyName")
            {
                if (string.IsNullOrWhiteSpace(idorcompanyBox2.Text))
                {
                    idorcompanyBox2.BackColor = Color.Red;
                    saveButton2.Enabled = false;

                }
                else
                {
                    idorcompanyBox2.BackColor = Color.White;

                }

            }
            SaveButton();
        }
        }
    }

