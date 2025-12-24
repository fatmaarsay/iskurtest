using MySql.Data.MySqlClient;

namespace WinFormsApp1.DataBase
{

    public static class DbConnection
    {
        private static readonly string _connectionString =
            "Server=localhost;Database=iskur;Uid=root;Pwd=ms123456.";

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
