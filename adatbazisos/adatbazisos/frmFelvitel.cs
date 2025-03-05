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
    public partial class frmFelvitel : Form
    {
        public frmFelvitel()
        {
            InitializeComponent();
        }

        private void txAr_TextChanged(object sender, EventArgs e)
        {
            if(txAr.TextLength > 0)
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
            if(txRendszam.TextLength < 1 || txTipus.TextLength < 1 || txSzin.TextLength < 1 || txTulaj.TextLength < 1 || txAr.TextLength < 1)
            {
                MessageBox.Show("Minden mező kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string sql = $"INSERT INTO autoker (rendszam, tipus, szin, tulajszam, ar) VALUES ('{txRendszam.Text}', '{txTipus.Text}', '{txSzin.Text}', '{txTulaj.Text}', {txAr.Text});";
                Adatbazis ab = new Adatbazis(sql);

                MessageBox.Show("Az adatok mentése sikeres!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ab.Close();
                this.Close();
            }

        }

        private void btnElvet_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Biztosan elveti a módosításokat?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txTulaj_TextChanged(object sender, EventArgs e)
        {
            if(txTulaj.TextLength > 0)
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
    }
}
