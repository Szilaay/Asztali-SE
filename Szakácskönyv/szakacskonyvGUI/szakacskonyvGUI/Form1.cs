using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szakacskonyvGUI
{
    public partial class Form1 : Form
    {
        void betoltes()
        {
            dagi.Rows.Clear();

            string kereses = "";
            if (txKereses.TextLength > 0)
            {
                kereses = " WHERE etelek.nev LIKE '" + txKereses.Text + "%'";
            }

            string sql = "SELECT etelek.nev, etelek.elkeszitesiido, etelek.besorolas, alapanyagok.nev AS anev, alapanyagok.mennyiseg AS amenny, hozzavalok.mennyiseg AS hmenny, etelek.leiras FROM etelek JOIN hozzavalok ON etelek.etelid = hozzavalok.etelid JOIN alapanyagok ON hozzavalok.anyagid = alapanyagok.anyagid" + kereses + " ORDER BY etelek.nev;";
            Database db = new Database(sql);

            while (db.Dr.Read())
            {
                dagi.Rows.Add(db.Dr["nev"], 
                    db.Dr["elkeszitesiido"], 
                    db.Dr["besorolas"].ToString() == "l" ? "Leves" : db.Dr["besorolas"].ToString() == "k" ? "Készétel" : db.Dr["besorolas"].ToString() == "é" ? "Édesség" : "Főzelék",
                    db.Dr["anev"],
                    db.Dr["hmenny"],
                    db.Dr["amenny"],
                    db.Dr["leiras"]
                    );
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
        }

        private void txKereses_TextChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void dagi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = dagi.Rows[e.RowIndex].Cells[6].Value.ToString() + "\n";
        }
    }
}
