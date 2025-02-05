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

            string sql = "SELECT * FROM autoker";
            Adatbazis ab = new Adatbazis(sql);

            while (ab.Dr.Read())
            {
                dgAdatok.Rows.Add(ab.Dr["autoid"], ab.Dr["rendszam"], ab.Dr["tipus"], ab.Dr["szin"], ab.Dr["tulajszam"], string.Format("{0:N0} Ft.", ab.Dr["ar"]));
            }

            ab.Close();
        }

        public frmFo()
        {
            InitializeComponent();
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            betoltes();
        }
    }
}
