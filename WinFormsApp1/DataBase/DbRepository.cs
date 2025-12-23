using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;


namespace WinFormsApp1.DataBase
{
    public class DbRepository
    {
        public DataTable GetAll(string tableName)
        {
            var datatable = new DataTable();

            using var con = DbConnection.GetConnection();
            using var adapter = new MySqlDataAdapter(
                $"SELECT * FROM {tableName}", con);

            adapter.Fill(datatable);
            return datatable;
        }

        public DataTable GetByQuery(string sql, params MySqlParameter[] parameters)
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

        public void Execute(string sql, params MySqlParameter[] parameters)
        {
            using var con = DbConnection.GetConnection();
            using var cmd = new MySqlCommand(sql, con);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        internal void Execute()
        {
            throw new NotImplementedException();
        }
    }
}


