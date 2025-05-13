namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "EXECUTANDO....";
            label2.Update();
            for (int i = 0; i <= 5; i++)
            {
                label1.Text = i.ToString();
                label1.Update();
                Thread.Sleep(1000);
            }
            label2.Text = "Fim";
        }
    }
}
