namespace WinFormsAplicativo_App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "Esse e o texto \r\n";
            s += "no textbox com multiline";
            textBox1.Text = s;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
