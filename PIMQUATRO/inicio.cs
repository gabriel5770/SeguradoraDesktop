namespace PIMQUATRO
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {  
           this.Hide();
           new PageLogin().ShowDialog();                     

        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }
    }
}