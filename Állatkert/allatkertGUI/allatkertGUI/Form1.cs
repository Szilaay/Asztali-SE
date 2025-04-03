using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allatkertGUI
{
    public partial class Form1 : Form
    {
        void betoltes()
        {
            dagiAdatok.Rows.Clear();

            string kereses = "";
            if (txKereses.TextLength > 0)
            {
                kereses = $" WHERE megnevezes LIKE '{txKereses.Text}%'";
            }

            string sql = "SELECT * FROM jegyek" + kereses + " ORDER BY jegytipus ASC, ar ASC";
            Database db = new Database(sql);

            while (db.Reader.Read())
            {
                dagiAdatok.Rows.Add(
                    db.Reader["megnevezes"],
                    db.Reader["jegytipus"].ToString() == "1" ? "egy főre" : db.Reader["jegytipus"].ToString() == "2" ? "családra" : "csoportos /fő",
                    db.Reader["ar"],
                    db.Reader["reszletek"]
                );
            }

            db.Close();
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

        private void dagiAdatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dagiAdatok.Rows[e.RowIndex];
                if (row.Cells["reszletek"].Value.ToString().Length > 0)
                {
                    lbLeiras.Text = row.Cells["reszletek"].Value.ToString();
                }
                else
                {
                    lbLeiras.Text = "";
                }
            }
        }
    }
}
