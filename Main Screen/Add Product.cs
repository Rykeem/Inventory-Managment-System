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
            _tempList = new BindingList<Part>(_product.AssociatedParts.ToList());

            

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


           
            {
                Product tempPart = new Product(
                _product.AssociatedParts,
                0,// id 
                nameBox3.Text,//name 
                int.Parse(inventoryBox3.Text),// inventory
                decimal.Parse(priceBox3.Text),//price
                int.Parse(minBox3.Text),//min
                int.Parse(maxBox3.Text)// max
                // max
                );

                _inventory.AddProduct(tempPart);

                
               


               
            }
           
            
            
            Form1.Instance.UpdateGrid1(_inventory);
            this.Close();
            Form1.Instance?.Show();
        }
    }
}
