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
    public partial class AddProduct : Form
    {

        private Inventory _inventory;
        private Product _product;
        private BindingList<Part> _tempList;

        public AddProduct(Inventory inventory, Product product)
        {
            InitializeComponent();
            _inventory = inventory;
            _product = product;
            idBox3.Text = inventory._id2.ToString();
            idBox3.ReadOnly = true;
            inventory = _inventory;
            _tempList = new BindingList<Part>();



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = _inventory.AllParts;
            dataGridView3.Refresh();
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = _tempList;
            dataGridView4.Refresh();
            //HideRows();

        }

        private void addButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow != null || dataGridView3.CurrentRow.Selected)
            {
                int Index = dataGridView3.CurrentCell.RowIndex;


                Part part = _inventory.AllParts[Index];
                _tempList.Add(part);


                dataGridView4.Refresh();


            }
        }

        private void cancelButton3_Click(object sender, EventArgs e)
        {


            this.Close();
            Form1.Instance?.Show();


        }

        private void saveButton3_Click(object sender, EventArgs e)
        {
            foreach (Part part in _tempList)
            {
                _product.addAssociatedPart(part); // adds each row to binding list
            }


            if (int.Parse(maxBox3.Text) < int.Parse(inventoryBox3.Text) || int.Parse(inventoryBox3.Text) < int.Parse(minBox3.Text))
            { MessageBox.Show("Inventory is out of bounds"); }
            if (int.Parse(maxBox3.Text) < int.Parse(minBox3.Text))
            {
                MessageBox.Show("Min can not be greater than max");
            }
            if (int.Parse(maxBox3.Text) >= int.Parse(inventoryBox3.Text) && int.Parse(inventoryBox3.Text) >= int.Parse(minBox3.Text) && (int.Parse(maxBox3.Text) > int.Parse(minBox3.Text)))
            {
                Product tempPart = new Product(
                _tempList,
                0,// id 
                nameBox3.Text,//name 
                int.Parse(inventoryBox3.Text),// inventory
                decimal.Parse(priceBox3.Text),//price
                int.Parse(minBox3.Text),//min
                int.Parse(maxBox3.Text)// max
                // max
                );

                _inventory.AddProduct(tempPart);



                Form1.Instance.UpdateGrid1(_inventory);
                this.Close();
                Form1.Instance?.Show();


            }



            
        }

        private void deleteButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView4.CurrentRow == null || !dataGridView4.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Is Selected");
                return;
            }
            else
            {
                DialogResult confirmation = MessageBox.Show(
                "Are you sure you want to delete that?", "Yes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirmation == DialogResult.OK)
                {


                    int Index = dataGridView4.CurrentCell.RowIndex;

                    _product.removeAssociatedPart(Index, _tempList);
                }
            }
        }

        private void searchButton3_Click(object sender, EventArgs e)
        {
            string typedText = searchBox3.Text;
            if (int.TryParse(searchBox3.Text, out int ID))
            {
                _product.lookupAssociatedPart(ID, dataGridView3);
            }

        }
        private void SaveButton()
        {

            if (nameBox3.BackColor == Color.White &&
            inventoryBox3.BackColor == Color.White &&
            priceBox3.BackColor == Color.White &&
            maxBox3.BackColor == Color.White &&
            minBox3.BackColor == Color.White)
            {
                saveButton3.Enabled = true;
            }
            else { saveButton3.Enabled = false; }
        }
        private void nameBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox3.Text) || int.TryParse(nameBox3.Text, out int almostDone))
            {
                nameBox3.BackColor = Color.Red;
                saveButton3.Enabled = false;
            }
            else
            {
                nameBox3.BackColor = Color.White;
            }
            SaveButton();
        }

        private void inventoryBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryBox3.Text) || !int.TryParse(inventoryBox3.Text, out int almostDone))
            {
                inventoryBox3.BackColor = Color.Red;
                saveButton3.Enabled = false;
            }
            else
            {
                inventoryBox3.BackColor = Color.White;
            }
            SaveButton();
        }

        private void priceBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceBox3.Text) || !decimal.TryParse(priceBox3.Text, out decimal almostDone))
            { priceBox3.BackColor = Color.Red; saveButton3.Enabled = false; }
            else
            { priceBox3.BackColor = Color.White; }
            SaveButton();
        }

        private void maxBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maxBox3.Text) || !int.TryParse(maxBox3.Text, out int almostDone))
            { maxBox3.BackColor = Color.Red; saveButton3.Enabled = false; }
            else
            { maxBox3.BackColor = Color.White; }
            SaveButton();
        }

        private void minBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minBox3.Text) || !int.TryParse(minBox3.Text, out int almostDone))
            {
                minBox3.BackColor = Color.Red;
                saveButton3.Enabled = false;
            }
            else
            { minBox3.BackColor = Color.White; }
            SaveButton();
        }
    }
}
