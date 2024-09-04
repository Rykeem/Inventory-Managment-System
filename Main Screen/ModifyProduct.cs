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
        int autoID = 0;
        public ModifyProduct()
        {
            InitializeComponent();
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            idBox4.Text = autoID.ToString();
            idBox4.ReadOnly = true;
            autoID++;
        }
    }
}
