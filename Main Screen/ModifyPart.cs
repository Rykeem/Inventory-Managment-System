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
    public partial class ModifyAddPart : Form
    {
        int autoID = 0;
        public ModifyAddPart()
        {
            InitializeComponent();
            ;
        }

        private void addAddPartLabel_Click(object sender, EventArgs e)
        {

        }

        private void houseButton2_CheckedChanged(object sender, EventArgs e)
        {
            companyoridlabel2.Text = "MachineID";
        }

        private void outsourcedButton2_CheckedChanged(object sender, EventArgs e)
        {
            companyoridlabel2.Text = "CompanyName";
        }

        private void ModifyAddPart_Load(object sender, EventArgs e)
        {
            idBox2.Text = autoID.ToString();
            idBox2.ReadOnly = true;
            autoID++;
        }
    }
}
