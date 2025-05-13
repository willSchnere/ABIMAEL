namespace WinFormsAplicativo_App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TXTBOX1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            label1.Text = TXTBOX1.Text;
        }
    }
}
