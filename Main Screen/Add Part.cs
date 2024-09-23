using Main_Screen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Main_Screen.Models.Inventory;

namespace Main_Screen
{
    public partial class AddPart : Form
    {
        private Inventory _inventory;

        public AddPart(Inventory inventory)
        {
            InitializeComponent();
            _inventory = inventory;
            idBox1.Text = inventory._id1.ToString();
            idBox1.ReadOnly = true;


        }


        private void houseButton_CheckedChanged(object sender, EventArgs e)
        {
            companyoridlabel.Text = "MachineID";

            if (string.IsNullOrWhiteSpace(idorcompanyBox.Text) || !int.TryParse(idorcompanyBox.Text, out int almostDone))
            {
                idorcompanyBox.BackColor = Color.Red;
                //saveButton.Enabled = false;

            }
            else
            {
                idorcompanyBox.BackColor = Color.White;
            }
                SaveButton();
        }

        private void outsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            companyoridlabel.Text = "CompanyName";
            if (string.IsNullOrWhiteSpace(idorcompanyBox.Text))
            {
                idorcompanyBox.BackColor = Color.Red;
                //saveButton.Enabled = false;

            }
            else
            {
                {
                    idorcompanyBox.BackColor = Color.White;

                }
                SaveButton();
            }
        }




        public void saveButton_Click(object sender, EventArgs e)
        {
            if(int.Parse(maxBox.Text) < int.Parse(inventoryBox.Text) || int.Parse(inventoryBox.Text) < int.Parse(minBox.Text))
            { MessageBox.Show("Inventory is out of bounds");}
            if (int.Parse(maxBox.Text) < int.Parse(minBox.Text))
            {
                MessageBox.Show("Min can not be greater than max");
            }
            if (int.Parse(maxBox.Text) >= int.Parse(inventoryBox.Text) && int.Parse(inventoryBox.Text) >= int.Parse(minBox.Text) && (int.Parse(maxBox.Text) > int.Parse(minBox.Text)))
            {
                
                    if (companyoridlabel.Text == "MachineID")
                    {
                        Inhouse tempPart = new Inhouse(
                        0,
                        nameBox.Text,
                        int.Parse(inventoryBox.Text),
                        decimal.Parse(priceBox.Text),
                        int.Parse(minBox.Text),
                        int.Parse(maxBox.Text),
                        int.Parse(idorcompanyBox.Text))
                        ;
                        _inventory.addPart(tempPart);
                        Form1.Instance?.UpdateGrid1(_inventory);
                        this.Close();
                        Form1.Instance?.Show();
                    }
                    if (companyoridlabel.Text == "CompanyName")
                    {
                        Outsourced tempPart = new Outsourced(
                        0,
                        nameBox.Text,
                        int.Parse(inventoryBox.Text),
                        decimal.Parse(priceBox.Text),
                        int.Parse(minBox.Text),
                        int.Parse(maxBox.Text),
                        idorcompanyBox.Text
                        );
                        _inventory.addPart(tempPart);
                        Form1.Instance?.UpdateGrid1(_inventory);
                        this.Close();
                        Form1.Instance?.Show();
                    }

                    
                
            }


            

        }

        private void AddPart_Load(object sender, EventArgs e)
        {



        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Instance.Show();
        }




        private void SaveButton()
        {
            
            if (nameBox.BackColor == Color.White &&
            inventoryBox.BackColor == Color.White &&
            priceBox.BackColor == Color.White &&
            maxBox.BackColor == Color.White &&
            minBox.BackColor == Color.White &&
            idorcompanyBox.BackColor == Color.White)
            {
                saveButton.Enabled = true;
            }
            else { saveButton.Enabled = false; }    
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) || int.TryParse(nameBox.Text, out int almostDone))
            {
                nameBox.BackColor = Color.Red;
                saveButton.Enabled = false;
            }
            else
            {
                nameBox.BackColor = Color.White;
            }

            SaveButton();
        }

        private void inventoryBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryBox.Text) || !int.TryParse(inventoryBox.Text, out int almostDone))
            {
                inventoryBox.BackColor = Color.Red;
                saveButton.Enabled = false;
            }
            else
            {
                inventoryBox.BackColor = Color.White;
            }
            SaveButton();
        }
    

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceBox.Text) || !decimal.TryParse(priceBox.Text, out decimal almostDone))
            {  priceBox.BackColor = Color.Red; saveButton.Enabled = false; }
            else
            {  priceBox.BackColor = Color.White; }
            SaveButton();

        }

        private void minBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minBox.Text) || !int.TryParse(minBox.Text, out int almostDone))
            { 
                minBox.BackColor = Color.Red;
                saveButton.Enabled = false; }
            else
            { minBox.BackColor = Color.White; }
            SaveButton();
        }

        private void maxBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maxBox.Text) || !int.TryParse(maxBox.Text, out int almostDone))
            { maxBox.BackColor = Color.Red; saveButton.Enabled = false; }
            else
            { maxBox.BackColor = Color.White; }
            SaveButton();
        }

        private void idorcompanyBox_TextChanged(object sender, EventArgs e)
        {
            if(companyoridlabel.Text == "MachineID")
            {
                if (string.IsNullOrWhiteSpace(idorcompanyBox.Text) || !int.TryParse(idorcompanyBox.Text, out int almostDone))
                {
                    idorcompanyBox.BackColor = Color.Red;
                    saveButton.Enabled = false;

                }
                else
                {
                    idorcompanyBox.BackColor= Color.White;
                }
            }
           else if(companyoridlabel.Text == "CompanyName")
            {
                if (string.IsNullOrWhiteSpace(idorcompanyBox.Text))
                {
                    idorcompanyBox.BackColor = Color.Red;
                    saveButton.Enabled = false;
                    
                }
                else
                {
                    idorcompanyBox.BackColor = Color.White;
                   
                }
                
            }
            SaveButton();

           

        }
    }
}
