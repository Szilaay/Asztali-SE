using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adatbazisos
{
    public partial class frmFo : Form
    {
        void betoltes()
        {
            dgAdatok.Rows.Clear();

            string kereses = "";
            if(txKereses.TextLength > 0)
            {
                kereses = $" WHERE tipus LIKE '{txKereses.Text}%'";
            }

            string sql = "SELECT * FROM autoker" + kereses;
            Adatbazis ab = new Adatbazis(sql);

            while (ab.Dr.Read())
            {
                dgAdatok.Rows.Add(ab.Dr["autoid"], ab.Dr["rendszam"], ab.Dr["tipus"], ab.Dr["szin"], ab.Dr["tulajszam"], string.Format("{0:N0} Ft.", ab.Dr["ar"]));
            }

            ab.Close();

            sql = "SELECT ROUND(AVG(ar), 0) FROM autoker;";
            ab = new Adatbazis(sql);
            ab.Dr.Read();
            lbAtlag.Text = string.Format("Átlagár: {0:N0} Ft.", ab.Dr[0]);
        }

        public frmFo()
        {
            InitializeComponent();
            lbAtlag.Text = "";
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            betoltes();

        }

        private void txKereses_TextChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void btnUjAdat_Click(object sender, EventArgs e)
        {
            frmFelvitel frm = new frmFelvitel();
            frm.ShowDialog();
        }

        private void btnModositas_Click(object sender, EventArgs e)
        {
            frmModositas frm = new frmModositas();
            frm.ShowDialog();
        }
    }
}
