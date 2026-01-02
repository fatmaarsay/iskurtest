using MySql.Data.MySqlClient;
using System.Data;


namespace IskurTakipSistemi.DataBase
{
    public class DbRepository
    {
        //parametreli select sorguları için, data table döndüren method
        public DataTable GetByQuery(string sql, params MySqlParameter[] parameters)
        {
            try
            {
                var dt = new DataTable();

                using var con = DbConnection.GetConnection();
                using var cmd = new MySqlCommand(sql, con);

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //parametreli sorgular için
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
            catch (Exception)
            {
                throw;
            }
        }
    }

}


