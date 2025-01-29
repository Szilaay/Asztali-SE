using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tb_valutavalto
{
    public partial class frmDeviza : Form
    {
        string file = "devizanemek.txt";
        public frmDeviza()
        {
            InitializeComponent();
        }
        void ErrorMSG(string msg)
        {
            MessageBox.Show(msg, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txDevKod_TextChanged(object sender, EventArgs e)
        {
            if(txDevKod.Text.Length == 3)
            {
                if (File.Exists(file))
                {
                    FileStream fs = new FileStream(file, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);

                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();
                        string[] elemek = sor.Split(';');

                        if (elemek[0] == txDevKod.Text)
                        {
                            ErrorMSG("Már létezik ilyen deviza kód!");
                            txDevKod.Clear();
                            txDevKod.Focus();
                        }
                    }
                    sr.Close();
                    fs.Close();
                }
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

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (txDevKod.Text.Length < 3)
            {
                ErrorMSG("A deviza kód hossza nem megfelelő!");
                txDevKod.Focus();
            }
            else if (txDevNev.Text.Length == 0)
            {
                ErrorMSG("A deviza név nem lehet üres!");
                txDevNev.Focus();
            }
            else
            {
                if (File.Exists(file))
                {
                    FileStream fs = new FileStream(file, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.WriteLine($"\n{txDevKod.Text};{txDevNev.Text}");

                    sw.Close();
                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream(file, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);

                    sw.WriteLine($"{txDevKod.Text};{txDevNev.Text}");

                    sw.Close();
                    fs.Close();

                }

                DialogResult dr = MessageBox.Show("Sikeres mentés! Újabb deviza hozzáadása?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    txDevKod.Clear();
                    txDevNev.Clear();
                    txDevKod.Focus();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
