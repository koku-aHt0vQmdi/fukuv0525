namespace fukuv0525
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ìcü∫");
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top -= 15;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Left += 15;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left -= 15;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Top += 15;
        }
    }
}