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
    public partial class Part : Form
    {
        int autoID = 0;
        public Part()
        {
            InitializeComponent();
            
            
            idBox1.Text = autoID.ToString();
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            autoID++;
        }
    }
}
