using IskurTakipSistemi.DataBase;
using IskurTakipSistemi.DataBase.Models;
using IskurTakipSistemi.DataBase.Repos;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
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

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try {
                KatilimciModel model = new KatilimciModel
                {
                    Ktc_id = Convert.ToInt32(txt_id.Text),
                    Ktc_tc = tb_tc.Text,
                    Ktc_ad_soyad = tb_adsoyad.Text,
                    Ktc_gorev_yeri = tb_gorevyeri.Text,
                    Ktc_iban = tb_iban.Text,
                    Ktc_ise_baslama_tarihi = dtp_ise_giris.Value,
                    Ktc_isten_cikma_tarihi = dtp_isten_cikis.Value
                };
                KatilimciRepo repo = new KatilimciRepo();
                repo.Guncelle(model);

                MessageBox.Show("Güncelleme iþlemi tamamlandý.", "Bilgi, ", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                ListeyiYenile();
            }
           
            
             catch (Exception ex)
            {
                MessageBox.Show(
                    "Hata oluþtu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void ListeyiYenile()
        {
            KatilimciRepo repo = new KatilimciRepo();
            dataGridView.DataSource = repo.Listele();
        }
    }
}
