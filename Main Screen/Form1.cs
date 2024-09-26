using Main_Screen.Models;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Main_Screen
{
    public partial class Form1 : Form
    {
        private Inventory _inventory;
        private Product _product;
        

        public static Form1 Instance { get; set; }
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            _inventory = new Inventory();
            _product = new Product();

        }
        public void UpdateGrid1(Inventory inventory)
        {

            _inventory = inventory;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _inventory.AllParts;
            dataGridView1.Refresh();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = _inventory.Products;
            dataGridView2.Refresh();
            HideRows();
        }



        public void HideRows()
        {
            if (dataGridView1.Columns.Count >= 7)
            {
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }
            if (dataGridView2.Rows.Count >= 7)
            {
                dataGridView2.Rows[6].Visible = false;
                dataGridView2.Rows[7].Visible = false;
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {

            AddPart AddPart = new AddPart(_inventory);
            AddPart.Show();
            this.Hide();
            HideRows();
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            AddProduct AddPart = new AddProduct(_inventory, _product);
            AddPart.Show();
            this.Hide();


        }

        private void modifyButton1_Click(object sender, EventArgs e)
        {



            if (dataGridView1.CurrentRow == null || !dataGridView1.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Is Selected");
                return;
            }
            int Index = dataGridView1.CurrentCell.RowIndex;


            Part part = _inventory.AllParts[Index];
            ModifyPart AddPart = new ModifyPart(Index, part, _inventory);
            AddPart.Show();

            this.Hide();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modifyButton2_Click(object sender, EventArgs e)
        {


            if (dataGridView2.CurrentRow == null || !dataGridView2.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Is Selected");
                return;
            }
            int Index = dataGridView2.CurrentCell.RowIndex;


            Product product = _inventory.Products[Index];
            if (product.AssociatedParts.Count == 0)
            {
                MessageBox.Show("empty box");
            }
            ModifyProduct modifyProduct = new ModifyProduct(Index, product, _inventory);
            modifyProduct.Show();

            this.Hide();
        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            
           
           

            if (dataGridView1.CurrentRow == null || !dataGridView1.CurrentRow.Selected)
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

                    int Indexy = dataGridView1.CurrentCell.RowIndex;


                    Part part = _inventory.AllParts[Indexy];
                    _inventory.deletePart(part);
                }
            }



        }

        private void searchButton1_Click(object sender, EventArgs e)
        {

            string typedText = searchBox1.Text;
            if (int.TryParse(searchBox1.Text, out int ID))
            {
                _inventory.LookupPart(ID, dataGridView1);
                

            }
            else
            {
                  bool searchSuccess = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                

                if (row.Cells["Name"].Value != null)
                {
                    
                    string tempVal = row.Cells["Name"].Value.ToString();
                    
                    {
                        if (typedText == tempVal)
                        {
                            row.Selected = true;
                            searchSuccess = true;
                        }
                       

                    }
                     

                }
                

            };
            if (!searchSuccess)
            {
                MessageBox.Show("Item not found");
            }
            
            }
           
           
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            int Index = dataGridView2.CurrentCell.RowIndex;
            var ascParts = _inventory.Products[Index];
            bool isInParts = false;
            if (dataGridView2.CurrentRow == null || !dataGridView2.CurrentRow.Selected)
                {
                    MessageBox.Show("Nothing Is Selected");
                    return;
                }

            foreach (var part in ascParts.AssociatedParts) 
            {
                if (part != null)
                    {  isInParts = true; break; }
            }
            if(isInParts)
            {

                MessageBox.Show("The product can't be deleted it has a part assigned to it");
            }
            else
            {
                DialogResult confirmation = MessageBox.Show(
                "Are you sure you want to delete that?", "Yes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirmation == DialogResult.OK)
                {


                    



                    _inventory.removeProduct(Index);
                }

            }
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            string typedText = searchBox2.Text;
            if (int.TryParse(searchBox2.Text, out int ID))
            {
                _inventory.lookupProduct(ID, dataGridView2);
               
            }
            else
            {
                bool searchSuccess = false;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {


                    if (row.Cells["Name"].Value != null)
                    {

                        string tempVal = row.Cells["Name"].Value.ToString();

                        {
                            if (typedText == tempVal)
                            {
                                row.Selected = true;
                                searchSuccess = true;
                            }


                        }


                    }


                };
                if (!searchSuccess)
                {
                    MessageBox.Show("Item not found");
                }

            }



        }
    }
}
    

