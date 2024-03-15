namespace ptpm18aboba
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                new Form2(this).Show();
            }
            if (radioButton2.Checked)
            {
                new Form3(this).Show();
            }
            if (radioButton3.Checked)
            {
                new Form4(this).Show();
            }
        }
    }
}
