using MySql.Data.MySqlClient;
using System.Data;


namespace WinFormsApp1.DataBase
{
    public class DbRepository
    {
        public DataTable GetAll(string tableName)
        {
            try
            {
                var datatable = new DataTable();

                using var con = DbConnection.GetConnection();
                using var adapter = new MySqlDataAdapter(
                    $"SELECT * FROM {tableName}", con);

                adapter.Fill(datatable);
                return datatable;
            }
            catch (Exception ex)
            {
                throw new Exception("Başarısız veri çekme işlemi, hata: " + tableName, ex);
            }

        }

        public DataTable GetByQuery(string sql, params MySqlParameter[] parameters)
        {
            try
            {
                var datatable = new DataTable();

                using var con = DbConnection.GetConnection();
                using var cmd = new MySqlCommand(sql, con);

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(datatable);

                return datatable;
            }
            catch (Exception ex)
            {
                throw new Exception("Başarısız sorgu işlemi, hata: " + parameters, ex);
            }

        }

        public void Execute(string sql, params MySqlParameter[] parameters)
        {
            try
            {
                using var con = DbConnection.GetConnection();
                using var cmd = new MySqlCommand(sql, con);

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Başarısız veri tabanı komutu, hata: " + parameters, ex);
            }
        }

        internal void Execute()
        {
            throw new NotImplementedException();
        }
    }
}


