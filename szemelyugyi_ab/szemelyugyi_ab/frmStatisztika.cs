using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szemelyugyi_ab
{
    public partial class frmStatisztika : Form
    {
        void betoltes()
        {
            string query = "";
            string serachquery = "";
            dataGridView1.Rows.Clear();

            if (rbKilepettek.Checked)
            {
                query = "SELECT " +
                "szemelytorzs.nev, " +
                "szemelytorzs.szulido, " +
                "YEAR(CURDATE()) - YEAR(szemelytorzs.szulido) AS eletkor, " +
                "szemelytorzs.fizetes, " +
                "szemelytorzs.belepdatum, " +
                "CASE " +
                "WHEN szemelytorzs.beosztas = 'v' THEN 'Vezető' " +
                "WHEN szemelytorzs.beosztas = 'sz' THEN 'Szellemi' " +
                "ELSE 'Fizikai' " +
                "END AS beosztas, " +
                "szemelytorzs.kilepdatum, " +
                "telephelytorzs.nev AS thnev " +
                "FROM szemelytorzs " +
                "JOIN szemely_telep ON szemelytorzs.szemid = szemely_telep.szemid " +
                "JOIN telephelytorzs ON szemely_telep.tid = telephelytorzs.tid " +
                "WHERE szemelytorzs.kilepdatum is NOT NULL " +
                "GROUP BY szemelytorzs.nev " +
                "ORDER BY szemelytorzs.nev;"
                ;
            }
            else if (rbMindenki.Checked)
            {
                query = "SELECT " +
                "szemelytorzs.nev, " +
                "szemelytorzs.szulido, " +
                "YEAR(CURDATE()) - YEAR(szemelytorzs.szulido) AS eletkor, " +
                "szemelytorzs.fizetes, " +
                "szemelytorzs.belepdatum, " +
                "CASE " +
                "WHEN szemelytorzs.beosztas = 'v' THEN 'Vezető' " +
                "WHEN szemelytorzs.beosztas = 'sz' THEN 'Szellemi' " +
                "ELSE 'Fizikai' " +
                "END AS beosztas, " +
                "szemelytorzs.kilepdatum, " +
                "telephelytorzs.nev AS thnev " +
                "FROM szemelytorzs " +
                "JOIN szemely_telep ON szemelytorzs.szemid = szemely_telep.szemid " +
                "JOIN telephelytorzs ON szemely_telep.tid = telephelytorzs.tid " +
                "GROUP BY szemelytorzs.nev " +
                "ORDER BY szemelytorzs.nev;"
                ;
            }
            else if (rbAktivak.Checked)
            {
                query = "SELECT " +
                "szemelytorzs.nev, " +
                "szemelytorzs.szulido, " +
                "YEAR(CURDATE()) - YEAR(szemelytorzs.szulido) AS eletkor, " +
                "szemelytorzs.fizetes, " +
                "szemelytorzs.belepdatum, " +
                "CASE " +
                "WHEN szemelytorzs.beosztas = 'v' THEN 'Vezető' " +
                "WHEN szemelytorzs.beosztas = 'sz' THEN 'Szellemi' " +
                "ELSE 'Fizikai' " +
                "END AS beosztas, " +
                "szemelytorzs.kilepdatum, " +
                "telephelytorzs.nev AS thnev " +
                "FROM szemelytorzs " +
                "JOIN szemely_telep ON szemelytorzs.szemid = szemely_telep.szemid " +
                "JOIN telephelytorzs ON szemely_telep.tid = telephelytorzs.tid " +
                "WHERE szemelytorzs.kilepdatum IS NULL " +
                "GROUP BY szemelytorzs.nev " +
                "ORDER BY szemelytorzs.nev;"
                ;
            }

            if(txKereses.TextLength > 0)
            {
                query = "SELECT " +
                "szemelytorzs.nev, " +
                "szemelytorzs.szulido, " +
                "YEAR(CURDATE()) - YEAR(szemelytorzs.szulido) AS eletkor, " +
                "szemelytorzs.fizetes, " +
                "szemelytorzs.belepdatum, " +
                "CASE " +
                "WHEN szemelytorzs.beosztas = 'v' THEN 'Vezető' " +
                "WHEN szemelytorzs.beosztas = 'sz' THEN 'Szellemi' " +
                "ELSE 'Fizikai' " +
                "END AS beosztas, " +
                "szemelytorzs.kilepdatum, " +
                "telephelytorzs.nev AS thnev " +
                "FROM szemelytorzs " +
                "JOIN szemely_telep ON szemelytorzs.szemid = szemely_telep.szemid " +
                "JOIN telephelytorzs ON szemely_telep.tid = telephelytorzs.tid " +
                "WHERE szemelytorzs.nev LIKE '" + txKereses.Text + "%' " +
                "GROUP BY szemelytorzs.nev " +
                "ORDER BY szemelytorzs.nev;"
                ;
            }

            Adatbazis ab = new Adatbazis(query);
            while (ab.Dr.Read())
            {
                DateTime szulido = Convert.ToDateTime(ab.Dr["szulido"]);
                DateTime belepdatum = Convert.ToDateTime(ab.Dr["belepdatum"]);

                string kilepes = "";

                if (!Convert.IsDBNull(ab.Dr["kilepdatum"]))
                {
                    kilepes = Convert.ToDateTime(ab.Dr["kilepdatum"]).ToString("yyyy-MM-dd");
                }


                dataGridView1.Rows.Add(
                    ab.Dr["nev"].ToString(),
                    szulido.ToString("yyyy-MM-dd"),
                    ab.Dr["eletkor"].ToString(),
                    ab.Dr["fizetes"].ToString(),
                    belepdatum.ToString("yyyy-MM-dd"),
                    ab.Dr["beosztas"].ToString(),
                    kilepes,
                    ab.Dr["thnev"].ToString()
                    );
            }
        }
        public frmStatisztika()
        {
            InitializeComponent();
        }

        private void frmStatisztika_Load(object sender, EventArgs e)
        {
            rbMindenki.Checked = true;
            betoltes();
        }

        private void rbAktivak_CheckedChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void rbKilepettek_CheckedChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void rbMindenki_CheckedChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void txKereses_TextChanged(object sender, EventArgs e)
        {
            betoltes();
        }
    }
}
