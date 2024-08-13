namespace Main_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            Part part = new Part();
            part.Show();
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            AddProduct part = new AddProduct();
            part.Show();
        }

        private void modifyButton1_Click(object sender, EventArgs e)
        {
            ModifyPart part = new ModifyPart();
            part.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
