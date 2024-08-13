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
        int autoID =  0;
        public AddProduct()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            idBox3.Text = autoID.ToString();
            idBox3.ReadOnly = true;
            autoID++;
        }
    }
}
