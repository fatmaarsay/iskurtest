using MySql.Data.MySqlClient;
using System.Data;
using IskurTakipSistemi.DataBase;
using IskurTakipSistemi.DataBase.Repos;
namespace IskurTakipSistemi
    
{
    public partial class Form2 : System.Windows.Forms.Form
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
