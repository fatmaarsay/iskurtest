using MySql.Data.MySqlClient;
using System.Data;
using WinFormsApp1.DataBase;
namespace WinFormsApp1
    
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      
     
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var repo = new KatilimciRepo();
            dataGridView.DataSource = repo.Listele();

        }


    }
}
