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
    }
}
