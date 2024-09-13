using Main_Screen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
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
    public partial  class AddPart : Form
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
        }

        private void outsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            companyoridlabel.Text = "CompanyName";

        }




        public void saveButton_Click(object sender, EventArgs e) 
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
            }
            else if (companyoridlabel.Text == "CompanyName")
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
            }

            


            Form1.Instance?.UpdateGrid1(_inventory);
           this.Close();
           Form1.Instance?.Show();

            

        }

        private void AddPart_Load(object sender, EventArgs e)
        {
       
            
            
        }


        

        

    }
}
