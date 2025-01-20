using System.Security.Cryptography.X509Certificates;

namespace additemform
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


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string itemName = textBox2.Text;
            int quantity = Convert.ToInt32(textBox3.Text);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
