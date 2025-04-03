using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace allatkertGUI
{
    internal class Database
    {
        const string connectionString = "server=linsql.verebely.dc;uid=diak31;password=A9LUHC;database=diak31";
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        public MySqlDataReader Reader { get => reader; set => reader = value; }

        public Database(string sql)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();
        }

        public void Close()
        {
            connection.Close();
        }

        ~Database()
        {
            connection.Close();
        }
    }
}
