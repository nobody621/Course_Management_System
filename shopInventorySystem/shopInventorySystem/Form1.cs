using MySql.Data.MySqlClient;

namespace shopInventorySystem
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addItemForm additemform = new addItemForm();
            this.Hide();
            additemform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Database=shopdb;User Id=root;Password=;";

                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
