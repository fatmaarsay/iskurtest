using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.DataBase
{

    public static class DbConnection
    {
        private static readonly string _connectionString =
            "Server=localhost;Database=iskur;Uid=root;Pwd=BURAYA KENDİ MYSQL ŞİFRENİ YAZ(HENÜZ ŞİFRENİ OLUŞTURMADIYSAN ms123456. YAPTIM BEN KOD PAYLAŞTIĞIMIZDA ORTAK ŞİFRE KOLAYLIK SAĞLAR).";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(_connectionString);

            try
            {
                connection.Open();
                
                return connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
                throw;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Genel bağlantı hatası: " + ex.Message);
                throw;
                
            }
        }
    }


}
