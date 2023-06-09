﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;


namespace Tugas_PBO_Winform
{
    internal class DBHelpers
    {
        string ConnectionString = $"Host=localhost;Port=5432;Username=postgres;Password=daffa2005;Database=Database_Laptop;";
        NpgsqlConnection conn = null;

        public DBHelpers()
        {
            conn = new NpgsqlConnection(ConnectionString);
        }

        public void Execute(string Query)
        {

            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(Query, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        public NpgsqlDataReader Select(string Query)
        {
            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(Query, conn);
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}