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
    public partial class frmModositas : Form
    {
        string autoazonosito = "";
        List<string> arList = new List<string>(); // create Ár list

        void betoltes()
        {
            dgAdatok.Rows.Clear();

            string kereses = "";
            if (txKereses.TextLength > 0)
            {
                kereses = $" WHERE rendszam LIKE '{txKereses.Text}%'";
            }

            string sql = "SELECT * FROM autoker" + kereses;
            Adatbazis ab = new Adatbazis(sql);

            while (ab.Dr.Read())
            {
                dgAdatok.Rows.Add(ab.Dr["autoid"], ab.Dr["rendszam"], ab.Dr["tipus"], ab.Dr["szin"], ab.Dr["tulajszam"], string.Format("{0:N0} Ft.", ab.Dr["ar"]));
                arList.Add(ab.Dr["ar"].ToString()); // add ar to the list
            }

            ab.Close();
        }
        public frmModositas()
        {
            InitializeComponent();
        }

        private void frmModositas_Load(object sender, EventArgs e)
        {
            betoltes();
        }

        private void txKereses_TextChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void btnElvet_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Biztosan elveti a módosításokat?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgAdatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgAdatok.Rows[e.RowIndex];
            autoazonosito = row.Cells["autoid"].Value.ToString();
            txAzon.Text = row.Cells["autoid"].Value.ToString();

            txRendszam.Text = row.Cells["rendszam"].Value.ToString();
            txSzin.Text = row.Cells["szin"].Value.ToString();
            txTipus.Text = row.Cells["tipus"].Value.ToString();
            txTulaj.Text = row.Cells["tulajszam"].Value.ToString();
            txAr.Text = arList[int.Parse(autoazonosito) - 1];

        }

        private void txTulaj_TextChanged(object sender, EventArgs e)
        {
            if (txTulaj.TextLength > 0)
            {
                try
                {
                    int.Parse(txTulaj.Text);
                }
                catch
                {
                    MessageBox.Show("Csak számot írhat be!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txTulaj.Clear();
                }
            }
        }

        private void txAr_TextChanged(object sender, EventArgs e)
        {
            if (txAr.TextLength > 0)
            {
                try
                {
                    int.Parse(txAr.Text);
                }
                catch
                {
                    MessageBox.Show("Csak számot írhat be!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txAr.Clear();
                }
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (txRendszam.TextLength < 1 || txTipus.TextLength < 1 || txSzin.TextLength < 1 || txTulaj.TextLength < 1 || txAr.TextLength < 1)
            {
                MessageBox.Show("Minden mező kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string sql = $"UPDATE autoker set rendszam='{txRendszam.Text}', tipus='{txTipus.Text}', szin='{txSzin.Text}', tulajszam='{txTulaj.Text}', ar='{txAr.Text}' WHERE autoid='{autoazonosito}'";
                Adatbazis ab = new Adatbazis(sql);

                MessageBox.Show("Az adatok mentése sikeres!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ab.Close();
                this.Close();
            }
        }
    }
}
