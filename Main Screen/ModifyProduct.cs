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


            dataGridView6.DataSource = _tempList;
            dataGridView6.Refresh();



        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

            dataGridView5.DataSource = _inventory.AllParts;
            dataGridView5.Refresh();
           
            


        }

        private void saveButton4_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Instance.Close();
        }

        private void addButton4_Click(object sender, EventArgs e)
        {
            if (dataGridView5.CurrentRow != null && dataGridView5.CurrentRow.Selected)
            {
                int Index = dataGridView5.CurrentCell.RowIndex;


                Part part = _inventory.AllParts[Index];
                _tempList.Add(part);


                dataGridView5.Refresh();

                //not done yet need to add row in


            }
        }
    }
}
