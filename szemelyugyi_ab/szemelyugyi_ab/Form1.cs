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
    public partial class Form1 : Form
    {
        void telephelyFetoltes()
        {
            string lekerdezes = "SELECT nev FROM telephelytorzs";
            Adatbazis ab = new Adatbazis(lekerdezes);

            while (ab.Dr.Read())
            {
                cbTelephely.Items.Add(ab.Dr.GetString("nev"));
            }

            ab.Close();
        }

        void errorMSG(string text)
        {
            MessageBox.Show(text, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            telephelyFetoltes();

            dtBelepes.Value = DateTime.Now;
            dtSzulido.Value = DateTime.Now;
        }

        private void txFizetes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int fizetes = int.Parse(txFizetes.Text);
            } 
            catch
            {
                errorMSG("A fizetés csak számot tartalmazhat!");
                txFizetes.Clear();
                txFizetes.Focus();
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if(txNev.TextLength == 0)
            {
                errorMSG("A név mező nem lehet üres!");
                txNev.Focus();
            }
            else if(txSzulhely.TextLength == 0)
            {
                errorMSG("A születési hely mező nem lehet üres!");
                txSzulhely.Focus();
            }
            else if(txFizetes.TextLength == 0)
            {
                errorMSG("A fizetés mező nem lehet üres!");
                txFizetes.Focus();
            }
            else if(cbBeosztas.SelectedItem is null)
            {
                errorMSG("Válasszon beosztást!");
                cbBeosztas.Focus();
            }
            else if(cbTelephely.SelectedItem is null)
            {
                errorMSG("Válasszon telephelyet!");
                cbTelephely.Focus();
            }
            else if(txSzemid.TextLength < 4)
            {
                errorMSG("A személyi azonosító szám nem lehet rövidebb 4 karakternél!");
                txSzemid.Focus();
            }
            else
            {
                string sql = $"SELECT COUNT(szemid) AS db FROM szemelytorzs WHERE szemid='{txSzemid.Text}'";
                Adatbazis ab = new Adatbazis(sql);

                ab.Dr.Read();

                //int dbszam = Convert.ToInt32(ab.Dr["db"]);
                int dbszam = ab.Dr.GetInt32("db");
                if (dbszam > 0)
                {
                    errorMSG("Már létezik ilyen személyi azonosító szám!");
                    txSzemid.Focus();
                    txSzemid.Clear();
                }
                else
                {
                    string lekerdezes = $"INSERT INTO szemelytorzs(szemid, nev, szulhely, szulido, fizetes, belepdatum, kilepdatum, beosztas)" +
                        $" VALUES" +
                        $" ('{txSzemid.Text}', '{txNev.Text}', '{txSzulhely.Text}', '{dtSzulido.Text}', '{txFizetes.Text}', '{dtBelepes.Text}', NULL, '{cbBeosztas.Text.ToLower()[0]}')" +
                        $"";

                    ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();

                    ab.Close();

                    lekerdezes = $"SELECT tid FROM telephelytorzs WHERE nev='{cbTelephely.Text}'";
                    ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();

                    string tid = ab.Dr["tid"].ToString();
                    ab.Close();

                    lekerdezes = $"INSERT INTO szemely_telep(szemid, tid) VALUES ({txSzemid.Text}, '{tid}')";
                    ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();



                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStatisztika frm = new frmStatisztika();
            frm.Show();
        }
    }
}
