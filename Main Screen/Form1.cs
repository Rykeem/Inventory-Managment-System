using Main_Screen.Models;
using System.ComponentModel;
using System.Data;

namespace Main_Screen
{
    public partial class Form1 : Form
    {
        private Inventory _inventory;

        public static Form1 Instance { get; set; }
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            _inventory = new Inventory();

        }
        public void UpdateGrid1(Inventory inventory)
        {

            _inventory = inventory;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _inventory.AllParts;
            dataGridView1.Refresh();
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
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            AddProduct AddPart = new AddProduct();
            AddPart.Show();
            this.Hide();

        }

        private void modifyButton1_Click(object sender, EventArgs e)
        {
            ModifyAddPart AddPart = new ModifyAddPart();
            AddPart.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modifyButton2_Click(object sender, EventArgs e)
        {
            ModifyProduct AddPart = new ModifyProduct();
            AddPart.Show();
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
            
            int Index = dataGridView1.CurrentCell.RowIndex;

            //_inventory.AllParts.RemoveAt(Index);
            Part part = _inventory.AllParts[Index];
           _inventory.deletePart(part);
            


        }
    }

}
    

