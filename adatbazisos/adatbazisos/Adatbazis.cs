using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace adatbazisos
{
    internal class Adatbazis
    {
        const string SERVER = "server=linsql.verebely.dc;uid=diak31;password=A9LUHC;database=diak31";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public MySqlDataReader Dr { get => dr; set => dr = value; }

        public Adatbazis(string sql)
        {
            conn = new MySqlConnection(SERVER);
            conn.Open();
            cmd = new MySqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
        }

        public void Close()
        {
            conn.Close();
        }

        ~Adatbazis()
        {
            conn.Close();
        }


    }
}
