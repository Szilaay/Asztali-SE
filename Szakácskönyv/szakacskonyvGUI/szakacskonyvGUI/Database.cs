using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace szakacskonyvGUI
{
    internal class Database
    {
        const string server = "server=linsql.verebely.dc;uid=diak31;password=A9LUHC;database=diak31";

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public MySqlDataReader Dr { get => dr; set => dr = value; }

        public Database(string sql)
        {
            conn = new MySqlConnection(server);
            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
        }

        public void Close()
        {
            conn.Close();
        }

        ~Database()
        {
            conn.Close();
        }
    }
}
