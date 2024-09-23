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
    public partial class ModifyProduct : Form
    {
        private Inventory _inventory;
        private Product _product;
        private BindingList<Part> _tempList;
        private int _index;

        public ModifyProduct(int index, Product product, Inventory inventory)
        {
            //initilization
            InitializeComponent();
            _inventory = inventory;
            _product = product;
            idBox4.ReadOnly = true;
            _tempList = new BindingList<Part>(_product.AssociatedParts.ToList());
            this._index = index;



            //previous user input data
            idBox4.Text = product.ProductID.ToString();
            nameBox4.Text = product.Name;
            inventoryBox4.Text = product.InStock.ToString();
            priceBox4.Text = product.Price.ToString();
            maxBox4.Text = product.Max.ToString();
            minBox4.Text = product.Min.ToString();



            //datagridssss
            dataGridView6.DataSource = _tempList;
            dataGridView6.Refresh();

            dataGridView5.DataSource = _inventory.AllParts;
            dataGridView5.Refresh();


        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {





        }

        private void saveButton4_Click(object sender, EventArgs e)
        {
            if (int.Parse(maxBox4.Text) < int.Parse(inventoryBox4.Text) || int.Parse(inventoryBox4.Text) < int.Parse(minBox4.Text))
            { MessageBox.Show("Inventory is out of bounds"); }
            if (int.Parse(maxBox4.Text) < int.Parse(minBox4.Text))
            {
                MessageBox.Show("Min can not be greater than max");
            }
            if (int.Parse(maxBox4.Text) >= int.Parse(inventoryBox4.Text) && int.Parse(maxBox4.Text) >= int.Parse(inventoryBox4.Text) && (int.Parse(maxBox4.Text) > int.Parse(minBox4.Text)))
            {
                Product tempProduct = new Product(
                    _tempList,
                    int.Parse(idBox4.Text),
                    nameBox4.Text,
                    int.Parse(inventoryBox4.Text),
                    decimal.Parse(priceBox4.Text),
                    int.Parse(minBox4.Text),
                    int.Parse(maxBox4.Text));


                _inventory.updateProduct(_index, tempProduct);



                this.Close();
                Form1.Instance?.Show();
            }




        }

        private void cancelButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Instance.Show();
        }

        private void addButton4_Click(object sender, EventArgs e)
        {
            if (dataGridView5.CurrentRow != null && dataGridView5.CurrentRow.Selected)
            {
                int Index = dataGridView5.CurrentCell.RowIndex;


                Part part = _inventory.AllParts[Index];
                _tempList.Add(part);


                dataGridView5.Refresh();




            }
        }

        private void deleteButton4_Click(object sender, EventArgs e)
        {

            if (dataGridView6.CurrentRow == null || !dataGridView6.CurrentRow.Selected)
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


                    int Index = dataGridView6.CurrentCell.RowIndex;

                    _product.removeAssociatedPart(Index, _tempList);
                }
            }


        }

        private void searchButton4_Click(object sender, EventArgs e)
        {
            string typedText = searchBox4.Text;
            if (int.TryParse(searchBox4.Text, out int ID))
            {
                _product.lookupAssociatedPart(ID, dataGridView5);
            }

        }
        private void SaveButton()
        {

            if (nameBox4.BackColor == Color.White &&
            inventoryBox4.BackColor == Color.White &&
            priceBox4.BackColor == Color.White &&
            maxBox4.BackColor == Color.White &&
            minBox4.BackColor == Color.White)
            {
                saveButton4.Enabled = true;
            }
            else { saveButton4.Enabled = false; }
        }
        private void nameBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox4.Text) || int.TryParse(nameBox4.Text, out int almostDone))
            {
                nameBox4.BackColor = Color.Red;
                saveButton4.Enabled = false;
            }
            else
            {
                nameBox4.BackColor = Color.White;
            }
            SaveButton();
        }

        private void inventoryBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryBox4.Text) || !int.TryParse(inventoryBox4.Text, out int almostDone))
            {
                inventoryBox4.BackColor = Color.Red;
                saveButton4.Enabled = false;
            }
            else
            {
                inventoryBox4.BackColor = Color.White;
            }
            SaveButton();
        }

        private void priceBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceBox4.Text) || !decimal.TryParse(priceBox4.Text, out decimal almostDone))
            { priceBox4.BackColor = Color.Red; saveButton4.Enabled = false; }
            else
            { priceBox4.BackColor = Color.White; }
            SaveButton();

        }

        private void maxBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maxBox4.Text) || !int.TryParse(maxBox4.Text, out int almostDone))
            { maxBox4.BackColor = Color.Red; saveButton4.Enabled = false; }
            else
            { maxBox4.BackColor = Color.White; }
            SaveButton();
        }

        private void minBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(minBox4.Text) || !int.TryParse(minBox4.Text, out int almostDone))
            {
                minBox4.BackColor = Color.Red;
                saveButton4.Enabled = false;
            }
            else
            { minBox4.BackColor = Color.White; }
            SaveButton();
        }
    }
}
