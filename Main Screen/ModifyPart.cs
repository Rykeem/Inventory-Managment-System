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
            idBox2.Text = part.PartID.ToString() ;
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
            }

        }

        private void outsourcedButton2_CheckedChanged(object sender, EventArgs e)
        {
                if (outsourcedButton2.Checked)
                {
                    companyoridlabel2.Text = "CompanyName";
                }
        }

        private void ModifyAddPart_Load(object sender, EventArgs e)
        {


        }

        private void saveButton2_Click(object sender, EventArgs e)
            
        {
           
            if (companyoridlabel2.Text == "MachineID")
            {
                Inhouse tempPart = new Inhouse(
                    int.Parse(idBox2.Text),
                    nameBox2.Text,
                    int.Parse(inventoryBox2.Text),
                    decimal.Parse(priceBox2.Text),
                    int.Parse(minBox2.Text),
                    int.Parse(maxBox2.Text),
                    int.Parse(idorcompanyBox2.Text)
                    );


                _inventory.updatePart(_index, tempPart);

            }
            else if (companyoridlabel2.Text == "CompanyName")
            {
                Outsourced tempPart = new Outsourced(
                    int.Parse(idBox2.Text),
                    nameBox2.Text,
                    int.Parse(inventoryBox2.Text),
                    decimal.Parse(priceBox2.Text),
                    int.Parse(minBox2.Text),
                    int.Parse(maxBox2.Text),
                    (idorcompanyBox2.Text)
                    );


                _inventory.updatePart(_index, tempPart);
            }




            //_inventory.updatePart(_index, tempPart);

            this.Close();
            Form1.Instance?.Show();

        }
    }
}
